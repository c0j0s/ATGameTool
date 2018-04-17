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
        public static string server_ip = "120.79.216.211";

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

        //NOT INUSE
        private static void ReadConfigFile()
        {
            string filename = Directory.GetCurrentDirectory() + "/download/global/global_distlist.txt";
            if (File.Exists(filename))
            {
                string input = File.ReadLines(filename).Skip(1).Take(1).First(); 
                input = input.Replace(" ", string.Empty);
                input = input.Replace("\t", string.Empty);
                input = input.Replace("\n", ",");
                
                Dictionary<string, string> keyValuePairs = input.Split(',')
                  .Select(value => value.Split('='))
                  .ToDictionary(pair => pair[0], pair => pair[1]);

                server_ip = keyValuePairs["ZoneIp"];
                Console.WriteLine(server_ip);
            }
        }

        //NOT INUSE
        static void OnProcessExit(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@Directory.GetCurrentDirectory() + "/LoaderDll.dll"))
                {
                    UnloadModule("LoaderDll.dll");
                    File.Delete(@Directory.GetCurrentDirectory() + "/LoaderDll.dll");
                }
                if (File.Exists(@Directory.GetCurrentDirectory() + "/LocaleEmulator.dll"))
                {
                    UnloadModule("LocaleEmulator.dll");
                    File.Delete(@Directory.GetCurrentDirectory() + "/LocaleEmulator.dll");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.Write("File in used: ");
                
            }

        }

        //For freeing the DLL files
        static void WriteDlls() {
           
            if (!File.Exists(@Directory.GetCurrentDirectory() + "/LoaderDll.dll") )
            {
                File.WriteAllBytes("LoaderDll.dll", Properties.Resources.LoaderDll);
            }
            if (!File.Exists(@Directory.GetCurrentDirectory() + "/LocaleEmulator.dll"))
            {
                File.WriteAllBytes("LocaleEmulator.dll", Properties.Resources.LocaleEmulator);
            }
        }

        [DllImport("kernel32", SetLastError = true)]
        static extern bool FreeLibrary(IntPtr hModule);

        public static void UnloadModule(string moduleName)
        {
            foreach (ProcessModule mod in Process.GetCurrentProcess().Modules)
            {
                if (mod.ModuleName == moduleName)
                {
                    FreeLibrary(mod.BaseAddress);
                }
            }
        }
    }

}
