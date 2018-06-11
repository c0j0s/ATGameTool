using System;
using System.Collections.Generic;
using System.IO;
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
            bool status = ATGateUtil.CheckServerStatus();
            Change_server_status_light(status);
            //GetNoticeBoard();
        }

        private void GetNoticeBoard()
        {
            List<string> items = new List<string>();
            items.Add("hi");
            lb_notice_board.DataSource = items;
        }

        private async void Btn_start_game_Click(object sender, EventArgs e)
        {
            #if DEBUG
                string absPath = @"C:\Users\User\Desktop\微端1.6\asktao.mod";
            #else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
            #endif
                string CommandLine = Properties.Resources.asktao_des;


            if (!File.Exists(absPath))
            {
                ATGateUtil.HandleGameNotFound();
            }
            else
            {
                bool status = false;
                
                if (Environment.OSVersion.Version.Major.Equals(5))
                {
                    await Task.Factory.StartNew(() =>
                    {
                        status = HandleStartGame.StartProcessByCmd();
                    });
                }
                else 
                {
                    await Task.Factory.StartNew(() =>
                    {
                        status = HandleStartGame.StartProcessSimplify(absPath, CommandLine);
                    });
                }

                if (status)
                {
                    btn_start_game.Enabled = false;
                    btn_register.Enabled = false;
                    btn_about.Enabled = false;
                    lb_startGameStatus.Visible = true;
                    server_status.Enabled = false;

                    await Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("Game Started, Ending Launcher.");
                        Environment.Exit(0);
                    });
                }
                else {
                    server_status.Enabled = true;
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
            Register register = new Register();
            register.ShowDialog(this);
        }

        private async void Server_status_Click(object sender, EventArgs e)
        {
            bool status = false;
            await Task.Factory.StartNew(() => {
                status = ATGateUtil.CheckServerStatus();
             });
            Console.WriteLine(status);
            Change_server_status_light(status);
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
                ToolTip tt = new ToolTip();
                tt.SetToolTip(server_status, "点击此处可更新状态");
            }
#if DEBUG
            btn_start_game.Enabled = true;
            btn_register.Enabled = true;
#else
            btn_start_game.Enabled = online;
            btn_register.Enabled = online;
#endif
        }

    }
}
