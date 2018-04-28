using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            Check_server_status();
        }

        private void Btn_start_game_Click(object sender, EventArgs e)
        {
            #if DEBUG
                string absPath = @"C:\Users\User\Desktop\微端1.6\asktao.mod";
            #else
                string absPath = @Directory.GetCurrentDirectory() + "/asktao.mod";
            #endif
            string CommandLine = "des:1B8E503A3BEFF909F50D908D6D53EEC26F10C662A39AC98425BFA4218DDBE81C4C196C772872AD4D4FA5C505CAC3E8D3948F59491F059B19D31CBC09FD257696D5CE934F044323E501C14D98F424DAD7233839407A1872FB";


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
                StartProcessSimplify(absPath, CommandLine);
                //StartProcessTraditional(absPath, CommandLine);
            }
        }

        private void StartProcessSimplify(string absPath, string cmd)
        {
            STARTUPINFO si = new STARTUPINFO();
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            bool status = CreateProcess(
                absPath, 
                cmd, 
                IntPtr.Zero, 
                IntPtr.Zero, 
                false, 
                0, 
                IntPtr.Zero,
                Path.GetDirectoryName(absPath), 
                ref si, 
                out pi);

            if (status)
            {
                Console.WriteLine("Game Started, Ending Launcher.");
                Application.Exit();
            }
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }


        private void Btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog(this);
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

        private void Check_server_status()
        {
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
            #if DEBUG
            btn_start_game.Enabled = true;
            #else
            btn_start_game.Enabled = online;
            #endif
        }

        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            ref STARTUPINFO lpStartupInfo,
            out PROCESS_INFORMATION lpProcessInformation);


        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }



        public struct SECURITY_ATTRIBUTES
        {
            public int length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }


    }
}
