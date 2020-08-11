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
    public partial class frmViewProject : DevExpress.XtraEditors.XtraForm
    {
        int ProjectUserMapID = -1;
        object AssessmentYearID = null;
        EProject ObjEProject = null;
        DProject ObjDProject = new DProject();
        public object NewProjectUserMapID = 0;
        public bool IsSave = false;
        public int EmployeeID = -1;
        public frmViewProject(object _AssessmentYearID, int _ProjectUserMapID = -1)
        {
            InitializeComponent();
            ProjectUserMapID = _ProjectUserMapID;
            AssessmentYearID = _AssessmentYearID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewProject_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjDProject.GetProjectRatingsMaster(ObjEProject);
                cmbProjectName.Properties.DataSource = ObjEProject.dtProjects;
                cmbProjectName.Properties.DisplayMember = "ProjectName";
                cmbProjectName.Properties.ValueMember = "ProjectID";

                cmbProjectLead.Properties.DataSource = ObjEProject.dtLeads;
                cmbProjectLead.Properties.DisplayMember = "FullName";
                cmbProjectLead.Properties.ValueMember = "UserInfoID";

                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.ProjectUserMapID = ProjectUserMapID;
                ObjEProject.EmployeeID = EmployeeID;
                ObjDProject.GetUserProjectDetailsForDS(ObjEProject);
                gcRatings.DataSource = ObjEProject.dtCriteria;
                gvRatings.Columns["CriteriaID"].Visible = false;
                gvRatings.Columns["CriteriaName"].ColumnEdit = txtDescription;
                gvRatings.Columns["Description"].ColumnEdit = txtDescription;
                gvRatings.OptionsBehavior.Editable = false;
                gvRatings.BestFitColumns();
                cmbProjectName.Enabled = false;
                cmbProjectLead.Enabled = false;
                cmbProjectName.EditValue = ObjEProject.ProjectID;
                cmbProjectLead.EditValue = ObjEProject.LeadID;
                txtSelfComments.EditValue = ObjEProject. SelfComments;
                txtManagementComments.EditValue = ObjEProject.ManagementComments;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}