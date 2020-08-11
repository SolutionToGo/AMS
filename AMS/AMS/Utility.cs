using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AMS
{
    public class Utility
    {        
        public static int UserID = 0;
        public static string UserName = string.Empty;
        public static string UserFullName = string.Empty;
        public static string Password = string.Empty;
        public static int RoleID = 0;
        public static string Designation = string.Empty;
        public static string ReportingLead = string.Empty;

        public static string MachineName = string.Empty;
        public static string MachineUserName = string.Empty;
        public static string IPAddress = string.Empty;

        public static int OrgID = 1;
        public static string OrgName = string.Empty;
        public static string OrgShortName = string.Empty;
        public static string OrgAddress = string.Empty;
        public static string OrgCNumber = string.Empty;
        public static string STNumber = string.Empty;
        public static string State = string.Empty;

        public static int BranchID = 1;
        public static string BranchName = string.Empty;
        public static string BranchAddress = string.Empty;
        public static string BranchCPerson = string.Empty;
        public static string BranchCNumber = string.Empty;

        public static string FromEmail = string.Empty;
        public static string FromPassword = string.Empty;
        public static string ToMobile = string.Empty;

        public static string strURL = string.Empty;
        public static string strAppKey = string.Empty;
        public static string strSenderID = string.Empty;

        public static int DoctorID = 0;
        public static string DTitle = string.Empty;
        public static string DName = string.Empty;
        public static string DQualification = string.Empty;
        public static string DAddress = string.Empty;
        public static string DEmail = string.Empty;
        public static string DPhone = string.Empty;
        public static string DNameHindi = string.Empty;
        public static string DQualificationHindi = string.Empty;

        public static string AppVersion = "1.4";

        public static bool PrinterStatus = true;

        public static byte[] Imagedata = null;

        public static DateTime dtSelectedDate;
        public static void ShowError(Exception ex)
        {
            if (ex.Message.Contains("Please wait for some time"))
                XtraMessageBox.Show("Minimum lunch time is 15mins. Please wait.", "Lunch Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Setfocus(GridView view, string ColumnName, object Value)
        {
            try
            {
                if (Convert.ToInt32(Value) > -1)
                {
                    int rowHandle = view.LocateByValue(ColumnName, Value);
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        view.FocusedRowHandle = rowHandle;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Encrypt(string input)
        {
            try
            {
                return CategisSecurity.Security.Encrypt(input);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SendEmail(string Subject, string Body, string filepath, XtraForm Parent)
        {
            MailMessage msg = new MailMessage();
            try
            {
                SplashScreenManager.ShowForm(Parent, typeof(frmSpinner), true, true, false);
                msg.From = new MailAddress("gyanasofts@gmail.com");
                msg.To.Add(FromEmail);
                msg.Subject = Subject;
                msg.Body = Body;
                msg.Attachments.Add(new Attachment(filepath));

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "gyanasofts@gmail.com";
                ntcd.Password = "31153115";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show("Your Mail is Sent");
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Utility.ShowError(ex);
            }
            finally
            {
                msg.Dispose();
                msg = null;
            }
        }

        public static bool CheckDbConnection()
        {
            try
            {
                SQLCon.Sqlconn();
                if (SQLCon.Sqlconn().State == System.Data.ConnectionState.Open)
                    SQLCon.Sqlconn().Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static void PrintRecipt(int FeePaymentID)
        {
            try
            {
                XtraReport rpt = new XtraReport();
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                rpt.Parameters["FeePaymentID"].Value = FeePaymentID;
                rpt.Parameters["OrgName"].Value = Utility.OrgName;
                rpt.Parameters["OrgAddress"].Value = Utility.OrgAddress;
                rpt.Parameters["OrgContact"].Value = Utility.OrgCNumber;
                rpt.Parameters["STNumber"].Value = Utility.STNumber;
                rpt.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to print Recipt");
            }
        }

        public static string GetResource(string stVal)
        {
            ResourceManager rm = new ResourceManager("AMS.Language.H", Assembly.GetExecutingAssembly());
            return rm.GetString(stVal);
        }

        public static void Printreport(XtraReport rpt,string  Printername)
        {
            try
            {
                if (PrinterStatus)
                {
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    printTool.Print(Printername);
                }
            }
            catch (Exception ex){}
        }

        public static DataTable ChangeColumnDataType(DataTable dt)
        {
            DataTable dtTemp = dt.Clone();
            try
            {
                dtTemp.Columns["SA"].DataType = typeof(decimal);
                DataRow drnew = null;
                foreach (DataRow dr in dt.Rows)
                {
                    drnew = dtTemp.NewRow();
                    foreach (DataColumn dc in dtTemp.Columns)
                    {
                        if (dc.ColumnName == "SA")
                        {
                            decimal dValue = 0;
                            if (decimal.TryParse(Convert.ToString(dr["SA"]), out dValue))
                                drnew[dc.ColumnName] = dr[dc.ColumnName];
                        }
                        else
                            drnew[dc.ColumnName] = dr[dc.ColumnName];
                    }
                    dtTemp.Rows.Add(drnew);
                }
            }
            catch (Exception ex){throw ex;}
            return dtTemp;
        }
        
    }
}
