using CrashReporterDotNET;
using IWshRuntimeLibrary;
using System;
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
            string gameFile = "asktao.mod";

            //check if in game file
            if (!System.IO.File.Exists(gameFile))
            {
                ATGateUtil.HandleGameNotFound();
            }
            else
            {
                AskToCreateShortcut();
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

        public static void AskToCreateShortcut()
        {
            //check if shutcut exist
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\" + Application.ProductName + ".lnk";
            if (!System.IO.File.Exists(shortcutAddress))
            {
                if (Properties.Settings.Default.wantShortcut)
                {
                    if (MessageBox.Show(
                        "是否添加桌面快捷键？", "桌面快捷键", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                    {
                        ATGateUtil.CreateDesktopShortcut();
                    }
                    else
                    {
                        Properties.Settings.Default.wantShortcut = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
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
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ReportCrash(e.Exception);
        }

        public static void ReportCrash(Exception exception, string developerMessage = "")
        {
            if (exception.GetType().Equals(new FileLoadException().GetType()))
            {
                ATGateUtil.HandleDotNetException();
            }
            else {
                var reportCrash = new ReportCrash(Properties.Resources.crash_report_email);
                reportCrash.Send(exception);
                Environment.Exit(0);
            }
        }

    }

}
