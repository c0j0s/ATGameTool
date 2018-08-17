using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Register : Form
    {
        private string server_ip;
        Task<bool> regStatus;

        public Register(Server server)
        {
            InitializeComponent();
            server_ip = server.Ip;
        }

        /// <summary>
        /// 注册账号按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);

                string username = tb_username.Text;
                string password = tb_password.Text;

                if (!username.Equals("") && !password.Equals("")) //field not empty
                {
                    if (password.Length > 3) //password length > 3
                    {
                        DBWrapper dw = new DBWrapper(server_ip, "default");
                        regStatus = await Task.Factory.StartNew(() => dw.CreateAccountWithMacVerificationAsync(username, password));
                    }
                    else
                    {
                        MessageBox.Show("密码过短。");
                        EnableControls(true);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("请输入用户名与密码。");
                    EnableControls(true);
                    return;
                }

                if (regStatus.Result)
                {
                    this.Close();
                }
                else
                {
                    EnableControls(true);
                }
            }
            catch (System.IO.FileLoadException)
            {
                ATGateUtil.HandleDotNetException();
            }
            catch (NullReferenceException) {
                MessageBox.Show("无法注册请重试");
                this.Close();
            }
        }

        /// <summary>
        /// 开关输入框
        /// </summary>
        /// <param name="enable">真/假</param>
        private void EnableControls(bool enable) {
            if (enable)
            {
                btn_register.Enabled = true;
                btn_register.UseWaitCursor = false;
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                btn_register.Text = "注册";
            }
            else
            {
                btn_register.Enabled = false;
                btn_register.UseWaitCursor = true;
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                btn_register.Text = "注册中";
            }
        }

        private void Tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-z^A-Z^0-9]"))
                {
                    // Stop the character from being entered into the control since it is illegal.
                    e.Handled = true;
                }
            }
        }

        private void Tb_username_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show(@"只允许字母与数字", (TextBox)sender, 0, 23, 3000);
        }

        private void Tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-z^A-Z^0-9^+^@^/^*]"))
                {
                    e.Handled = true;
                }
            }

        }

        private void Tb_password_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show(@"只允许字母,数字以及 + @ * / 等符号", (TextBox)sender, 0, 23, 3000);
        }

    }
}
