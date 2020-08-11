using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ETimeSheet
    {
        public DataTable dtTask { get; set; }
        public DataTable dtSubTask { get; set; }
        public DataTable dtWorkType { get; set; }
        public DataTable dtEmployeeTask { get; set; }
        public DataSet dsTimeSheet { get; set; }
        public DataTable dtDayBreaks { get; set; }
        public DataTable dtTotalHours { get; set; }
        public DataTable dtEmployeeList { get; set; }
        public DataSet dsTimesheetdetails { get; set; }
        public DataTable dtDashoard { get; set; }
        public DataTable dtBreaks { get; set; }
        public DateTime SelectedMonth { get; set; }

        public object RoleID { get; set; }
        public object IsActive { get; set; }
        public object EmployeeID { get; set; }
        public object TaskID { get; set; }
        public object SubTaskID { get; set; }

        public object SubTaskDescription { get; set; }
        public object WorkTypeID { get; set; }
        public object WorkTypeDescription { get; set; }

        public object TaskDescription { get; set; }
        public object TaskMinutes { get; set; }
        public object EmployeeTaskID { get; set; }
        public object LoggedDate { get; set; }
        public object TimesheetID { get; set; }
        public object DayBreakID { get; set; }
        public string LoginState { get; set; }
        public string LunchState { get; set; }
        public string DayState { get; set; }
        public string BreakState { get; set; }
        public bool _IsSave { get; set; }
        public int TodayHours { get; set; }
        public object EmployeeName { get; set; }
        public object Daylogin { get; set; }
        public object DayLogout { get; set; }
        public DateTime DayLogoutTime { get; set; }
        public object LunchLogin { get; set; }
        public object LunchLogout { get; set; }
        public object MachineName { get; set; }
        public object UserName { get; set; }
        public object IPAddress { get; set; }
    }
}
