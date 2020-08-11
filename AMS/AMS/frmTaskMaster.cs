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
    public partial class frmTaskMaster : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmTaskMaster()
        {
            InitializeComponent();
        }

        private void frmTaskMaster_Load(object sender, EventArgs e)
        {
            objDTimeSheet.GetTask(objETimeSheet);
            gcTask.DataSource = objETimeSheet.dtTask;
        }

        private void gvTask_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["TaskID"], 0);
            }
            catch (Exception ex) { }
        }

        private void gvTask_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objETimeSheet.TaskID = Convert.ToString(row["TaskID"]);
                objETimeSheet.TaskDescription = Convert.ToString(row["TaskDescription"]);
                objDTimeSheet.SaveTask(objETimeSheet);
                row["TaskID"] = objETimeSheet.TaskID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}