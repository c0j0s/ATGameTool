using CrashReporterDotNET;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ATGate
{
    static class Program
    {
        public static int qq = 0;

        [STAThread]
        static void Main()
        {
            InitilizeProgram();

            if (CheckPreRequisite())
            {
                bool createdNew = true;
                using (Mutex mutex = new Mutex(false, Application.ProductName, out createdNew))
                {
                    if (!createdNew)
                    {
                        MessageBox.Show("[P1]\n启动器已运行", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                        catch (System.IO.FileLoadException)
                        {
                            ATGateUtil.HandleDotNetException();
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 检查启动条件
        /// </summary>
        /// <returns>真/假</returns>
        private static bool CheckPreRequisite()
        {
#if DEBUG
            string gameFile = @"asktao.mod";
#else
            string gameFile = "asktao.mod";
#endif

            //check if in game file
            if (!File.Exists(gameFile))
            {
                ATGateUtil.HandleGameNotFound();
            }
            else
            {
                if (ATGateUtil.IfdotNet4AndLaterInstalled())
                {
                    return true;
                }
                else
                {
                    ATGateUtil.HandleDotNetException();
                }
            }
            return false;
        }

        /// <summary>
        /// 初始程序
        /// </summary>
        public static void InitilizeProgram()
        {
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        }

        /// <summary>
        /// 启动QQ验证
        /// </summary>
        /// <returns>真/假</returns>
        public static bool StartVerification()
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            QQLogon qLogon = new QQLogon();
            Application.Run(qLogon);

            watch.Stop();

            return qLogon.verifiedStatus;
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

    }

}
