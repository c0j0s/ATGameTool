using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 参数修改文件：
/// ATGate -> Properties -> Resources.rex
/// </summary>
namespace ATGate
{
    public partial class Homepage : Form
    {
        private Button serverRefreashBtn = new Button();
        private int selectedServer;
        private static int refreashServerTryCount = 0;
        private static bool skipPing = false;

        /// <summary>
        /// 服务器列表
        /// 
        /// 格式如下：
        /// new Server("问道一区","0.0.0.0")
        /// </summary>
        private List<Server> serverList = new List<Server> {
            //最好不要超过5个
            new Server("问道一区","222.187.220.230"),
        };

        public Homepage()
        {
            //初始化
            InitializeComponent();
            //lb_client_ip.Text = ATGateUtil.GetIpAddr();
            //lb_client_mac.Text = ATGateUtil.GetMacAddr();
            lb_client_version.Text = Application.ProductVersion + " " + Properties.Resources.distribute;
            if (System.Environment.OSVersion.Version.Major <= 5)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            FormClosing += Homepage_FormClosing;
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.newProcessMode = cb_use_cp_mode.Checked;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[serverList.Count];

            for (int index = 0; index < serverList.Count; index++)
            {
                lvs[index] = new ListViewItem(new string[] { serverList[index].Name + " - " + serverList[index].Status, "0ms","" });
            }

            lv_serverlist.Items.AddRange(lvs);

            serverRefreashBtn.Text = "更新状态";
            serverRefreashBtn.Font = new Font("KaiTi", 12);
            serverRefreashBtn.FlatStyle = FlatStyle.Flat;
            serverRefreashBtn.BackColor = Color.Transparent;
            serverRefreashBtn.FlatAppearance.BorderSize = 0;
            serverRefreashBtn.Click += UpdateServerStatus;
            lv_serverlist.Controls.Add(serverRefreashBtn);
            serverRefreashBtn.Visible = false;
            serverRefreashBtn.Size = new Size(lv_serverlist.Items[0].SubItems[2].Bounds.Width, lv_serverlist.Items[0].SubItems[2].Bounds.Height);
            lv_serverlist.Items[0].Selected = true;
            lv_serverlist.Select();

            GetInitServerStatus();

            //if (!Properties.Resources.noticeboard.Equals(""))
            //{
            //    lb_notification.Visible = true;
            //    lb_notification.Text = Properties.Resources.noticeboard;
            //    pb_title_notification.Visible = true;
            //}

            cb_use_cp_mode.Checked = Properties.Settings.Default.newProcessMode;
        }

        /// <summary>
        /// 读取服务器初始状态
        /// </summary>
        private async void GetInitServerStatus()
        {

            var tasks = new List<Task>();

            for (int index = 0; index < serverList.Count; index++)
            {
                Ping ping = new Ping();
                var task = PingAndUpdateNodeAsync(ping, serverList[index], lv_serverlist.Items[index]);
                tasks.Add(task);
            }

            await TaskEx.WhenAll(tasks);

        }

        private async Task PingAndUpdateNodeAsync(Ping ping, Server server, ListViewItem item)
        {
            var reply = await ping.SendTaskAsync(server.Ip);
            if (reply.Status == IPStatus.Success)
            {
                server.Status = "已连接";
            }
            else
            {
                server.Status = "未连接";
            }
            server.Delay = reply.RoundtripTime.ToString();
            item.SubItems[1].Text = server.Delay;
            item.SubItems[0].Text = server.Name + " - " + server.Status;
        }

        /// <summary>
        /// 处理选择项更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_serverlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[2];
            if (lv_serverlist.SelectedItems.Count > 0)
            {
                serverRefreashBtn.Location = new Point(lv_serverlist.SelectedItems[0].SubItems[2].Bounds.Left, lv_serverlist.SelectedItems[0].SubItems[2].Bounds.Top);
                serverRefreashBtn.Visible = true;
                selectedServer = lv_serverlist.SelectedItems[0].Index;
                Console.WriteLine(selectedServer);
            }
            else {
                serverRefreashBtn.Visible = false;
            }
        }

        /// <summary>
        /// 更新服务器状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateServerStatus(object sender, EventArgs e) {
            int index = 0;
            try
            {
                serverRefreashBtn.Enabled = false;

                if (selectedServer != lv_serverlist.SelectedIndices[0] || serverList[lv_serverlist.SelectedIndices[0]].Status.Equals("已连接"))
                {
                    refreashServerTryCount = 0;
                }

                selectedServer = lv_serverlist.SelectedIndices[0];

                index = selectedServer;
                lv_serverlist.Items[index].SubItems[1].Text = "...";

                
                await Task.Factory.StartNew(() =>
                {
                    Tuple<bool, string> tuple = ATGateUtil.CheckServerStatus(serverList[index].Ip);
                    if (tuple.Item1)
                    {
                        serverList[index].Status = "已连接";
                    }
                    else
                    {
                        serverList[index].Status = "未连接";
                    }
                    serverList[index].Delay = tuple.Item2;
                });
                lv_serverlist.Items[index].SubItems[1].Text = serverList[index].Delay;
                lv_serverlist.Items[index].SubItems[0].Text = serverList[index].Name + " - " + serverList[index].Status;
                Console.WriteLine(index);

                if (refreashServerTryCount > 5 && serverList[index].Status.Equals("未连接"))
                {
                    if (new MsgBox("[HP1]", "尝试直接启动", "更新服务器状态失败，是否尝试直接启动游戏？", serverList[index].Ip.Split('.')[2] + "." + serverList[index].Ip.Split('.')[3]).ShowDialog() == DialogResult.Yes)
                    {
                        skipPing = true;
                    }
                } 

                refreashServerTryCount++;
                serverRefreashBtn.Enabled = true;

            }
            catch (FileLoadException)
            {
                ATGateUtil.HandleDotNetException();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                new MsgBox("[HP2]", "更新服务器状态", "更新服务器状态失败，请重试。", serverList[index].Ip.Split('.')[2] + "." + serverList[index].Ip.Split('.')[3]).ShowDialog();
                serverRefreashBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 开始游戏按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Btn_start_game_Click(object sender, EventArgs e)
        {
            try
            {
#if DEBUG
                string absPath = @"asktao.mod";
#else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
#endif
                
                if (!CheckServerStatus())
                {
                    return;
                }
                Console.WriteLine("Starting Game " + selectedServer);
                Server server = serverList[selectedServer];

                if (!File.Exists(absPath))
                {
                    ATGateUtil.HandleGameNotFound();
                }
                else
                {
                    btn_start_game.Enabled = false;
                    btn_register.Enabled = false;
                    btn_about.Enabled = false;
                    lb_startGameStatus.Visible = true;

                    bool status = false;
                    await Task.Factory.StartNew(() =>
                    {
                        if (cb_use_cp_mode.Checked == false)
                        {
                            status = HandleStartGame.StartProcessByCmd(server);
                        }
                        else
                        {
                            status = HandleStartGame.StartProcessSimplify(absPath, server.CmdArgs);
                        }
                    });

                    if (status)
                    {

                        await Task.Factory.StartNew(() =>
                        {
                            Thread.Sleep(3000);
                            Console.WriteLine("Game Started, Ending Launcher.");
                            Environment.Exit(0);
                        });
                    }
                    else
                    {
                        btn_start_game.Enabled = true;
                        btn_register.Enabled = true;
                        btn_about.Enabled = true;
                        lb_startGameStatus.Visible = false;
                        new MsgBox("[HP3]", "游戏启动失败", "游戏启动失败").ShowDialog();
                    }

                }

            }
            catch (FileLoadException)
            {
                ATGateUtil.HandleDotNetException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 关于按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_about_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        /// <summary>
        /// 注册按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_register_Click(object sender, EventArgs e)
        {
            try
            {

                if (!CheckServerStatus())
                {
                    return;
                }
                Console.WriteLine("Register server " + selectedServer);
                Server server = serverList[selectedServer];
                Register register = new Register(server)
                {
                    Text = server.Name + " - 注册账号"
                };
                register.ShowDialog(this);
            }
            catch (System.IO.FileLoadException) {
                ATGateUtil.HandleDotNetException();
            }
            catch (Exception)
            {
                new MsgBox("[HP4]", "注册账号", "注册失败，请重试。").ShowDialog();
                return;
            }
        }


        /// <summary>
        /// 检查服务器是否在线
        /// </summary>
        /// <returns>真/假</returns>
        private bool CheckServerStatus()
        {
            if (skipPing == true)
            {
                return true;
            }
            else if (serverList[selectedServer].Status.Equals("未连接"))
            {
                new MsgBox("[HP5]", "服务器未连接", "服务器未连接，请更新状态或选择其他分区。").ShowDialog();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取公告
        /// </summary>
        /// <returns></returns>
        private string RetrieveNotifications() {

            string notification = "";
            try
            {
                var webRequest = (HttpWebRequest)HttpWebRequest.Create(Properties.Resources.notification_url);
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    notification = reader.ReadToEnd();
                }
                Console.WriteLine("no: "+notification);
                return notification;
            }
            catch (Exception ex)
            {
                Console.WriteLine("no: " + ex.Message);
                return "";
            }
            
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_create_shortcut_Click(object sender, EventArgs e)
        {
            ATGateUtil.CreateDesktopShortcut();
            Properties.Settings.Default.wantShortcut = true;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 窗口化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 本地模式选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_use_cp_mode_info_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(true);
            aboutBox.ShowDialog(this);
        }

        /// <summary>
        /// 跳过检测选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_skip_ping_CheckedChanged(object sender, EventArgs e)
        {
            skipPing = cb_skip_ping.Checked;
        }

        /// <summary>
        /// 窗口控制
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AllowMoveWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
