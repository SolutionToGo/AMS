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

namespace AMS
{
    public partial class frmHolidayMaster : DevExpress.XtraEditors.XtraForm
    {
        DHoliday objDHoliday = new DHoliday();
        EHoliday objEHoliday = new EHoliday();
        public frmHolidayMaster()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHoliday.FocusedRowHandle >= 0)
                {
                    objEHoliday.HoliDayID = gvHoliday.GetFocusedRowCellValue("HolidayID");
                    objDHoliday.DeleteHoliday(objEHoliday);
                    gvHoliday.DeleteRow(gvHoliday.FocusedRowHandle);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHoliday.FocusedRowHandle >= 0)
                {
                    objEHoliday.HoliDayID = gvHoliday.GetFocusedRowCellValue("HolidayID");
                    dtHolidayDate.EditValue = gvHoliday.GetFocusedRowCellValue("HolidayDate");
                    txtHolidayName.EditValue = gvHoliday.GetFocusedRowCellValue("HolidayName");
                    cmbHolidayType.EditValue = gvHoliday.GetFocusedRowCellValue("CategoryID");
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEHoliday.HoliDayDate = dtHolidayDate.EditValue;
                objEHoliday.HoliDayName = txtHolidayName.EditValue;
                objEHoliday.CategoryID = cmbHolidayType.EditValue;
                objEHoliday.UserID = Utility.UserID;
                objDHoliday.SaveHoliday(objEHoliday);
                gcHoliday.DataSource = objEHoliday.dtHoliday;
                Utility.Setfocus(gvHoliday, "HolidayID", Convert.ToInt32(objEHoliday.HoliDayID));
                ClearFields();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void frmHolidayMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDHoliday.GetHolidayType(objEHoliday);
                cmbHolidayType.Properties.DataSource = objEHoliday.dtHolidayType;
                cmbHolidayType.Properties.DisplayMember = "LookupValue";
                cmbHolidayType.Properties.ValueMember = "LookupID";

                objDHoliday.GetHoliday(objEHoliday);
                gcHoliday.DataSource = objEHoliday.dtHoliday;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void ClearFields()
        {
            dtHolidayDate.Focus();
            dtHolidayDate.EditValue = null;
            txtHolidayName.EditValue = null;
            cmbHolidayType.EditValue = null;
            objEHoliday.HoliDayID = -1;
            
        }
    }
}