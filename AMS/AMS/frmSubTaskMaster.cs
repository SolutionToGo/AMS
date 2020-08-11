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
    public partial class frmSubTaskMaster : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmSubTaskMaster()
        {
            InitializeComponent();
        }

        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            objDTimeSheet.GetSubTask(objETimeSheet);
            gcSubTask.DataSource = objETimeSheet.dtSubTask;
            objDTimeSheet.GetTask(objETimeSheet);
            cmbTask.DataSource = objETimeSheet.dtTask;
            cmbTask.ValueMember = "TaskID";
            cmbTask.DisplayMember = "TaskDescription";
        }

        private void gvTask_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["SubTaskID"], 0);
            }
            catch (Exception ex) { }
        }

        private void gvTask_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objETimeSheet.SubTaskID = Convert.ToString(row["SubTaskID"]);
                objETimeSheet.SubTaskDescription = Convert.ToString(row["SubTaskDescription"]);
                objETimeSheet.TaskID = Convert.ToString(row["TaskID"]);
                objDTimeSheet.SaveSubTask(objETimeSheet);
                row["SubTaskID"] = objETimeSheet.SubTaskID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}