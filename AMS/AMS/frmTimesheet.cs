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
using DevExpress.XtraGrid.Views.Grid;

namespace AMS
{
    public partial class frmTimesheet : DevExpress.XtraEditors.XtraForm
    {
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmTimesheet()
        {
            InitializeComponent();
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            try
            {
                dtpSelectedMonth.DateTime = DateTime.Now;
                objETimeSheet.EmployeeID = Utility.UserID;
                objDTimeSheet.GetLoginState(objETimeSheet);
                if (objETimeSheet.LoginState == "DLI")
                {
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Login Now";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Going For Lunch";
                    btnBreak.Enabled = false;
                    btnBreak.Text = "Going For Break";
                }
                else if (objETimeSheet.LoginState == "DLO")
                {
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = true;
                        btnLunch.Text = "Going For Lunch";
                    }
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                }
                else if (objETimeSheet.LoginState == "LLO")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Back From Lunch";
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Going For Break";
                    }
                }
                else if (objETimeSheet.LoginState == "BLO")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Going on Lunch";
                    }
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Back From Break";
                }
                if (objETimeSheet.DayState == "Y")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Day Completed";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Lunch Break Completed";
                    btnBreak.Enabled = false;
                    btnBreak.Text = "All breaks availed for the day";
                }
                BindTimeSheet();
                objDTimeSheet.GetDayBreak(objETimeSheet);
                gcBreaks.DataSource = objETimeSheet.dtDayBreaks;

                objDTimeSheet.GetTotalHours(objETimeSheet);
                gcTotalHours.DataSource = objETimeSheet.dtTotalHours;
                timer1.Start();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnDayLogin.Text == "Login Now")
                {
                    objDTimeSheet.InsertDayLogin(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Going For Lunch";
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Going For Break";
                    dtpSelectedMonth.DateTime = DateTime.Now;
                    BindTimeSheet();
                }
                else if (btnDayLogin.Text == "Logout Now")
                {
                    timer1.Stop();
                    objETimeSheet.DayLogoutTime = DateTime.Now;
                    frmTaskEntry Obj = new frmTaskEntry(objETimeSheet);
                    Obj.ShowDialog();
                    if (objETimeSheet._IsSave)
                    {
                        DataTable dtTemp = objETimeSheet.dtEmployeeTask.Clone();
                        foreach (DataColumn dc in dtTemp.Columns)
                        {
                            if (dc.ColumnName == "TaskDescription" || dc.ColumnName == "SubTaskDescription" ||
                                dc.ColumnName == "WorkTypedescription" || dc.ColumnName == "stHours")
                                objETimeSheet.dtEmployeeTask.Columns.Remove(dc.ColumnName);
                        }
                        objDTimeSheet.InsertDayLogout(objETimeSheet);
                        btnDayLogin.Enabled = false;
                        btnDayLogin.Text = "Day Completed";
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break Completed";
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Break Completed";
                        dtpSelectedMonth.DateTime = DateTime.Now;
                        BindTimeSheet();
                    }
                    else
                        timer1.Start();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnLunch.Text == "Going For Lunch")
                {
                    objDTimeSheet.InsertLunchLogin(objETimeSheet);
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Back From Lunch";

                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Going on Break";
                    }
                }
                else if (btnLunch.Text == "Back From Lunch")
                {
                    objDTimeSheet.InsertLunchLogout(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Lunch Break Completed";
                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                    objETimeSheet.LunchState = "Y";
                }
                dtpSelectedMonth.DateTime = DateTime.Now;
                BindTimeSheet();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnBreak.Text == "Going For Break")
                {
                    objDTimeSheet.InsertBreakLogin(objETimeSheet);
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Going For Lunch";
                    }
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Back From Break";
                }
                else if (btnBreak.Text == "Back From Break")
                {
                    objDTimeSheet.InsertBreakLogout(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = true;
                        btnLunch.Text = "Going For Lunch";
                    }

                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                }
                dtpSelectedMonth.DateTime = DateTime.Now;
                BindTimeSheet();
                objDTimeSheet.GetDayBreak(objETimeSheet);
                gcBreaks.DataSource = objETimeSheet.dtDayBreaks;
                Utility.Setfocus(gvBreaks, "DayBreakID", Convert.ToInt32(objETimeSheet.DayBreakID));
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void BindTimeSheet()
        {
            try
            {
                objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                objDTimeSheet.GetTimeSheet(objETimeSheet);
                DataColumn keyColumn = objETimeSheet.dsTimeSheet.Tables[0].Columns["ID"];
                DataColumn foreignKeyColumn = objETimeSheet.dsTimeSheet.Tables[1].Columns["ID"];
                objETimeSheet.dsTimeSheet.Relations.Add("drTimeSheetID", keyColumn, foreignKeyColumn);
                gcTimesheet.DataSource = objETimeSheet.dsTimeSheet.Tables[0];
                gcTimesheet.ForceInitialize();
                gvTimesheet.Columns["TimesheetID"].VisibleIndex = -1;
                gvTimesheet.Columns["LogDate"].VisibleIndex = -1;
                gvTimesheet.Columns["ID"].VisibleIndex = -1;
                gvTimesheet.Columns["IsHoliday"].VisibleIndex = -1;
                gvTimesheet.Columns["IsWeekend"].VisibleIndex = -1;
                gvTimesheet.Columns["LogDateDesc"].Caption = "Log Date";
                gvTimesheet.Columns["DayLogin"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["DayLogout"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["LunchLogin"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["LunchLogout"].ColumnEdit = repositoryItemDateEdit2;

                GridView gvEmployeeTask = new GridView(gcTimesheet);
                gcTimesheet.LevelTree.Nodes.Add("drTimeSheetID", gvEmployeeTask);
                gvEmployeeTask.ViewCaption = "Tasks";
                gvEmployeeTask.PopulateColumns(objETimeSheet.dsTimeSheet.Tables[1]);
                gvEmployeeTask.Columns["TimesheetID"].VisibleIndex = -1;
                gvEmployeeTask.Columns["ID"].VisibleIndex = -1;
                gvEmployeeTask.Columns["TaskMins"].VisibleIndex = -1;
                gvEmployeeTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvEmployeeTask.Appearance.HeaderPanel.Options.UseFont = true;
                gvEmployeeTask.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
                gvEmployeeTask.Appearance.Row.Options.UseFont = true;
                gvEmployeeTask.OptionsBehavior.Editable = false;
                gvEmployeeTask.OptionsCustomization.AllowColumnResizing = false;
                gvEmployeeTask.OptionsCustomization.AllowFilter = false;
                gvEmployeeTask.OptionsCustomization.AllowGroup = false;
                gvEmployeeTask.OptionsCustomization.AllowSort = false;
                gvEmployeeTask.OptionsFind.AllowFindPanel = false;
                gvEmployeeTask.OptionsView.ShowGroupPanel = false;
                gvEmployeeTask.OptionsView.ShowIndicator = false;
                gvEmployeeTask.Columns["TaskDescription"].VisibleIndex = 0;
                gvEmployeeTask.Columns["TaskDescription"].Width = 50;
                gvEmployeeTask.Columns["SubTaskDescription"].VisibleIndex = 1;
                gvEmployeeTask.Columns["SubTaskDescription"].Width = 75;
                gvEmployeeTask.Columns["WorkTypedescription"].VisibleIndex = 2;
                gvEmployeeTask.Columns["WorkTypedescription"].Width = 100;
                gvEmployeeTask.Columns["EmployeeTaskDescription"].VisibleIndex = 3;
                gvEmployeeTask.Columns["EmployeeTaskDescription"].Width = 200;
                gvEmployeeTask.Columns["TaskHours"].VisibleIndex = 4;
                gvEmployeeTask.Columns["TaskHours"].Width = 50;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetTotalHours(objETimeSheet);
                gcTotalHours.DataSource = objETimeSheet.dtTotalHours;

            }
            catch (Exception ex)
            {
            }
        }

        private void SelectedMonth_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                BindTimeSheet();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}