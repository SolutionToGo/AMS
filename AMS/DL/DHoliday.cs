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
    public class DHoliday
    {
        public EHoliday GetHolidayType(EHoliday objEHoliday)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_HolidayType]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objEHoliday.dtHolidayType = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Holiday Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEHoliday;
        }
        public EHoliday GetHoliday(EHoliday objEHoliday)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_HoliDay]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objEHoliday.dtHoliday = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Holiday List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEHoliday;
        }
        public EHoliday SaveHoliday(EHoliday objEHoliday)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_HoliDay]";
                    cmd.Parameters.Add("@HolidayID", objEHoliday.HoliDayID);
                    cmd.Parameters.Add("@HolidayDate", objEHoliday.HoliDayDate);
                    cmd.Parameters.Add("@HolidayName", objEHoliday.HoliDayName);
                    cmd.Parameters.Add("@CategoryID", objEHoliday.CategoryID);
                    cmd.Parameters.Add("@UserID", objEHoliday.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if(ds != null)
                    {
                        objEHoliday.HoliDayID = ds.Tables[0].Rows[0][0];
                        objEHoliday.dtHoliday = ds.Tables[1];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Holiday");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEHoliday;
        }
        public EHoliday DeleteHoliday(EHoliday objEHoliday)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Del_Holiday]";
                    cmd.Parameters.Add("@HolidayID", objEHoliday.HoliDayID);
                    objEHoliday.HoliDayID = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Deleting Holiday");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEHoliday;
        }
    }
}
