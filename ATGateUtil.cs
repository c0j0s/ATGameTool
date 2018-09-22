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
    /// <summary>
    /// 通用方法
    /// </summary>
    class ATGateUtil
    {
        /// <summary>
        /// Check if .Net framwork 4.0 or later is installed 
        /// 检查.Net架构版本是否是4.0以上
        /// </summary>
        /// <returns>真/假</returns>
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

        /// <summary>
        /// Check if .Net framwork 4.5 or later is installed 
        /// 检查.Net架构版本是否是4.5以上
        /// </summary>
        /// <returns>真/假</returns>
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

        /// <summary>
        /// 获取电脑MAC地址
        /// </summary>
        /// <returns>MAC地址</returns>
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

        /// <summary>
        /// 获取电脑IP地址
        /// </summary>
        /// <returns>IP地址</returns>
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

        /// <summary>
        /// 检查服务器是否在线
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>真/假</returns>
        public static Tuple<bool, string> CheckServerStatus(string ip)
        {
            try
            {
                Ping pinger = new Ping();
                Boolean server_status = false;
                PingReply reply = pinger.Send(ip);
                Console.WriteLine("reply.RoundtripTime: " + reply.RoundtripTime);
                server_status = reply.Status == IPStatus.Success;
                Console.WriteLine("Server online? " + server_status);

                if (Properties.Resources.skip_ping.Equals("1"))
                {
                    server_status = true;
                }

                return new Tuple<bool, string>(server_status, reply.RoundtripTime.ToString());
            }
            catch (PingException)
            {
                Console.WriteLine("Fail to ping server");
            }
            return new Tuple<bool, string>(false,"0");
        }

        /// <summary>
        /// 处理未找到游戏文件事件
        /// </summary>
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

        /// <summary>
        /// 处理.Net错误事件
        /// </summary>
        public static void HandleDotNetException()
        {

            if (MessageBox.Show(
                    "访问 " + Properties.Resources.dotNet_update_link + Environment.NewLine + " 下载更新 .Net 4.0 架构后重试。", "请更新 .Net 4.0 架构", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
            {
                Process.Start(Properties.Resources.dotNet_update_link);
                Environment.Exit(0);
            }

        }

    }
}
