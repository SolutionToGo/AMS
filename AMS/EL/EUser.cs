using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EUser
    {
        public string DBVersion = string.Empty;
        private int _UserInfoID = -1;
        private string _UserName = string.Empty;
        private string _UserFullName = string.Empty;
        private string _Password = string.Empty;
        private int _UserID = 0;
        private DataTable _dtUser = null;

        public int UserInfoID
        {
            get { return _UserInfoID; }
            set { _UserInfoID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string FullName
        {
            get { return _UserFullName; }
            set { _UserFullName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public string CNumber = string.Empty;


        public object RoleID;
        public object DesignationID;
        public object ReportingLeadID;

        public object EmployeeID = null;
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtUser
        {
            get { return _dtUser; }
            set { _dtUser = value; }
        }

        public DataTable dtRoles;
        public DataTable dtDesignations;
        public DataTable dtUserDetails { get; set; }
        public string URLtext { get; set; }
        public string AppKey { get; set; }
        public string SenderID { get; set; }
        public string Passwordstring { get; set; }

        public string EMail { get; set; }

    }
    public class EmployeeModel
    {
        public int UserInfoID { get; set; }
        public int OrgID { get; set; }
        public int BranchID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Passwordstring { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string CNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string EMail { get; set; }
        public int RoleID { get; set; }
        public int DesignationID { get; set; }
        public int ReportingLeadID { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public string DesignationName { get; set; }

        [Required]
        [Display(Name = "Reporting Lead")]
        public string ReportingLead { get; set; }
    }

    public class DesignationModel
    {
        public object DesignationID { get; set; }

        [Required]
        [Display(Name = "Desigation Name")]
        public object DesignationName { get; set; }

    }

    public class RoleModel
    {
        public object RoleID { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public object RoleName { get; set; }

    }

    public class ReportingLeadModel
    {
        public object ReportingLeadID { get; set; }

        [Required]
        [Display(Name = "Reporting Lead")]
        public object ReportingLead { get; set; }

    }
}
