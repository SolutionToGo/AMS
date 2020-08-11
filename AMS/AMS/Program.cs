using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Microsoft.Win32;
using DevExpress.XtraSplashScreen;
using System.Threading;
using EL;
using DL;
using System.Diagnostics;
using System.Net;

namespace AMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
            if (RGkey != null)
            {
                string stSkinName = Convert.ToString(RGkey.GetValue("SkinName"));
                if (string.IsNullOrEmpty(stSkinName))
                    UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
                else
                    UserLookAndFeel.Default.SetSkinStyle(stSkinName);
            }
            else
                UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("                  Connecting to database...");
            bool rtn = Utility.CheckDbConnection();
            if (rtn)
            {
                SplashScreenManager.Default.SetWaitFormDescription("              Connection succeded...");
                Thread.Sleep(1000);
                SplashScreenManager.CloseForm();
                EUser objEUser = new EUser();
                DUser objDUser = new DUser();
                objDUser.GetDBVersion(objEUser);
                if (objEUser.DBVersion != Utility.AppVersion)
                {
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("              Downloading installer");
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://netfiles.de/4987ca49f6da6fe159ec32d624b1050caa471b28ec2ea26a457303a76a99a9ce;AJLc6Xi4","AMS.exe");
                    }
                    SplashScreenManager.CloseForm();
                    Process p = new Process();
                    p.StartInfo.FileName = @"AMS.exe";
                    p.StartInfo.Arguments = "/i \"C:\\Application.msi\"/qn";
                    p.Start();
                    Application.Exit();
                }
                else { Application.Run(new frmLogin()); }
                //Application.Run(new frmLogin());
            }
            else
            {
                SplashScreenManager.Default.SetWaitFormDescription("                  Connection failed...");
                Thread.Sleep(5000);
                SplashScreenManager.CloseForm();
                Application.Exit();
            }
        }
    }
}
