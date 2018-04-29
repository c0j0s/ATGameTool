using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
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
            using (Mutex mutex = new Mutex(false, "Global\\1a25711f-a9dd-412b-8a93-82a7e2c3def8"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    Console.WriteLine("Instance already running");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                WriteDlls();

                Application.Run(new Homepage());

                QQLogon qLogon = new QQLogon();
                Application.Run(qLogon);

                if (qLogon.verifiedStatus)
                {
                    Application.Run(new Homepage());
                }

            }

        }

        static void WriteDlls() {
           
            if (File.Exists(@Directory.GetCurrentDirectory() + "/MySql.Data.dll"))
            {
                File.Delete(@Directory.GetCurrentDirectory() + "/MySql.Data.dll");
                File.WriteAllBytes("MySql.Data.dll", Properties.Resources.MySql_Data);
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
    }

}
