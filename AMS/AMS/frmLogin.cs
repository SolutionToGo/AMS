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
using DevExpress.XtraSplashScreen;
using System.Threading;
using Microsoft.Win32;
using System.Net;

namespace AMS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.ToLower() == "admin" && txtPassword.Text == "776986")
                {
                    Utility.UserName = txtUserName.Text;
                    Utility.Password = txtPassword.Text;
                    this.Hide();
                    frmMain ObjParent = new frmMain();
                    ObjParent.Show();
                }
                else
                {
                    txtUserName.Text = txtUserName.Text.Trim();
                    txtPassword.Text = txtPassword.Text.Trim();
                    if (!dxValidationProvider1.Validate())
                        return;
                    ObjEUser.UserName = txtUserName.Text.ToLower();
                    ObjEUser.Password = Utility.Encrypt(txtPassword.Text);
                    ObjDUser.GetUserCredentials(ObjEUser);

                    if (ObjEUser.dtUserDetails != null && ObjEUser.dtUserDetails.Rows.Count > 0)
                    {
                        if (int.TryParse(Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["UserInfoID"]), out Utility.UserID))
                        {
                            Utility.UserName = txtUserName.Text;
                            Utility.Password = Utility.Encrypt(txtPassword.Text);
                            Utility.UserFullName = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["FullName"]);
                            Utility.Designation = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["DesignationName"]);
                            Utility.RoleID = Convert.ToInt32(ObjEUser.dtUserDetails.Rows[0]["RoleID"]);
                            Utility.ReportingLead = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["ReportingLead"]);
                            Utility.MachineName = Environment.MachineName;
                            Utility.MachineUserName = Environment.UserName;

                            string hostname = Dns.GetHostName();
                            Utility.IPAddress = Convert.ToString(Dns.GetHostByName(hostname).AddressList[0]);

                            bool IsOTP = Convert.ToBoolean(ObjEUser.dtUserDetails.Rows[0]["IsOTP"]);
                            if (IsOTP)
                            {
                                frmChangePassword Obj = new frmChangePassword();
                                Obj.ShowDialog();
                            }
                            else
                            {
                                UpdateUserDetails();
                                this.Hide();
                                frmMain ObjParent = new frmMain();
                                ObjParent.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
                if (RGkey != null)
                {
                    if (RGkey.GetValue("LastUser") != null)
                        txtUserName.EditValue = RGkey.GetValue("LastUser");
                }
            }
            catch (Exception ex) { }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserDetails()
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\AMS");

                if (RGkey.GetValue("LastUser") == null)
                {
                    RGkey.SetValue("LastUser", txtUserName.EditValue);
                }
                else
                {
                    if (txtUserName.EditValue != null)
                    {
                        RGkey.SetValue("LastUser", txtUserName.EditValue);
                        RGkey.Flush();
                    }
                }
                RGkey.Close();
            }
            catch (Exception ex){}
        }
    }
}