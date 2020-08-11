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

namespace AMS
{
    public partial class frmTimeSheetEdit : DevExpress.XtraEditors.XtraForm
    {
        ETimeSheet objETimeSheet = null;
        DTimeSheet objDTimeSheet = new DTimeSheet();
        public frmTimeSheetEdit(ETimeSheet _objETimeSheet)
        {
            InitializeComponent();
            objETimeSheet = _objETimeSheet;
        }

        private void frmTimeSheetEdit_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetTimesheetDetails(objETimeSheet);
                if(objETimeSheet.dsTimesheetdetails != null &&
                   objETimeSheet.dsTimesheetdetails.Tables.Count > 0)
                {
                    txtEmloyeeName.EditValue = objETimeSheet.EmployeeName;
                    dtpLogDate.EditValue = objETimeSheet.dsTimesheetdetails.Tables[0].Rows[0]["LogDate"];
                    dtpDayLogin.EditValue = objETimeSheet.dsTimesheetdetails.Tables[0].Rows[0]["DayLogin"];
                    dtpDayLogout.EditValue = objETimeSheet.dsTimesheetdetails.Tables[0].Rows[0]["DayLogout"];
                    dtpLunchLogin.EditValue = objETimeSheet.dsTimesheetdetails.Tables[0].Rows[0]["LunchLogin"];
                    dtpLunchLogout.EditValue = objETimeSheet.dsTimesheetdetails.Tables[0].Rows[0]["LunchLogout"];
                    gcBreaks.DataSource = objETimeSheet.dsTimesheetdetails.Tables[1];

                    dtpDayLogout.Properties.MinValue = dtpLogDate.DateTime.Date;
                    dtpDayLogout.Properties.MaxValue = dtpLogDate.DateTime.Date.AddSeconds(86399);

                    dtpLunchLogin.Properties.MinValue = dtpLogDate.DateTime.Date;
                    dtpLunchLogin.Properties.MaxValue = dtpLogDate.DateTime.Date.AddSeconds(86399);

                    dtpLunchLogout.Properties.MinValue = dtpLogDate.DateTime.Date;
                    dtpLunchLogout.Properties.MaxValue = dtpLogDate.DateTime.Date.AddSeconds(86399);

                    dtpBreak.MinValue = dtpLogDate.DateTime.Date;
                    dtpBreak.MaxValue = dtpLogDate.DateTime.Date.AddSeconds(86399);
                }
            }
            catch (Exception ex){}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDayLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month &&
                    dtpDayLogout.DateTime <= dtpDayLogin.DateTime)
                    throw new Exception("Logout time cannot be less than or equals to login time");

                if (dtpLunchLogin.DateTime.Month == objETimeSheet.SelectedMonth.Month &&
                    dtpLunchLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month &&
                    dtpLunchLogout.DateTime <= dtpLunchLogin.DateTime)
                    throw new Exception("Lunch logout time cannot be less than  or equals to lunch login time");

                if (dtpLunchLogin.DateTime.Month == objETimeSheet.SelectedMonth.Month 
                    && dtpLunchLogin.DateTime <= dtpDayLogin.DateTime)
                    throw new Exception("Lunch login time cannot be less than  or equals to day login time");

                if (dtpLunchLogin.DateTime.Month == objETimeSheet.SelectedMonth.Month && 
                    dtpDayLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month
                    && dtpLunchLogin.DateTime >= dtpDayLogout.DateTime)
                    throw new Exception("Lunch login time cannot be greater than or equals to day login time");

                if (dtpLunchLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month
                    && dtpLunchLogout.DateTime <= dtpDayLogin.DateTime)
                    throw new Exception("Lunch login time cannot be less than  or equals to day login time");

                if (dtpLunchLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month &&
                    dtpDayLogout.DateTime.Month == objETimeSheet.SelectedMonth.Month
                    && dtpLunchLogout.DateTime >= dtpDayLogout.DateTime)
                    throw new Exception("Lunch logout time cannot be greater than or equals to day login time");

                objETimeSheet.Daylogin = dtpDayLogin.EditValue;
                objETimeSheet.DayLogout = dtpDayLogout.EditValue;
                objETimeSheet.LunchLogin = dtpLunchLogin.EditValue;
                objETimeSheet.LunchLogout = dtpLunchLogout.EditValue;
                objETimeSheet.dtBreaks = objETimeSheet.dsTimesheetdetails.Tables[1].Copy();
                objDTimeSheet.UpdateTimesheetDetails(objETimeSheet);
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDayLogin_QueryPopUp(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void gvBreaks_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gvBreaks_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //try
            //{
            //    DateTime dtBreakout = DateTime.Now;
            //    DateTime dtBreakLogin = DateTime.Now;
            //    DataRow dr = gvBreaks.GetFocusedDataRow();
            //    if (dr != null)
            //    {
            //        if (DateTime.TryParse(Convert.ToString(e.Value), out dtBreakout)
            //            && DateTime.TryParse(Convert.ToString(dr["BreakLogin"]), out dtBreakLogin))
            //        {
            //            if (dtBreakout.Month == objETimeSheet.SelectedMonth.Month
            //                 && dtBreakout <= dtBreakLogin)
            //            {
            //                e.Valid = false;
            //            }
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Utility.ShowError(ex);
            //}
        }
    }
}