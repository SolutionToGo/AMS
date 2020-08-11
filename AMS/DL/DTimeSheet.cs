using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DTimeSheet
    {
        public ETimeSheet GetTaskMaster(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TaskMaster]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        objETimesheet.dtTask = ds.Tables[0];
                        if (ds.Tables.Count > 1)
                        {
                            objETimesheet.dtSubTask = ds.Tables[1];
                            if (ds.Tables.Count > 2)
                            {
                                objETimesheet.dtWorkType = ds.Tables[2];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Task Master");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetEmployeeTask(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeTask]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtEmployeeTask = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee Task ");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet SaveEmployeeTask(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_EmployeeTask]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@TaskID", objETimesheet.TaskID);
                    cmd.Parameters.Add("@SubTaskID", objETimesheet.SubTaskID);
                    cmd.Parameters.Add("@WorkTypeID", objETimesheet.WorkTypeID);
                    cmd.Parameters.Add("@TaskDescription", objETimesheet.TaskDescription);
                    cmd.Parameters.Add("@Minutes", objETimesheet.TaskMinutes);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string EmployeeTaskID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(EmployeeTaskID, out IValue))
                        {
                            objETimesheet.EmployeeTaskID = IValue;
                            if (ds.Tables.Count > 1)
                            {
                                objETimesheet.dtEmployeeTask = ds.Tables[1];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Employee Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet DeleteEmployeeTask(ETimeSheet objETimesheet)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Del_EmployeeTask]";
                    cmd.Parameters.Add("@EmployeeTaskID", objETimesheet.EmployeeTaskID);
                    object objReturn = cmd.ExecuteScalar();
                    string EmployeeTaskID = Convert.ToString(objReturn);
                    int IValue = 0;
                    if (int.TryParse(EmployeeTaskID, out IValue))
                    {
                        objETimesheet.EmployeeTaskID = IValue;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Deleting Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetEmployeeTaskforLead(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeTaks]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtEmployeeTask = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee Task ");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertDayLogin(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_DayLogin]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string TimeSheetID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(TimeSheetID, out IValue))
                            objETimesheet.TimesheetID = IValue;
                        else
                            throw new Exception(TimeSheetID);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating Login Time");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertDayLogout(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_DayLogOut]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@dtEmployeeTask", objETimesheet.dtEmployeeTask);
                    cmd.Parameters.Add("@Logouttime", objETimesheet.DayLogoutTime);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string TimeSheetID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(TimeSheetID, out IValue))
                            objETimesheet.TimesheetID = IValue;
                        else
                            throw new Exception(TimeSheetID);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating Logout Time");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertLunchLogin(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_LunchLogin]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string TimeSheetID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(TimeSheetID, out IValue))
                            objETimesheet.TimesheetID = IValue;
                        else
                            throw new Exception(TimeSheetID);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating Lunch Login Time");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertLunchLogout(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_LunchLogout]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string TimeSheetID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(TimeSheetID, out IValue))
                            objETimesheet.TimesheetID = IValue;
                        else
                            throw new Exception(TimeSheetID);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertBreakLogin(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_BreakLogin]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string DayBreakID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(DayBreakID, out IValue))
                        {
                            objETimesheet.DayBreakID = IValue;
                            string TimeSheetID = Convert.ToString(ds.Tables[1].Rows[0][0]);
                            int IValue1 = 0;
                            if (int.TryParse(TimeSheetID, out IValue1))
                            {
                                objETimesheet.dsTimeSheet = new DataSet();
                                objETimesheet.TimesheetID = IValue1;
                                objETimesheet.dtDayBreaks = ds.Tables[2];
                            }
                        }
                        else
                            throw new Exception(DayBreakID);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating Break Login Time");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet InsertBreakLogout(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_BreakLogout]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        string DayBreakID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        int IValue = 0;
                        if (int.TryParse(DayBreakID, out IValue))
                        {
                            objETimesheet.DayBreakID = IValue;
                            string TimeSheetID = Convert.ToString(ds.Tables[1].Rows[0][0]);
                            int IValue1 = 0;
                            if (int.TryParse(TimeSheetID, out IValue1))
                            {
                                objETimesheet.dsTimeSheet = new DataSet();
                                objETimesheet.TimesheetID = IValue1;
                                objETimesheet.dtDayBreaks = ds.Tables[2];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating Break logout Time");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetLoginState(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LoginState]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        objETimesheet.LoginState = Convert.ToString(dt.Rows[0][0]).Trim();
                        objETimesheet.LunchState = Convert.ToString(dt.Rows[0][1]).Trim();
                        objETimesheet.DayState = Convert.ToString(dt.Rows[0][2]).Trim();
                        objETimesheet.BreakState = Convert.ToString(dt.Rows[0][3]).Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee State ");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTimeSheet(ETimeSheet objETimesheet)
        {
            objETimesheet.dsTimeSheet = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Timesheet]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@SelectedMonth", objETimesheet.SelectedMonth);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objETimesheet.dsTimeSheet);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Timesheet ");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetDayBreak(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_DayBreaks]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtDayBreaks = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving DayBreaks");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTotalHours(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TotalHours]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtTotalHours = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Total Hours");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTotalHours1(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TotalHours1]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@SelectedMonth", objETimesheet.SelectedMonth);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtTotalHours = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Total Hours");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTodayHours(ETimeSheet objETimesheet)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TodayHours]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@LogoutTime", objETimesheet.DayLogoutTime);
                    object obj = cmd.ExecuteScalar();
                    int IValue = 0;
                    if(int.TryParse(Convert.ToString(obj),out IValue))
                        objETimesheet.TodayHours = IValue;
                    else
                        throw new Exception(Convert.ToString(obj));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Today Hours");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetEmployeeList(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeList]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtEmployeeList = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTimesheetDetails(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TimesheetDetails]";
                    cmd.Parameters.Add("@TimesheetID", objETimesheet.TimesheetID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    objETimesheet.dsTimesheetdetails = ds.Copy();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Timesheet Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet UpdateTimesheetDetails(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_TimesheetDetails]";
                    cmd.Parameters.Add("@TimesheetID", objETimesheet.TimesheetID);
                    cmd.Parameters.Add("@Daylogin", objETimesheet.Daylogin);
                    cmd.Parameters.Add("@Daylogout", objETimesheet.DayLogout);
                    cmd.Parameters.Add("@LunchLogin", objETimesheet.LunchLogin);
                    cmd.Parameters.Add("@LunchLogout", objETimesheet.LunchLogout);
                    cmd.Parameters.Add("@dtBreaks", objETimesheet.dtBreaks);
                    string TimesheetID = Convert.ToString(cmd.ExecuteScalar());
                    int IValue = 0;
                    if (int.TryParse(TimesheetID, out IValue))
                        objETimesheet.TimesheetID = IValue;
                    else
                        throw new Exception(TimesheetID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While updating Timesheet Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetDashboard(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Dashboard]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtDashoard = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Dashboard Data");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetTask(ETimeSheet objETimesheet)
        {
            objETimesheet.dtTask = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Task]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objETimesheet.dtTask);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet SaveTask(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            objETimesheet.dtTask = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Task]";
                    cmd.Parameters.Add("@TaskID", objETimesheet.TaskID);
                    cmd.Parameters.Add("@TaskDescription", objETimesheet.TaskDescription);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stTaskID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stTaskID, out ivalue))
                        {
                            objETimesheet.TaskID = ivalue;
                            if (ds.Tables.Count > 1)
                                objETimesheet.dtTask = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetSubTask(ETimeSheet objETimesheet)
        {
            objETimesheet.dtSubTask = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_SubTask]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objETimesheet.dtSubTask);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Sub Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet SaveSubTask(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            objETimesheet.dtSubTask = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_SubTask]";
                    cmd.Parameters.Add("@SubTaskID", objETimesheet.SubTaskID);
                    cmd.Parameters.Add("@SubTaskDecription", objETimesheet.SubTaskDescription);
                    cmd.Parameters.Add("@TaskID", objETimesheet.TaskID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stSubTaskID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stSubTaskID, out ivalue))
                        {
                            objETimesheet.SubTaskID = ivalue;
                            if (ds.Tables.Count > 1)
                                objETimesheet.dtSubTask = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Sub Task");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetWorkType(ETimeSheet objETimesheet)
        {
            objETimesheet.dtWorkType = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_WorkType]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objETimesheet.dtWorkType);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Work Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet SaveWorkType(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            objETimesheet.dtWorkType = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_WorkType]";
                    cmd.Parameters.Add("@WorkTypeID", objETimesheet.SubTaskID);
                    cmd.Parameters.Add("@WorkTypeDecription", objETimesheet.SubTaskDescription);
                    cmd.Parameters.Add("@SubTaskID", objETimesheet.TaskID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stWorkTypeTaskID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stWorkTypeTaskID, out ivalue))
                        {
                            objETimesheet.WorkTypeID = ivalue;
                            if (ds.Tables.Count > 1)
                                objETimesheet.dtWorkType = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Work type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetProjectWorkType(ETimeSheet objETimesheet)
        {
            objETimesheet.dtWorkType = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectWorkType]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objETimesheet.dtWorkType);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Project Work Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet SaveProjectWorkType(ETimeSheet objETimesheet)
        {
            DataSet ds = new DataSet();
            objETimesheet.dtWorkType = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_ProjectWorkType]";
                    cmd.Parameters.Add("@ProjectWorkTypeID", objETimesheet.WorkTypeID);
                    cmd.Parameters.Add("@WorkTypeDescription", objETimesheet.WorkTypeDescription);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stWorkTypeID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stWorkTypeID, out ivalue))
                        {
                            objETimesheet.WorkTypeID = ivalue;
                            if (ds.Tables.Count > 1)
                                objETimesheet.dtWorkType = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Work type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }

        public ETimeSheet GetEmpforReport(ETimeSheet objETimesheet)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UsersforReport]";
                    cmd.Parameters.Add("@EmployeeID", objETimesheet.EmployeeID);
                    cmd.Parameters.Add("@IsActive", objETimesheet.IsActive);
                    cmd.Parameters.Add("@RoleID", objETimesheet.RoleID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objETimesheet.dtEmployeeList = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objETimesheet;
        }
    }
}

