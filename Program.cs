using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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

                WriteDlls();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new Homepage());
            }

        }

        static void WriteDlls() {
           
            if (!File.Exists(@Directory.GetCurrentDirectory() + "/MySql.Data.dll"))
            {
                File.WriteAllBytes("MySql.Data.dll", Properties.Resources.MySql_Data);
            }
        }
    }

}
