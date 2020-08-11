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
using DevExpress.XtraGrid;
using DevExpress.Data;

namespace AMS
{
    public partial class frmTaskEntry : DevExpress.XtraEditors.XtraForm
    {
        ETimeSheet objETimeSheet = null;
        DTimeSheet objDTimeSheet = new DTimeSheet();
        public frmTaskEntry(ETimeSheet _objETimeSheet)
        {
            objETimeSheet = _objETimeSheet;
            InitializeComponent();
        }

        private void frmTaskEntry_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetTaskMaster(objETimeSheet);

                cmbTask.Properties.DataSource = objETimeSheet.dtTask;
                cmbTask.Properties.ValueMember = "TaskID";
                cmbTask.Properties.DisplayMember = "TaskDescription";


                cmbSubTask.Properties.DataSource = objETimeSheet.dtSubTask;
                cmbSubTask.Properties.ValueMember = "SubTaskID";
                cmbSubTask.Properties.DisplayMember = "SubTaskDescription";
                cmbSubTask.CascadingOwner = cmbTask;
                cmbSubTask.Properties.CascadingMember = "TaskID";

                cmbWorkType.Properties.DataSource = objETimeSheet.dtWorkType;
                cmbWorkType.Properties.ValueMember = "WorkTypeID";
                cmbWorkType.Properties.DisplayMember = "WorkTypedescription";
                cmbWorkType.CascadingOwner = cmbSubTask;
                cmbWorkType.Properties.CascadingMember = "SubTaskID";

                objETimeSheet.dtEmployeeTask = new DataTable();
                objETimeSheet.dtEmployeeTask.Columns.Add("TaskID", typeof(int));
                objETimeSheet.dtEmployeeTask.Columns.Add("SubTaskID", typeof(int));
                objETimeSheet.dtEmployeeTask.Columns.Add("WorkTypeID", typeof(int));
                objETimeSheet.dtEmployeeTask.Columns.Add("Hours", typeof(int));
                objETimeSheet.dtEmployeeTask.Columns.Add("EmployeeTaskDescription", typeof(string));
                objETimeSheet.dtEmployeeTask.Columns.Add("TaskDescription", typeof(string));
                objETimeSheet.dtEmployeeTask.Columns.Add("SubTaskDescription", typeof(string));
                objETimeSheet.dtEmployeeTask.Columns.Add("WorkTypedescription", typeof(string));
                objETimeSheet.dtEmployeeTask.Columns.Add("stHours", typeof(string));
                gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
                objDTimeSheet.GetTodayHours(objETimeSheet);
                string stHours = Convert.ToString(objETimeSheet.TodayHours / 60).PadLeft(2, '0');
                string stMins = Convert.ToString(objETimeSheet.TodayHours % 60).PadLeft(2, '0');
                txtTotalHours.EditValue = stHours + ":" + stMins;
                txtRemainingHours.EditValue = stHours + ":" + stMins;
                txtTaskHours.EditValue = "00:00";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbTask_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSubTask.EditValue = null;
                cmbWorkType.EditValue = null;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;

                DataRow drnew = objETimeSheet.dtEmployeeTask.NewRow();
                drnew["TaskID"] = cmbTask.EditValue;
                drnew["SubTaskID"] = cmbSubTask.EditValue;
                drnew["WorkTypeID"] = cmbWorkType.EditValue;
                drnew["TaskDescription"] = cmbTask.Text;
                drnew["SubTaskDescription"] = cmbSubTask.Text;
                drnew["WorkTypedescription"] = cmbWorkType.Text;
                drnew["EmployeeTaskDescription"] = txtTaskDescription.Text;
                drnew["stHours"] = txtTaskHours.Text;

                string []stMinutes = txtTaskHours.Text.Split(':');

                int Ivalue = 0;
                int TMinutes = 0;
                if (int.TryParse(stMinutes[0], out Ivalue))
                {
                    TMinutes = Ivalue * 60;
                    if (int.TryParse(stMinutes[1], out Ivalue))
                        TMinutes += Ivalue;
                }
                if (TMinutes <= 0)
                    return;
                drnew["Hours"] = TMinutes;
                objETimeSheet.dtEmployeeTask.Rows.Add(drnew);
                gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
                cmbTask.EditValue = null;
                txtTaskDescription.Text = string.Empty;
                txtTaskHours.EditValue = "00:00";
                cmbTask.Focus();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTaskManagement.FocusedRowHandle >= 0)
                    gvTaskManagement.DeleteRow(gvTaskManagement.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        int IValue = 0;
        private void gvTaskManagement_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                // Initialization. 
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    IValue = 0;
                }
                // Calculation.
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                    int TMinutes = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Hours"));
                    IValue += TMinutes;
                }
                // Finalization. 
                if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                {
                    string stHours = Convert.ToString(IValue / 60).PadLeft(2,'0');
                    string stMins = Convert.ToString(IValue % 60).PadLeft(2, '0');
                    e.TotalValue = stHours + ":" + stMins;

                    string stHours1 = Convert.ToString((objETimeSheet.TodayHours - IValue) / 60).PadLeft(2, '0');
                    string stMins1 = Convert.ToString((objETimeSheet.TodayHours - IValue) % 60).PadLeft(2, '0');
                    txtRemainingHours.EditValue = stHours1 + ":" + stMins1;

                }
            }
            catch (Exception  ex){ Utility.ShowError(ex); }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (objETimeSheet.TodayHours != IValue)
                    throw new Exception("Total hours not matching with logged hours");
                objETimeSheet._IsSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvTaskManagement_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if(e.Column.FieldName == "stHours")
                {
                    string st = Convert.ToString(e.Value);
                    if(!string.IsNullOrEmpty(st))
                    {
                        int IHrs = 0,IMins = 0;
                        int TOtalMins = 0;
                        string[] stvalues = st.Split(':');
                        if(int.TryParse(stvalues[0],out IHrs) && int.TryParse(stvalues[1], out IMins))
                        {
                            int OldMins = 0;
                            if (int.TryParse(Convert.ToString(objETimeSheet.dtEmployeeTask.Rows[e.RowHandle]["Hours"]), out OldMins))
                            {
                                TOtalMins = IHrs * 60;
                                TOtalMins += IMins;
                                objETimeSheet.dtEmployeeTask.Rows[e.RowHandle]["Hours"] = TOtalMins;

                                int newMins = (IValue - OldMins) + TOtalMins;
                                string stHours1 = Convert.ToString((objETimeSheet.TodayHours - newMins) / 60).PadLeft(2, '0');
                                string stMins1 = Convert.ToString((objETimeSheet.TodayHours - newMins) % 60).PadLeft(2, '0');
                                txtRemainingHours.EditValue = stHours1 + ":" + stMins1;
                                IValue = newMins;
                            }
                        }
                    }
                }
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }
    }
}