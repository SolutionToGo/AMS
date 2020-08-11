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
    public class DProject
    {
        public List<ProjectModel> GetProject()
        {
            List<ProjectModel> l = new List<ProjectModel>();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Project]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    l = (from DataRow row in dt.Rows

                         select new ProjectModel
                         {
                             ProjectID = Convert.ToInt32(row["ProjectID"]),
                             ProjectName = Convert.ToString(row["ProjectName"])
                         }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Project List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return l;
        }

        public ProjectModel GetProjectDetails(int Id = 0)
        {
            ProjectModel p = new ProjectModel();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectDetails]";
                    cmd.Parameters.Add("@ProjectID", Id);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        p.ProjectID = Convert.ToInt32(dt.Rows[0]["ProjectID"]);
                        p.ProjectName = Convert.ToString(dt.Rows[0]["ProjectName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Project Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return p;
        }

        public ProjectModel SaveProject(ProjectModel ObjProjectModel)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Project]";
                    cmd.Parameters.Add("@ProjectID", ObjProjectModel.ProjectID);
                    cmd.Parameters.Add("@ProjectName", ObjProjectModel.ProjectName);
                    object objReturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    string str = Convert.ToString(objReturn);
                    if (int.TryParse(str, out IValue))
                    {
                        ObjProjectModel.ProjectID = IValue;
                    }
                    else
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("Project Already Exists!!");
                else
                    throw new Exception("Error While Saving Project!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjProjectModel;
        }

        public ProjectModel DeleteProject(ProjectModel ObjProjectModel)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Del_Project]";
                    cmd.Parameters.Add("@ProjectID", ObjProjectModel.ProjectID);
                    object objReturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    string str = Convert.ToString(objReturn);
                    if (int.TryParse(str, out IValue))
                    {
                        ObjProjectModel.ProjectID = IValue;
                    }
                    else
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Deleting Project!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjProjectModel;
        }

        public EProject GetUsers(EProject objEProject)
        {
            objEProject.dtUsers = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_User]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtUsers);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }

        public EProject GetProjects(EProject objEProject)
        {
            objEProject.dtProjects = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Project]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtProjects);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Project List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }

        public EProject SaveProjectList(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtProjects = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Project]";
                    cmd.Parameters.Add("@ProjectID", objEProject.ProjectID);
                    cmd.Parameters.Add("@ProjectName", objEProject.ProjectName);
                    cmd.Parameters.Add("@ProjectLeadID", objEProject.ProjectLeadID);
                    cmd.Parameters.Add("@IsActive", objEProject.IsActive);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stProjectID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stProjectID, out ivalue))
                        {
                            objEProject.ProjectID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtProjects = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Project");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }

        public EProject GetProjectRatingsMaster(EProject ObjEProject)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectsRatingMaster]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEProject.dtAssessmentYear = ds.Tables[0];
                        if (ds != null && ds.Tables.Count > 1)
                        {
                            ObjEProject.dtProjects = ds.Tables[1];
                            if (ds != null && ds.Tables.Count > 2)
                            {
                                ObjEProject.dtCriteria = ds.Tables[2];
                                if (ds != null && ds.Tables.Count > 3)
                                {
                                    ObjEProject.dtLeads = ds.Tables[3];
                                }
                            }
                        }
                    }
                        
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Project Rating Master");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject SaveUserProject(EProject ObjEProject)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_ProjectRatings]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@ProjectUserMapID", ObjEProject.ProjectUserMapID);
                    cmd.Parameters.Add("@ProjectID", ObjEProject.ProjectID);    
                    cmd.Parameters.Add("@AssessmentYear", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@SelfComments", ObjEProject.SelfComments);
                    cmd.Parameters.Add("@ManagementComments", ObjEProject.ManagementComments);
                    cmd.Parameters.Add("@dtRatings", ObjEProject.dtProjectRatings);
                    cmd.Parameters.Add("@LeadID", ObjEProject.LeadID);
                    object Objreturn = cmd.ExecuteScalar();
                    int Ivalue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out Ivalue))
                        ObjEProject.ProjectUserMapID = Ivalue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));

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
            return ObjEProject;
        }

        public EProject GetUserProject(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UserPorjects]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtUserProjects = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User Projects");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetUserProjectDetails(EProject ObjEProject)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsByID]";
                    cmd.Parameters.Add("@ProjectUserMapID", ObjEProject.ProjectUserMapID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEProject.ProjectID = ds.Tables[0].Rows[0]["ProjectID"];
                        ObjEProject.SelfComments = ds.Tables[0].Rows[0]["Selfcomments"];
                        ObjEProject.ManagementComments = ds.Tables[0].Rows[0]["ManagementComments"];
                        ObjEProject.LeadID = ds.Tables[0].Rows[0]["ProjectLeadID"];
                        if (ds.Tables.Count > 1)
                        {
                            ObjEProject.dtCriteria = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User Project Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetGeneralRatings(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_GeneralRatings]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtGeneralRatings = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving General Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject SaveGeneralRatings(EProject ObjEProject)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_GeneralRatings]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@dtRatings", ObjEProject.dtGeneralRatingsUpdated);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    cmd.ExecuteNonQuery();
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
            return ObjEProject;
        }

        public EProject GetAssessmentYearforMS(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_AYearandUserforMS]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtAssessmentYear = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Assessment Years");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetEmployeeforProjectRatings(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforProjectRating]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentyearID", ObjEProject.AssessMentYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtEmployeeforPR = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetEmployeeforLR(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforLRating]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentyearID", ObjEProject.AssessMentYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtEmployeeforLR = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetEmployeeforGR(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforGR]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtEmployeeforGR = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetUserProjectForMS(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsfoMS]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@EmployeeID", ObjEProject.EmployeeID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtUserProjects = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User Projects");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetEmployeeforDS(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeForDS]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtEmployeeforDS = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetEmployeeRatingsforDS(EProject ObjEProject)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_RatingsForDS]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@EmployeeID", ObjEProject.EmployeeID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                    {
                        ObjEProject.dtUserProjectsForDS = dS.Tables[0];
                        if (dS.Tables.Count > 1)
                        {
                            ObjEProject.dtGeneralRatingsForDS = dS.Tables[1];
                        }
                        else
                            ObjEProject.dtGeneralRatingsForDS = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetTechnicalRatingsforDS(EProject ObjEProject)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TechnicalRatingsForDS]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@EmployeeID", ObjEProject.EmployeeID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                        ObjEProject.dtTechnicalRatingsForDS = dS.Tables[0];
                    else
                        ObjEProject.dtTechnicalRatingsForDS = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetUserProjectDetailsForDS(EProject ObjEProject)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsByIDForDS]";
                    cmd.Parameters.Add("@ProjectUserMapID", ObjEProject.ProjectUserMapID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@EmployeeID", ObjEProject.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEProject.ProjectID = ds.Tables[0].Rows[0]["ProjectID"];
                        ObjEProject.SelfComments = ds.Tables[0].Rows[0]["Selfcomments"];
                        ObjEProject.ManagementComments = ds.Tables[0].Rows[0]["ManagementComments"];
                        ObjEProject.LeadID = ds.Tables[0].Rows[0]["ProjectLeadID"];
                        if (ds.Tables.Count > 1)
                        {
                            ObjEProject.dtCriteria = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User Project Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetLeadRatingsforDS(EProject ObjEProject)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadRatingsForDS]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@EmployeeID", ObjEProject.EmployeeID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                    {
                        ObjEProject.dtLeadRatingsForDS = dS.Tables[0];
                        if (dS.Tables.Count > 1)
                        {
                            ObjEProject.dtLeadCommentsForDS = dS.Tables[1];
                        }
                        else
                            ObjEProject.dtLeadCommentsForDS = null;
                    }
                    else
                        ObjEProject.dtLeadRatingsForDS = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject GetTechnicalRatings(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TechnicalRatings]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtTechnicalRatings = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Technical Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject SaveTechnicalRatings(EProject ObjEProject)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_TechnicalRatings]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@dtRatings", ObjEProject.dtTechnicalRatingsUpdated);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    cmd.ExecuteNonQuery();
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
            return ObjEProject;
        }

        public EProject GetLeadRatings(EProject ObjEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadRatings]";
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEProject.dtLeadershipRatings = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Leadership Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEProject;
        }

        public EProject SaveLeadRatings(EProject ObjEProject)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_LeadRatings]";
                    cmd.Parameters.Add("@UserInfoID", ObjEProject.UserInfoID);
                    cmd.Parameters.Add("@AssessmentYearID", ObjEProject.AssessMentYearID);
                    cmd.Parameters.Add("@dtRatings", ObjEProject.dtLeadershipRatingsUpdated);
                    cmd.Parameters.Add("@RatingUserID", ObjEProject.EmployeeID);
                    cmd.ExecuteNonQuery();
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
            return ObjEProject;
        }
    }
}
