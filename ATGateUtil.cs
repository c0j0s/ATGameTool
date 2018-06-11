using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ATGate
{
    /*
    * A utility class with common static methods
    */
    class ATGateUtil
    {
        /*
         * Check if .Net framwork 4.0 or later is installed 
         */
        public static bool IfdotNet4AndLaterInstalled()
        {
            RegistryKey installed_versions = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP");
            string[] version_names = installed_versions.GetSubKeyNames();
            double Framework = Convert.ToDouble(version_names[version_names.Length - 1].Remove(0, 1), CultureInfo.InvariantCulture);

            if (Framework >= 4) {
                return true;
            }

            return false;
        }

        /*
         * Check if .Net framwork 4.5 or later is installed 
         * Not in use
         */
        public static bool IfdotNet45AndLaterInstalled()
        {
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
                if (true)
                {
                    if (releaseKey >= 378389)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*
         * Get the Mac address of the computer
         */
        public static string GetMacAddr()
        {
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

        /*
         * Get the IP address of the computer
         */
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

        /*
         * Check if server online
         */
        public static bool CheckServerStatus()
        {
            try
            {
                Ping pinger = new Ping();
                Boolean server_status = false;
                PingReply reply = pinger.Send(Properties.Resources.server_ip);
                server_status = reply.Status == IPStatus.Success;
                Console.WriteLine("Server online? " + server_status);
                return server_status;
            }
            catch (PingException)
            {
                Console.WriteLine("Fail to ping server");
            }
            return false;
        }

        public static void HandleGameNotFound() {
            string message = "请检查游戏文件,并确保登入器放至于游戏目录下。";
            string caption = "未找到游戏";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        public static void HandleDotNetException()
        {

            if (MessageBox.Show(
                    "访问" + Properties.Resources.dotNet_update_link + Environment.NewLine + "下载更新 .Net 架构后重试。", "请更新 .Net 架构", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
            {
                Process.Start(Properties.Resources.dotNet_update_link);
                Environment.Exit(0);
            }

        }

    }
}
