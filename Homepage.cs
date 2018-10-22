using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
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

        /// <summary>
        /// 服务器列表
        /// 
        /// 格式如下：
        /// new Server("问道一区","0.0.0.0")
        /// </summary>
        private List<Server> serverList = new List<Server> {
            //最好不要超过5个
            new Server("问道一区","101.132.189.18"),
        };

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[serverList.Count];

            for (int index = 0; index < serverList.Count; index++)
            {
                lvs[index] = new ListViewItem(new string[] { serverList[index].Name + " - 服务器" + serverList[index].Status, "0ms","" });
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

            if (!Properties.Resources.noticeboard.Equals(""))
            {
                lb_notification.Visible = true;
                lb_notification.Text = Properties.Resources.noticeboard;
                pb_title_notification.Visible = true;

            }
        }

        /// <summary>
        /// 读取服务器初始状态
        /// </summary>
        private void GetInitServerStatus()
        {
            for (int index = 0; index < serverList.Count; index++) 
            {
                Tuple<bool, string> tuple = ATGateUtil.CheckServerStatus(serverList[index].Ip);
                if (tuple.Item1)
                {
                    serverList[index].Status = "已连接";
                }
                else {
                    serverList[index].Status = "未连接";
                }
                serverList[index].Delay = tuple.Item2;
                lv_serverlist.Items[index].SubItems[1].Text = serverList[index].Delay;
                lv_serverlist.Items[index].SubItems[0].Text = serverList[index].Name + " - " + serverList[index].Status;
            }
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

            }
            catch (FileLoadException)
            {
                ATGateUtil.HandleDotNetException();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("[HP1]\n更新服务器状态失败，请重试。QQ:" + Properties.Resources.tech_qq + " \nServer: " + serverList[index].Ip, "更新服务器状态");
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
                        MessageBox.Show("游戏启动失败", "游戏启动失败");
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
                MessageBox.Show("注册失败，请重试。", "注册账号");
                return;
            }
        }


        /// <summary>
        /// 检查服务器是否在线
        /// </summary>
        /// <returns>真/假</returns>
        private bool CheckServerStatus()
        {
            if (serverList[selectedServer].Status.Equals("未连接"))
            {
                MessageBox.Show("服务器未连接，请更新状态或选择其他分区。", "服务器未连接");
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

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
