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
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            using (Mutex mutex = new Mutex(false, "Global\\1a25711f-a9dd-412b-8a93-82a7e2c3def8"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("启动器已运行",Application.ProductName, MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var watch = System.Diagnostics.Stopwatch.StartNew();

                QQLogon qLogon = new QQLogon();
                Application.Run(qLogon);

                watch.Stop();

                if (qLogon.verifiedStatus)
                {
                    CreateAccountRecordAsync(watch.ElapsedMilliseconds.ToString(), 1);
                    Application.Run(new Homepage());
                }
                else
                {
                    CreateAccountRecordAsync(watch.ElapsedMilliseconds.ToString(), 0);
                }

            }

        }

        public static string GetMacAddr() {
            var macAddr =
                    (
                        from nic in NetworkInterface.GetAllNetworkInterfaces()
                        where nic.OperationalStatus == OperationalStatus.Up
                        select nic.GetPhysicalAddress().ToString()
                    ).FirstOrDefault();

            macAddr = macAddr.PadLeft(16, '0');
            return macAddr;
        }

        public static string GetIpAddr()
        {
            string externalip = new WebClient().DownloadString(Properties.Resources.get_ip_link);
            return externalip;
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
                if (MessageBox.Show(
                        "访问" + Properties.Resources.dotNet_update_link + Environment.NewLine + "下载更新 .Net 架构后重试。", "请更新 .Net 架构", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                    ) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Properties.Resources.dotNet_update_link);
                }
                LogException(e);
                Environment.Exit(0);
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
            var reportCrash = new ReportCrash(Properties.Resources.crash_report_email)
            {
                DeveloperMessage = developerMessage
            };
            reportCrash.Send(exception);
        }
    }

}
