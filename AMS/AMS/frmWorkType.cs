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
    public partial class frmWorkType : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmWorkType()
        {
            InitializeComponent();
        }

        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            objDTimeSheet.GetWorkType(objETimeSheet);
            gcWorkType.DataSource = objETimeSheet.dtWorkType;
            objDTimeSheet.GetSubTask(objETimeSheet);
            cmbSubTask.DataSource = objETimeSheet.dtSubTask;
            cmbSubTask.ValueMember = "SubTaskID";
            cmbSubTask.DisplayMember = "SubTaskDescription";
        }

        private void gvTask_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["WorkTypeID"], 0);
            }
            catch (Exception ex) { }
        }

        private void gvTask_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objETimeSheet.SubTaskID = Convert.ToString(row["WorkTypeID"]);
                objETimeSheet.SubTaskDescription = Convert.ToString(row["WorkTypeDescription"]);
                objETimeSheet.TaskID = Convert.ToString(row["SubTaskID"]);
                objDTimeSheet.SaveWorkType(objETimeSheet);
                row["WorkTypeID"] = objETimeSheet.WorkTypeID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}