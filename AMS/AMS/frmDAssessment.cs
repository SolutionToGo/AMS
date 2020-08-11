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
using DevExpress.XtraEditors.Repository;
using AMS.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;

namespace AMS
{
    public partial class frmDAssessment : DevExpress.XtraEditors.XtraForm
    {
        EProject ObjEProject = null;
        DProject ObjDProject = new DProject();
        public frmDAssessment()
        {
            InitializeComponent();
        }

        private void frmDAssessment_Load(object sender, EventArgs e)
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
                ObjDProject.GetEmployeeforDS(ObjEProject);
                cmbEmployeeName.Properties.DataSource = ObjEProject.dtEmployeeforDS;
                cmbEmployeeName.Properties.DisplayMember = "FullName";
                cmbEmployeeName.Properties.ValueMember = "UserInfoID";
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
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (cmbEmployeeName.EditValue == null)
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject. EmployeeID = cmbEmployeeName.EditValue;

                EUser ObjEUser = new EUser();
                DUser ObjDUser = new DUser();

                ObjEUser.EmployeeID = cmbEmployeeName.EditValue;
                ObjDUser.GetUserDetailsByID(ObjEUser);

                int Ivalue = 0;
                if (int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["RoleID"]), out Ivalue) && Ivalue == 4)
                    tbLeadershipSkillsAssessment.PageVisible = false;
                else
                    tbLeadershipSkillsAssessment.PageVisible = true;

                ObjDProject.GetEmployeeRatingsforDS(ObjEProject);
                gcProjectRatings.DataSource = ObjEProject.dtUserProjectsForDS;
                gvGeneralRatings.Columns.Clear();
                gcGeneralRatings.DataSource = ObjEProject.dtGeneralRatingsForDS;
                if (ObjEProject.dtGeneralRatingsForDS != null)
                {
                    gvGeneralRatings.Columns["GeneralPerformanceID"].Visible = false;
                    gvGeneralRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvGeneralRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvGeneralRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvGeneralRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvGeneralRatings.OptionsBehavior.Editable = false;
                }

                ObjDProject.GetTechnicalRatingsforDS(ObjEProject);
                gvTechnicalRatings.Columns.Clear();
                gcTechnicalRatings.DataSource = ObjEProject.dtTechnicalRatingsForDS;
                if (ObjEProject.dtTechnicalRatingsForDS != null)
                {
                    gvTechnicalRatings.Columns["TechnicalPerformanceID"].Visible = false;
                    gvTechnicalRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvTechnicalRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvTechnicalRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvTechnicalRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvTechnicalRatings.OptionsBehavior.Editable = false;
                }

                ObjDProject.GetLeadRatingsforDS(ObjEProject);
                gvLeadRatings.Columns.Clear();
                gcLeadRatings.DataSource = ObjEProject.dtLeadRatingsForDS;
                if (ObjEProject.dtLeadRatingsForDS != null && ObjEProject.dtLeadRatingsForDS.Rows.Count > 0)
                {
                    gvLeadRatings.Columns["LeadPerformanceID"].Visible = false;
                    gvLeadRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvLeadRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvLeadRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvLeadRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvLeadRatings.OptionsBehavior.Editable = false;
                }

                if (ObjEProject.dtLeadCommentsForDS != null && ObjEProject.dtLeadCommentsForDS.Rows.Count > 0)
                {
                    txtSelfComments.EditValue = ObjEProject.dtLeadCommentsForDS.Rows[0]["SelfComments"];
                    txtManagementComments.EditValue = ObjEProject.dtLeadCommentsForDS.Rows[0]["ManagementComments"];
                }
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
                    frmViewProject Obj = new frmViewProject(cmbAssessmentYear.EditValue, IValue);
                    Obj.EmployeeID = Convert.ToInt32(cmbEmployeeName.EditValue);
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

        public void ViewReport()
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (cmbEmployeeName.EditValue == null)
                    return;
                EUser ObjEUser = new EUser();
                DUser ObjDUser = new DUser();

                ObjEUser.EmployeeID = cmbEmployeeName.EditValue;
                ObjDUser.GetUserDetailsByID(ObjEUser);

                EReports ObjEReports = new EReports();
                DReports ObjDReports = new DReports();
                ObjEReports.AssessmentyYearID = cmbAssessmentYear.EditValue;
                ObjEReports.EmployeeID = cmbEmployeeName.EditValue;
                ObjDReports.GetDAssessment(ObjEReports);

                if (ObjEUser.dtUser != null && ObjEUser.dtUser.Rows.Count > 0)
                {
                    rptDTechnicalAssessment rptDT = new rptDTechnicalAssessment();
                    rptDT.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptDT.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                    rptDT.Parameters["UserName"].Value = ObjEUser.dtUser.Rows[0]["UserName"];
                    rptDT.Parameters["FullName"].Value = ObjEUser.dtUser.Rows[0]["FullName"];
                    rptDT.Parameters["Designation"].Value = ObjEUser.dtUser.Rows[0]["DesignationName"];
                    rptDT.Parameters["ReportingLead"].Value = ObjEUser.dtUser.Rows[0]["ReportingLead"];
                    rptDT.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                    if (ObjEReports.dsAssessment.Tables.Count > 0)
                        rptDT.DataSource = ObjEReports.dsAssessment.Tables[0];
                    rptDT.CreateDocument();

                    if (ObjEReports.dsAssessment.Tables[1].Rows.Count > 0)
                    {
                        rptDProjectAssessment rptDP = new rptDProjectAssessment();
                        rptDP.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptDP.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        if (ObjEReports.dsAssessment.Tables.Count > 1)
                            rptDP.DataSource = ObjEReports.dsAssessment.Tables[1];
                        rptDP.CreateDocument();
                        rptDT.Pages.AddRange(rptDP.Pages);
                    }

                    int Ivalue = 0;
                    if (int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["RoleID"]), out Ivalue) && Ivalue == 3)
                    {
                        rptDLeadAssessment rptDL = new rptDLeadAssessment();
                        rptDL.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptDL.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;

                        if (ObjEReports.dsAssessment.Tables.Count > 3)
                        {
                            rptDL.Parameters["SComments"].Value = ObjEReports.dsAssessment.Tables[3].Rows[0][0];
                            rptDL.Parameters["MComments"].Value = ObjEReports.dsAssessment.Tables[3].Rows[0][1];
                        }
                        if (ObjEReports.dsAssessment.Tables.Count > 2)
                            rptDL.DataSource = ObjEReports.dsAssessment.Tables[2];
                        rptDL.CreateDocument();
                        rptDT.Pages.AddRange(rptDL.Pages);
                    }

                    rptDGeneralAssessment rptDG = new rptDGeneralAssessment();
                    rptDG.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptDG.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                    if (ObjEReports.dsAssessment.Tables.Count > 4)
                        rptDG.DataSource = ObjEReports.dsAssessment.Tables[4];
                    rptDG.CreateDocument();
                    rptDT.Pages.AddRange(rptDG.Pages);

                    if (Ivalue == 3)
                    {
                        rptFinalRatingWithLR rptFR = new rptFinalRatingWithLR();
                        rptFR.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptFR.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        if (ObjEReports.dsAssessment.Tables.Count > 5)
                            rptFR.DataSource = ObjEReports.dsAssessment.Tables[5];
                        rptFR.CreateDocument();
                        rptDT.Pages.AddRange(rptFR.Pages);
                    }
                    else
                    {
                        rptFinalRating rptFR = new rptFinalRating();
                        rptFR.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptFR.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        if (ObjEReports.dsAssessment.Tables.Count > 5)
                            rptFR.DataSource = ObjEReports.dsAssessment.Tables[5];
                        rptFR.CreateDocument();
                        rptDT.Pages.AddRange(rptFR.Pages);
                    }

                    //DialogResult result = xtraFolderBrowserDialog1.ShowDialog();
                    //if (result == DialogResult.OK)
                    //{
                    //    string FolderPath = xtraFolderBrowserDialog1.SelectedPath;
                    //    string FileName = FolderPath + "\\MA_" + cmbEmployeeName.Text.Replace(" ", "") + "_" + cmbAssessmentYear.Text + ".pdf";
                    //    rptDT.ExportToPdf(FileName);
                    //    System.Diagnostics.Process.Start(FileName);
                    //}
                    rptDT.ShowRibbonPreview();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

    }
}