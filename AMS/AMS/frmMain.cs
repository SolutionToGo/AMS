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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowMdiChild(XtraForm Obj)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Obj.Name)
                {
                    form.Activate();
                    return;
                }
            }
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            int frmWidth = Obj.Width;
            int frmHeight = this.ClientRectangle.Height - 160;
            Obj.Size = new Size(frmWidth, frmHeight);
            Obj.Show();
        }

        private void ShowForm(XtraForm Obj)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Obj.Name)
                {
                    form.Close();
                    break;
                }
            }
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                EUser ObjEUser = new EUser();
                frmUser Obj = new frmUser(ObjEUser);
                ShowForm(Obj);
            }
            catch (Exception ex) { }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAssessment Obj = new frmAssessment();
            ShowMdiChild(Obj);
        }

        private void btnMAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMAssessment Obj = new frmMAssessment();
            ShowMdiChild(Obj);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblName.Caption = "Hello, " + Utility.UserFullName;
            lblViewDesignaion.Caption = Utility.Designation;
            lblVersion.Caption = "Version " + Utility.AppVersion;
            if (Utility.RoleID == 1)
            {
                //rgDS.Visible = true;
                //rgMS.Visible = true;
                btnEmployeeTask.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnViewTimesheet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDashBoard.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                rpAdmin.Visible = true;

            }
            else if (Utility.RoleID == 3)
            {
                //rgSA. Visible = true;
                //rgMS.Visible = true;
                btnEmployeeTask.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (Utility.RoleID == 4)
            {
                //rgSA.Visible = true;
            }
            else
            {
                rgUP.Visible = true;
                rgSA.Visible = true;
                rgMS.Visible = true;
                rgDS.Visible = true;
            }

            if(Utility.Designation.Trim() == "HR & Admin Associate")
            {
                btnViewTimesheet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDashBoard.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnEmployeeTask.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                rpAdmin.Visible = true;
            }
        }

        private void btnDAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDAssessment Obj = new frmDAssessment();
            ShowForm(Obj);
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword Obj = new frmChangePassword();
            Obj.ShowDialog();
        }

        private void btnViewAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmAssessment f = (frmAssessment)this.ActiveMdiChild;
                f.ViewReport();
            }
            catch (Exception ex) { }
        }

        private void btnViewDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDAssessment f = (frmDAssessment)this.ActiveMdiChild;
                f.ViewReport();
            }
            catch (Exception ex) { }
        }

        private void btnEmployeeTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployeeTask Obj = new frmEmployeeTask();
            ShowForm(Obj);
        }

        private void btnTimesheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimesheet Obj = new frmTimesheet();
            ShowForm(Obj);
        }

        private void btnHolidayMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHolidayMaster Obj = new frmHolidayMaster();
            ShowMdiChild(Obj);
        }

        private void btnViewTimesheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewTimesheet Obj = new frmViewTimesheet();
            ShowForm(Obj);
        }

        private void btnDashBoard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDashBoard Obj = new frmDashBoard();
            ShowForm(Obj);
        }

        private void btnTaskMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaskMaster Obj = new frmTaskMaster();
            Obj.ShowDialog();
        }

        private void btnSubTaskMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSubTaskMaster Obj = new frmSubTaskMaster();
            Obj.ShowDialog();
        }

        private void btnWorkType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmWorkType Obj = new frmWorkType();
            Obj.ShowDialog();
        }

        private void btnProjectMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectMaster Obj = new frmProjectMaster();
            Obj.ShowDialog();
        }

        private void btnProjectWorkType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectWorkType Obj = new frmProjectWorkType();
            Obj.ShowDialog();
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                pictureEdit1.Visible = false;
            else
                pictureEdit1.Visible = true;
        }
    }
}