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
    public partial class frmAddProject : DevExpress.XtraEditors.XtraForm
    {
        int ProjectUserMapID = -1;
        object AssessmentYearID = null;
        EProject ObjEProject = null;
        DProject ObjDProject = new DProject();
        public object NewProjectUserMapID = 0;
        public bool IsSave = false;
        public int EmployeeID = -1;
        public frmAddProject(object _AssessmentYearID, int _ProjectUserMapID = -1)
        {
            InitializeComponent();
            ProjectUserMapID = _ProjectUserMapID;
            AssessmentYearID = _AssessmentYearID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProjectName.EditValue == null)
                    return;

                if (cmbProjectLead.EditValue == null)
                    return;

                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.ProjectUserMapID = ProjectUserMapID;
                ObjEProject.ProjectID = cmbProjectName.EditValue;
                ObjEProject.AssessMentYearID = AssessmentYearID;
                ObjEProject.ProjectUserMapID = ProjectUserMapID;
                ObjEProject.SelfComments = string.Empty;
                ObjEProject.ManagementComments = string.Empty;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.LeadID = cmbProjectLead.EditValue;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEProject.dtCriteria.Copy();
                foreach(DataColumn dc in ObjEProject.dtCriteria.Columns)
                {
                    if (dc.ColumnName == "Description" || dc.ColumnName == "CriteriaName")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEProject.dtProjectRatings = dtTemp;
                ObjDProject.SaveUserProject(ObjEProject);
                NewProjectUserMapID = ObjEProject.ProjectUserMapID;
                IsSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            if (ProjectUserMapID <= 0)
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

                ObjEProject.dtCriteria.Columns.Add("SA", typeof(decimal));
                ObjEProject.dtCriteria.Columns.Add("Comments", typeof(string));
                gcRatings.DataSource = ObjEProject.dtCriteria;
                gvRatings.Columns["CriteriaID"].Visible = false;
                gvRatings.Columns["SA"]. Caption = "SA (1-10)";
                gvRatings.Columns["Comments"].Caption = "Self Comments";
            } 
            else
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
                ObjDProject.GetUserProjectDetails(ObjEProject);
                
                if (ObjEProject.dtCriteria != null &&
                    ObjEProject.dtCriteria.Rows.Count > 0 &&
                    ObjEProject.dtCriteria.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtCriteria = Utility.ChangeColumnDataType(ObjEProject.dtCriteria);
                }
                gcRatings.DataSource = ObjEProject.dtCriteria;
                gvRatings.Columns["CriteriaID"].Visible = false;

                if (EmployeeID != Utility.UserID)
                {
                    cmbProjectName.Enabled = false;
                    cmbProjectLead.Enabled = false;
                    gvRatings.Columns["SA"].Caption = "MA (1-10)";
                }
                else
                {
                    gvRatings.Columns["SA"].Caption = "SA (1-10)";
                }
                cmbProjectName.EditValue = ObjEProject.ProjectID;
                cmbProjectLead.EditValue = ObjEProject.LeadID;
                this.Text = "View Project";
            }
        }
    }
}