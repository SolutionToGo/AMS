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
using DevExpress.XtraReports.UI;
using AMS.Reports;
using DevExpress.XtraPrinting;

namespace AMS
{
    public partial class frmAssessment : DevExpress.XtraEditors.XtraForm
    {
        EProject ObjEProject = null;
        DProject ObjDProject = new DProject();
        public frmAssessment()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (cmbAssessmentYear.EditValue == null)
                return;
            frmAddProject Obj = new frmAddProject(cmbAssessmentYear.EditValue);
            Obj.EmployeeID = Utility.UserID;
            Obj.ShowDialog();
            int Ivalue = 0;
            if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
            {
                cmbAssessmentYear_EditValueChanged(null, null);
                Utility.Setfocus(gvProject, "ProjectUserMapID", Ivalue);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEProject == null)
                    ObjEProject = new EProject();
                ObjDProject.GetProjectRatingsMaster(ObjEProject);
                cmbAssessmentYear.Properties.DataSource = ObjEProject.dtAssessmentYear;
                cmbAssessmentYear.Properties.DisplayMember = "AssessmentYearName";
                cmbAssessmentYear.Properties.ValueMember = "AssessmentYearID";
                if (Utility.RoleID == 3)
                    tbLeaderSkillsAssessment.PageVisible = true;
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
                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjDProject.GetUserProject(ObjEProject);
                gcProjectRatings.DataSource = ObjEProject.dtUserProjects;
                ObjEProject.EmployeeID = Utility.UserID;
                ObjDProject.GetGeneralRatings(ObjEProject);
                if (ObjEProject.dtGeneralRatings != null &&
                    ObjEProject.dtGeneralRatings.Rows.Count > 0 &&
                    ObjEProject.dtGeneralRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtGeneralRatings = Utility.ChangeColumnDataType(ObjEProject.dtGeneralRatings);
                }
                gcGeneralRatings.DataSource = ObjEProject.dtGeneralRatings;
                gvGeneralRatings.BestFitColumns();
                ObjDProject.GetTechnicalRatings(ObjEProject);
                if (ObjEProject.dtTechnicalRatings != null &&
                    ObjEProject.dtTechnicalRatings.Rows.Count > 0 && 
                    ObjEProject.dtTechnicalRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtTechnicalRatings = Utility.ChangeColumnDataType(ObjEProject.dtTechnicalRatings);
                }
                gcTechnicalRatings.DataSource = ObjEProject.dtTechnicalRatings;
                gvTechnicalRatings.BestFitColumns();

                ObjDProject.GetLeadRatings(ObjEProject);
                if (ObjEProject.dtLeadershipRatings != null &&
                    ObjEProject.dtLeadershipRatings.Rows.Count > 0 &&
                    ObjEProject.dtLeadershipRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEProject.dtLeadershipRatings = Utility.ChangeColumnDataType(ObjEProject.dtLeadershipRatings);
                }
                gcLeadRatings.DataSource = ObjEProject.dtLeadershipRatings;
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
                    Obj.EmployeeID = Utility.UserID;
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

        private void btnSaveGeneralRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (ObjEProject == null)
                    ObjEProject = new EProject();

                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = Utility.UserID;
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

        private void btnSaveTechnicalRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (ObjEProject == null)
                    ObjEProject = new EProject();

                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = Utility.UserID;
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

        private void btnSaveLeadershipRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (ObjEProject == null)
                    ObjEProject = new EProject();

                ObjEProject.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEProject.UserInfoID = Utility.UserID;
                ObjEProject.EmployeeID = Utility.UserID;
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

        public void ViewReport()
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;

                EReports ObjEReports = new EReports();
                DReports ObjDReports = new DReports();

                ObjEReports.AssessmentyYearID = cmbAssessmentYear.EditValue;
                ObjEReports.EmployeeID = Utility.UserID;
                ObjDReports.GetSelfAssessment(ObjEReports);
                rptSTechnicalAssessment rptST = new rptSTechnicalAssessment();
                rptST.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                rptST.Parameters["EmployeeID"].Value = Utility.UserID;
                rptST.Parameters["UserName"].Value = Utility.UserName;
                rptST.Parameters["FullName"].Value = Utility.UserFullName;
                rptST.Parameters["Designation"].Value = Utility.Designation;
                rptST.Parameters["ReportingLead"].Value = Utility.ReportingLead;
                rptST.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                if (ObjEReports.dsAssessment.Tables.Count > 0)
                    rptST.DataSource = ObjEReports.dsAssessment.Tables[0];
                rptST.CreateDocument();

                if (ObjEReports.dsAssessment.Tables[1].Rows.Count > 0)
                {
                    rptSProjectAssessment rptSP = new rptSProjectAssessment();
                    rptSP.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptSP.Parameters["EmployeeID"].Value = Utility.UserID;
                    if (ObjEReports.dsAssessment.Tables.Count > 1)
                        rptSP.DataSource = ObjEReports.dsAssessment.Tables[1];
                    rptSP.CreateDocument();
                    rptST.Pages.AddRange(rptSP.Pages);
                }

                rptSGeneralAssessment rptSG = new rptSGeneralAssessment();
                rptSG.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                rptSG.Parameters["EmployeeID"].Value = Utility.UserID;
                if (ObjEReports.dsAssessment.Tables.Count > 2)
                    rptSG.DataSource = ObjEReports.dsAssessment.Tables[2];
                rptSG.CreateDocument();
                rptST.Pages.AddRange(rptSG.Pages);

                if (Utility.RoleID == 3)
                {
                    rptSLeadershipAssessment rptSL = new rptSLeadershipAssessment();
                    rptSL.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptSL.Parameters["EmployeeID"].Value = Utility.UserID;
                    if (ObjEReports.dsAssessment.Tables.Count > 3)
                        rptSL.DataSource = ObjEReports.dsAssessment.Tables[3];
                    rptSL.CreateDocument();
                    rptST.Pages.AddRange(rptSL.Pages);
                }

                rptST.PrintingSystem.ContinuousPageNumbering = true;

                DialogResult result = xtraFolderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string FolderPath = xtraFolderBrowserDialog1.SelectedPath;
                    string FileName = FolderPath + "\\SA_" + Utility.UserFullName.Replace(" ", "") + "_" + cmbAssessmentYear.Text + ".pdf";
                    rptST.ExportToPdf(FileName);
                    System.Diagnostics.Process.Start(FileName);
                }
                //rptST.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

    }
}