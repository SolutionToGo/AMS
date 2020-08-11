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
using EL;
using DL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;

namespace AMS
{
    public partial class frmEmployeeTask : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmEmployeeTask()
        {
            InitializeComponent();
        }

        private void frmEmployeeTask_Load(object sender, EventArgs e)
        {
            tglActiveProjects.IsOn = true;
        }

        private void cmbEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ETimeSheet objETimeSheet = new ETimeSheet();
                DTimeSheet objDTimeSheet = new DTimeSheet();
                objETimeSheet.EmployeeID = cmbEmployeeName.EditValue;
                objDTimeSheet.GetEmployeeTaskforLead(objETimeSheet);
                gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
            }
            catch (Exception ex) { }
        }

        int IValue = 0;
        private void gvTaskManagement_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                // Initialization. 
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    IValue = 0;
                }
                // Calculation.
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                    int TMinutes = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TaskMins"));
                    IValue += TMinutes;
                }
                // Finalization. 
                if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                {
                    string stHours = Convert.ToString(IValue / 60).PadLeft(2, '0');
                    string stMins = Convert.ToString(IValue % 60).PadLeft(2, '0');
                    e.TotalValue = stHours + ":" + stMins;
                }
            }
            catch (Exception ex) { }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gcTaskManagement.ShowRibbonPrintPreview();
        }

        private void tglActiveProjects_Toggled(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.EmployeeID = Utility.UserID;
                objETimeSheet.IsActive = tglActiveProjects.IsOn;
                objETimeSheet.RoleID = Utility.RoleID;
                objDTimeSheet.GetEmpforReport(objETimeSheet);
                cmbEmployeeName.Properties.DataSource = objETimeSheet.dtEmployeeList;
                cmbEmployeeName.Properties.DisplayMember = "FullName";
                cmbEmployeeName.Properties.ValueMember = "UserInfoID";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}