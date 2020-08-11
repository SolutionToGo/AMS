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
     public class DReports
    {
        public EReports GetSelfAssessment(EReports ObjERpeorts)
        {
            ObjERpeorts.dsAssessment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_SelfAssessment]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjERpeorts.AssessmentyYearID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjERpeorts.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ObjERpeorts.dsAssessment);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Self Assessment Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public EReports GetDAssessment(EReports ObjERpeorts)
        {
            ObjERpeorts.dsAssessment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_DAssessment]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjERpeorts.AssessmentyYearID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjERpeorts.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ObjERpeorts.dsAssessment);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Assessment");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }
    }
}
