using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DL;
using EL;
using DevExpress.XtraGrid.Views.Grid;

namespace AMS
{
    public partial class frmProjectMaster : DevExpress.XtraEditors.XtraForm
    {
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        public frmProjectMaster()
        {
            InitializeComponent();
        }

        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            objDProject.GetProjects(objEProject);
            gcSubTask.DataSource = objEProject.dtProjects;
            objDProject.GetUsers(objEProject);
            cmbTask.DataSource = objEProject.dtUsers;
            cmbTask.ValueMember = "UserInfoID";
            cmbTask.DisplayMember = "FullName";
        }

        private void gvTask_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["ProjectID"], 0);
            }
            catch (Exception ex) { }
        }

        private void gvTask_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objEProject.ProjectID = row["ProjectID"];
                objEProject.ProjectName = row["ProjectName"];
                objEProject.ProjectLeadID = row["UserInfoID"];
                objEProject.IsActive = row["IsActive"];
                objDProject.SaveProjectList(objEProject);
                row["ProjectID"] = objEProject.ProjectID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}
