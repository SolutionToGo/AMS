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
    public partial class frmProjectWorkType : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmProjectWorkType()
        {
            InitializeComponent();
        }

        private void frmTaskMaster_Load(object sender, EventArgs e)
        {
            objDTimeSheet.GetProjectWorkType(objETimeSheet);
            gcTask.DataSource = objETimeSheet.dtWorkType;
        }

        private void gvTask_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["ProjectWorkTypeID"], 0);
            }
            catch (Exception ex) { }
        }

        private void gvTask_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objETimeSheet.WorkTypeID = Convert.ToString(row["ProjectWorkTypeID"]);
                objETimeSheet. WorkTypeDescription = Convert.ToString(row["WorkTypeDescription"]);
                objDTimeSheet.SaveProjectWorkType(objETimeSheet);
                row["ProjectWorkTypeID"] = objETimeSheet.WorkTypeID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}