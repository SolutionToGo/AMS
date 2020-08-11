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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace AMS
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = null;
        DUser ObjDUser = new DUser();
        public frmUser(EUser _ObjEUser)
        {
            InitializeComponent();
            ObjEUser = _ObjEUser;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDUser.GetUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
                ObjDUser.GetRolesandDesignations(ObjEUser);

                cmbRole.Properties.DataSource = ObjEUser. dtRoles;
                cmbRole.Properties.DisplayMember = "RoleName";
                cmbRole.Properties.ValueMember = "RoleID";

                cmbDesignation.Properties.DataSource = ObjEUser.dtDesignations;
                cmbDesignation.Properties.DisplayMember = "DesignationName";
                cmbDesignation.Properties.ValueMember = "DesignationID";

                cmbReportingLead.Properties.DataSource = ObjEUser.dtUser;
                cmbReportingLead.Properties.DisplayMember = "FullName";
                cmbReportingLead.Properties.ValueMember = "UserInfoID";
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserNameTextEdit.Text = UserNameTextEdit.Text.Trim();
                FullNameTextEdit.Text = FullNameTextEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                EMailTextEdit.Text = EMailTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEUser.UserName = UserNameTextEdit.Text.ToLower();
                ObjEUser.Password = Utility.Encrypt("Password@1234");
                ObjEUser.FullName = FullNameTextEdit.Text;
                ObjEUser.CNumber = CNumberTextEdit.Text;
                ObjEUser.Email = EMailTextEdit.Text;
                ObjEUser.UserID = Utility.UserID;
                ObjEUser.RoleID = cmbRole.EditValue;
                ObjEUser.DesignationID = cmbDesignation.EditValue;
                ObjEUser.ReportingLeadID = cmbReportingLead.EditValue;
                ObjDUser.SaveUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;

                cmbReportingLead.Properties.DataSource = ObjEUser.dtUser;
                cmbReportingLead.Properties.DisplayMember = "FullName";
                cmbReportingLead.Properties.ValueMember = "UserInfoID";

                Utility.Setfocus(gvUser, "UserInfoID", ObjEUser.UserInfoID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEUser.UserInfoID = -1;
            UserNameTextEdit.Text = string.Empty;
            FullNameTextEdit.Text = string.Empty;
            CNumberTextEdit.Text = string.Empty;
            EMailTextEdit.Text = string.Empty;
            cmbDesignation.EditValue = null;
            cmbRole.EditValue = null;
            cmbReportingLead.EditValue = null;
            UserNameTextEdit.ReadOnly = false;
            UserNameTextEdit.Focus();
        }

        private void gvUser_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvUser.GetFocusedRowCellValue("UserInfoID") != null
                        && int.TryParse(Convert.ToString(gvUser.GetFocusedRowCellValue("UserInfoID")), out IValue))
                    {
                        ObjEUser.UserInfoID = IValue;
                        UserNameTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("UserName"));
                        FullNameTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("FullName"));
                        CNumberTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("CNumber"));
                        EMailTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("EMail"));
                        cmbRole.EditValue = gvUser.GetFocusedRowCellValue("RoleID");
                        cmbDesignation.EditValue = gvUser.GetFocusedRowCellValue("DesignationID");
                        cmbReportingLead.EditValue = gvUser.GetFocusedRowCellValue("ReportingLeadID");
                        UserNameTextEdit.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}