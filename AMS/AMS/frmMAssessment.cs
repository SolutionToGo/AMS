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
    public partial class frmMAssessment : DevExpress.XtraEditors.XtraForm
    {
        EProject ObjEProject = null;
        DProject ObjDProject = new DProject();
        public frmMAssessment()
        {
            InitializeComponent();
        } 

        private void frmMAssessment_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjDProject.GetAssessmentYearforMS(ObjEProject);
                cmbAssessmentYear.Properties.DataSource = ObjEProject.dtAssessmentYear;
                cmbAssessmentYear.Properties.DisplayMember = "AssessmentYearName";
                cmbAssessmentYear.Properties.ValueMember = "AssessmentYearID";
                cmbAssessmentYear.EditValue = 1;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbAssessmentYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;

                ObjDProject.GetEmployeeforProjectRatings(ObjEProject);
                cmbEmployeeName.Properties.DataSource = ObjEProject.dtEmployeeforPR;
                cmbEmployeeName.Properties.DisplayMember = "FullName";
                cmbEmployeeName.Properties.ValueMember = "UserInfoID";

                ObjDProject.GetEmployeeforGR(ObjEProject);
                cmbEmployeeNameGS.Properties.DataSource = ObjEProject.dtEmployeeforGR;
                cmbEmployeeNameGS.Properties.DisplayMember = "FullName";
                cmbEmployeeNameGS.Properties.ValueMember = "UserInfoID";

                ObjDProject.GetEmployeeforProjectRatings(ObjEProject);
                cmbEmployeeNameTS.Properties.DataSource = ObjEProject.dtEmployeeforPR;
                cmbEmployeeNameTS.Properties.DisplayMember = "FullName";
                cmbEmployeeNameTS.Properties.ValueMember = "UserInfoID";

                ObjDProject.GetEmployeeforLR(ObjEProject);
                cmbEmployeeNameLS.Properties.DataSource = ObjEProject. dtEmployeeforLR;
                cmbEmployeeNameLS.Properties.DisplayMember = "FullName";
                cmbEmployeeNameLS.Properties.ValueMember = "UserInfoID";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployeeName.EditValue == null)
                    return;
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.EmployeeID = cmbEmployeeName.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjDProject.GetUserProjectForMS(ObjEProject);
                gcProjectRatings.DataSource = ObjEProject.dtUserProjects;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbEmployeeNameGS_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ObjEProject.AssessMentYearID =  cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameGS.EditValue;
                ObjDProject.GetGeneralRatings(ObjEProject);
                if (ObjEProject.dtGeneralRatings != null && 
                    ObjEProject.dtGeneralRatings.Rows.Count > 0 && 
                    ObjEProject.dtGeneralRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtGeneralRatings = Utility.ChangeColumnDataType(ObjEProject.dtGeneralRatings);
                }
                gcGeneralRatings.DataSource = ObjEProject.dtGeneralRatings;
                gvGeneralRatings.Columns["SA"].Caption = "MA (1-10)";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbEmployeeNameTS_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameTS.EditValue;
                ObjDProject.GetTechnicalRatings(ObjEProject);
                if (ObjEProject.dtTechnicalRatings != null &&
                    ObjEProject.dtTechnicalRatings.Rows.Count > 0 &&
                    ObjEProject.dtTechnicalRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtTechnicalRatings = Utility.ChangeColumnDataType(ObjEProject.dtTechnicalRatings);
                }
                gcTechnicalRatings.DataSource = ObjEProject.dtTechnicalRatings;
                gvTechnicalRatings.Columns["SA"].Caption = "MA (1-10)";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbEmployeeNameLS_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameLS.EditValue;
                ObjDProject.GetLeadRatings(ObjEProject);
                if (ObjEProject.dtLeadershipRatings != null &&
                    ObjEProject.dtLeadershipRatings.Rows.Count > 0 &&
                    ObjEProject.dtLeadershipRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtLeadershipRatings = Utility.ChangeColumnDataType(ObjEProject.dtLeadershipRatings);
                }
                gcLeadRatings.DataSource = ObjEProject.dtLeadershipRatings;
                gvLeadRatings.Columns["SA"].Caption = "MA (1-10)";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSaveGeneralRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();

                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameGS.EditValue;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEProject.dtGeneralRatings.Copy();
                foreach (DataColumn dc in ObjEProject.dtGeneralRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEProject.dtGeneralRatingsUpdated = dtTemp;
                ObjDProject.SaveGeneralRatings(ObjEProject);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnTechnicalRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameTS.EditValue;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEProject.dtTechnicalRatings.Copy();
                foreach (DataColumn dc in ObjEProject.dtTechnicalRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEProject.dtTechnicalRatingsUpdated = dtTemp;
                ObjDProject.SaveTechnicalRatings(ObjEProject);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSaveLeadRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = cmbEmployeeNameLS.EditValue;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEProject.dtLeadershipRatings.Copy();
                foreach (DataColumn dc in ObjEProject.dtLeadershipRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEProject.dtLeadershipRatingsUpdated = dtTemp;
                ObjDProject.SaveLeadRatings(ObjEProject);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvProject.GetFocusedRowCellValue("ProjectUserMapID")), out IValue))
                {
                    frmAddProject Obj = new frmAddProject(cmbAssessmentYear.EditValue, IValue);
                    Obj.ShowDialog();
                    int Ivalue = 0;
                    if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
                    {
                        cmbAssessmentYear_EditValueChanged(null, null);
                        Utility.Setfocus(gvProject, "ProjectUserMapID", Ivalue);
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