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
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtOPassword.Text = txtOPassword.Text.Trim();
                txtNPassword.Text = txtNPassword.Text.Trim();
                txtcPassword.Text = txtcPassword.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                if (Utility.Encrypt(txtOPassword.Text) != Utility.Password)
                    throw new Exception("Invalid Old Password");
                if(txtNPassword.Text != txtcPassword.Text)
                    throw new Exception("Both Passwords Should be same");
                ObjEUser.UserInfoID = Utility.UserID;
                ObjEUser.Password = Utility.Encrypt(txtNPassword.Text);
                ObjDUser.ChangePassword(ObjEUser);
                if (ObjEUser.dtUserDetails != null && ObjEUser.dtUserDetails.Rows.Count > 0)
                {
                    if (int.TryParse(Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["UserInfoID"]), out Utility.UserID))
                    {
                        Utility.Password = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["Passwordstring"]);
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}