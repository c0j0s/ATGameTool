using CrashReporterDotNET;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    static class Program
    {
        public static string server_ip = Properties.Resources.server_ip;
        public static int qq = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitilizeProgram();

            bool createdNew = true;
            using (Mutex mutex = new Mutex(false, Application.ProductName, out createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("启动器已运行", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    try
                    {
#if NeedVerify
                        if (StartVerification())
                        {
                            Application.Run(new Homepage());
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
#else
                        Application.Run(new Homepage());
#endif
                    }
                    catch (System.IO.FileLoadException e)
                    {
                        PromptUpdateDotNet();
                        LogException(e);
                    }
                }
            }
        }

        public static void InitilizeProgram() {

            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.ApplicationExit += ApplicationExitHandler;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        }

        public static bool StartVerification() {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            QQLogon qLogon = new QQLogon();
            Application.Run(qLogon);

            watch.Stop();
            CreateAccountRecordAsync(watch.ElapsedMilliseconds.ToString(), qLogon.verifiedStatus ? 1 : 0);

            return qLogon.verifiedStatus;
        }

        public static void PromptUpdateDotNet() {

            if (MessageBox.Show(
                    "访问" + Properties.Resources.dotNet_update_link + Environment.NewLine + "下载更新 .Net 架构后重试。", "请更新 .Net 架构", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Properties.Resources.dotNet_update_link);
                Environment.Exit(0);
            }

        }

        public static string GetMacAddr() {
            try
            {
                var macAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

                macAddr = macAddr.PadLeft(16, '0');
                return macAddr;
            }
            catch (Exception)
            {
                return "GetMacFail";
            }

        }

        public static string GetIpAddr()
        {
            try
            {
                WebClient wb = new WebClient();
                string externalip = wb.DownloadString(Properties.Resources.get_ip_link);
                wb.Dispose();
                return externalip;
            }
            catch (Exception)
            {
                return "GetIPFail";
            }

        }


        private static async Task CreateAccountRecordAsync(string timeTaken,int loginSuccess)
        {
            try
            {
                Console.WriteLine("Login Time:" + timeTaken + " " + loginSuccess);
                DBWrapper adw = new DBWrapper("launcher");
                await Task.Factory.StartNew(() => adw.CreateAccountRecord(timeTaken, loginSuccess, GetIpAddr(), GetMacAddr(), Application.ProductVersion));
                
            }
            catch (Exception e)
            {
                LogException(e);
            } 
        }

        public static void LogException(Exception e)
        {
            DBWrapper adw = new DBWrapper("launcher");
            adw.SentHandleExceptionLog(GetIpAddr(), GetMacAddr(), Application.ProductVersion, e.ToString(), Environment.OSVersion.ToString());
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            ReportCrash((Exception)unhandledExceptionEventArgs.ExceptionObject);
            Environment.Exit(0);
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ReportCrash(e.Exception);
        }

        public static void ReportCrash(Exception exception, string developerMessage = "")
        {
            var reportCrash = new ReportCrash(Properties.Resources.crash_report_email);
            reportCrash.Send(exception);
        }

        private static void ApplicationExitHandler(object sender, EventArgs e)
        {
            //run all jobs
            //Commit database
        }
    }

}
