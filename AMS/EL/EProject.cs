using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EProject
    {
        public DataTable dtAssessmentYear = null;
        public DataTable dtProjects = null;
        public DataTable dtUsers = null;
        public DataTable dtCriteria = null;
        public DataTable dtLeads = null;
        public DataTable dtUserProjects = null;
        public object AssessMentYearID = -1;
        public DataTable dtProjectRatings = null;
        public DataTable dtProjectDetails = null;
        public DataTable dtGeneralRatings = null;
        public DataTable dtGeneralRatingsUpdated = null;
        public DataTable dtEmployeeforPR = null;
        public DataTable dtEmployeeforGR = null;
        public DataTable dtEmployeeforDS = null;
        public DataTable dtEmployeeforLR = null;
        public DataTable dtTechnicalRatings = null;
        public DataTable dtTechnicalRatingsUpdated = null;

        public DataTable dtLeadershipRatings = null;
        public DataTable dtLeadershipRatingsUpdated = null;

        public DataTable dtUserProjectsForDS = null;
        public DataTable dtGeneralRatingsForDS = null;
        public DataTable dtTechnicalRatingsForDS = null;
        public DataTable dtLeadRatingsForDS = null;
        public DataTable dtLeadCommentsForDS = null;

        public object LeadID = -1;
        public int UserInfoID = -1;
        public object ProjectUserMapID = -1;
        public object ProjectID = -1;
        public object ProjectName = -1;
        public object ProjectLeadID = -1;
        public object IsActive = false;
        public object SelfComments = string.Empty;
        public object ManagementComments = string.Empty;
        public object EmployeeID = -1;
    }
    public class ProjectModel
    {
        public int ProjectID { get; set; }

        [Required]
        [Display(Name = "ProjectName")]
        public string ProjectName { get; set; }
    }
    
}
