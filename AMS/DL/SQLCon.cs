using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CategisSecurity;

namespace DL
{
    public static class SQLCon
    {
        static SqlConnection ObjCon = new SqlConnection();
        public static string  ServerName = Convert.ToString(ConfigurationManager.AppSettings["ServerName"]);
        public static string DBName = Convert.ToString(ConfigurationManager.AppSettings["DBName"]);
        public static string UserName = Convert.ToString(ConfigurationManager.AppSettings["username"]);
        public static string Password = Convert.ToString(ConfigurationManager.AppSettings["pwd"]);
        
        public static SqlConnection Sqlconn()
        {
            if (ObjCon.State == ConnectionState.Open)
            {
                return ObjCon;
            }
            else
            {
                ObjCon = Security.Sqlconn(ServerName, DBName, UserName, Password);
                return ObjCon;
            }
        }

    }
}
