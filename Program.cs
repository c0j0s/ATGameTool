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
        public static string server_ip = "47.106.10.242";
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
                    Console.WriteLine("Instance already running");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //var watch = System.Diagnostics.Stopwatch.StartNew();

                //QQLogon qLogon = new QQLogon();
                //Application.Run(qLogon);

                //watch.Stop();

                //if (qLogon.verifiedStatus)
                //{
                    CreateAccountRecordAsync("0",1);
                    Application.Run(new Homepage());
                //}
                //else
                //{
                //    CreateAccountRecordAsync(watch.ElapsedMilliseconds.ToString(), 0);
                //}

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
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            return externalip;
        }


        private static async Task CreateAccountRecordAsync(string timeTaken,int loginSuccess)
        {

            Console.WriteLine("Login Time:" + timeTaken + " " + loginSuccess);
            DBWrapper adw = new DBWrapper("launcher");
            await Task.Factory.StartNew(() => adw.CreateAccountRecord(timeTaken,loginSuccess,GetIpAddr(),GetMacAddr(),Application.ProductVersion));
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
            var reportCrash = new ReportCrash("1097808560@qq.com")
            {
                DeveloperMessage = developerMessage
            };
            reportCrash.Send(exception);
        }
    }

}
