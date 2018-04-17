using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Homepage : Form
    { 
        public Homepage()
        {
            InitializeComponent();
            DoWorkAsyncCheckServerStatus();
        }

        private void Btn_start_game_Click(object sender, EventArgs e)
        {
            #if DEBUG
                string absPath = "C:/Users/User/Desktop/LTxiaoyao/asktao.mod";
            #else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
            #endif

            if (!File.Exists(absPath))
            {
                string message = "请检查游戏文件。";
                string caption = "未找到游戏";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }

            }
            else
            {
                
                string Location = "zh-TW";
                string applicationName = absPath;

                var currentDirectory = Path.GetDirectoryName(absPath);
                var ansiCodePage = (uint)CultureInfo.GetCultureInfo(Location).TextInfo.ANSICodePage;
                var oemCodePage = (uint)CultureInfo.GetCultureInfo(Location).TextInfo.OEMCodePage;
                var localeID = (uint)CultureInfo.GetCultureInfo(Location).TextInfo.LCID;
                var defaultCharset = (uint)136;
                var registries = RegistryEntriesLoader.GetRegistryEntries(true);

                var l = new LoaderWrapper
                {
                    ApplicationName = applicationName,
                    CommandLine = "des:951A6367121D77FAABF5B6D3699D75F3ECD12843AB085EBB03CCF9AB4279613A9FD8AF40C7D3A5777DBB17C6A416065A1D73491AADCD8A1A0E6C3C7C1A67481B5AA36246A2B5E45B1871D7FC46513D3B1A567BD7AA056297",
                    CurrentDirectory = currentDirectory,
                    AnsiCodePage = ansiCodePage,
                    OemCodePage = oemCodePage,
                    LocaleID = localeID,
                    DefaultCharset = defaultCharset,
                    HookUILanguageAPI = 0,
                    Timezone = "Tokyo Standard Time",
                    NumberOfRegistryRedirectionEntries = registries.Length,
                    DebugMode = false
                };

                registries?.ToList()
                .ForEach(
                    item =>
                        l.AddRegistryRedirectEntry(item.Root,
                            item.Key,
                            item.Name,
                            item.Type,
                            item.GetValue(CultureInfo.GetCultureInfo(Location))));

                btn_start_game.Enabled = false;

                if (l.Start() != 0)
                {
                    btn_start_game.Enabled = true;
                }
                else
                {
                    DoWorkAsyncCheckGameStatus();
                }

            }
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void Server_status_Click(object sender, EventArgs e)
        {
            Check_server_status();
        }

        private async Task DoWorkAsyncCheckServerStatus()
        {
            while (true)
            {
                Check_server_status();
                await Task.Delay(5000);
            }
        }

        private void Check_server_status() {
            Ping pinger = new Ping();
            try
            {
                Boolean server_status = false;
                PingReply reply = pinger.Send(Program.server_ip);
                server_status = reply.Status == IPStatus.Success;
                Change_server_status_light(server_status);
                Console.WriteLine("Server online? " + server_status);
            }
            catch (PingException)
            {
                Console.WriteLine("Fail to ping server");
            }
        }

        private void Change_server_status_light(Boolean online)
        {
            if (online)
            {
                server_status.Text = "服务器已连接";
                serverStatusLight.Image = Properties.Resources.server_online;
            }
            else
            {
                server_status.Text = "服务器未连接";
                serverStatusLight.Image = Properties.Resources.server_offline;
            }
            btn_start_game.Enabled = online;
        }

        private async Task DoWorkAsyncCheckGameStatus()
        {
            while (true)
            {
                Process[] runningProcesses = Process.GetProcessesByName("asktao.mod");
                if (runningProcesses.Length == 1)
                {
                    Console.WriteLine("Game Started, Ending Launcher.");
                    Thread.Sleep(3000);
                    Application.Exit();
                }
                await Task.Delay(1000);
            }
        }

    }
}
