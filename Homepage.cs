using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        /// new Server("问道一区","117.50.75.135")
        /// </summary>
        private List<Server> serverList = new List<Server> {
            new Server("问道一区","120.77.45.180","2000")
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

            serverRefreashBtn.Visible = true;
            serverRefreashBtn.Text = "更新状态";
            serverRefreashBtn.Font = new Font(serverRefreashBtn.Font.FontFamily, 9);
            serverRefreashBtn.Click += UpdateServerStatus;
            lv_serverlist.Controls.Add(serverRefreashBtn);
            serverRefreashBtn.Size = new Size(lv_serverlist.Items[0].SubItems[2].Bounds.Width,
            lv_serverlist.Items[0].SubItems[2].Bounds.Height);
            lv_serverlist.Items[0].Selected = true;
            lv_serverlist.Select();

            GetInitServerStatus();
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
        }

        /// <summary>
        /// 更新服务器状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateServerStatus(object sender, EventArgs e) {
            try
            {
                selectedServer = lv_serverlist.SelectedIndices[0];

                int index = selectedServer;
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
            catch (Exception) {
                MessageBox.Show("更新服务器状态失败，请重试。", "更新服务器状态");
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
                string absPath = @"C:\Users\User\Desktop\微端1.6\asktao.mod";
#else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
#endif
                string CommandLine = Properties.Resources.asktao_des;

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
                    bool status = false;
                    await Task.Factory.StartNew(() =>
                    {
                        status = HandleStartGame.StartProcessByCmd(server);
                    });

                    if (status)
                    {
                        btn_start_game.Enabled = false;
                        btn_register.Enabled = false;
                        btn_about.Enabled = false;
                        lb_startGameStatus.Visible = true;

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
                    }

                }

            }
            catch (Exception)
            {
                ATGateUtil.HandleDotNetException();
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
                Register register = new Register(server);
                register.Text = server.Name + " - 注册账号";
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
    }
}
