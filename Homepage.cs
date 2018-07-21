using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Homepage : Form
    {
        private Button serverRefreashBtn = new Button();
        private int selectedServer;
        private List<Server> serverList = new List<Server> {
            new Server("问道二区","47.88.175.74"),
            new Server("问道一区","112.74.183.7"),
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

        private async void UpdateServerStatus(object sender, EventArgs e) {
            selectedServer = lv_serverlist.SelectedIndices[0];

            int index = selectedServer;
            await Task.Factory.StartNew(() =>
            {
                Tuple<bool,string> tuple = ATGateUtil.CheckServerStatus(serverList[index].Ip);
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

        private async void Btn_start_game_Click(object sender, EventArgs e)
        {
            #if DEBUG
                string absPath = @"C:\Users\User\Desktop\微端1.6\asktao.mod";
            #else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
            #endif
                string CommandLine = Properties.Resources.asktao_des;

            if (!CheckServerStatus()) {
                return;
            }
            Console.WriteLine("Starting Game" + selectedServer);
            Server server = serverList[selectedServer];

            if (!File.Exists(absPath))
            {
                ATGateUtil.HandleGameNotFound();
            }
            else
            {
                bool status = false;
                
                //if (Environment.OSVersion.Version.Major.Equals(5))
                //{
                    await Task.Factory.StartNew(() =>
                    {
                        status = HandleStartGame.StartProcessByCmd(server);
                    });
                //}
                //else 
                //{
                //    await Task.Factory.StartNew(() =>
                //    {
                //        status = HandleStartGame.StartProcessSimplify(absPath, CommandLine);
                //    });
                //}

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
                else {
                    btn_start_game.Enabled = true;
                    btn_register.Enabled = true;
                    btn_about.Enabled = true;
                    lb_startGameStatus.Visible = false;
                }

            }
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void Btn_register_Click(object sender, EventArgs e)
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

        private void lb_serverlist_title_Click(object sender, EventArgs e)
        {

        }

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
