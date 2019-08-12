using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Register : Form
    {
        private Server server;
        private bool allChangePass = true;
        Task<bool> regStatus;

        public Register(Server server)
        {
            InitializeComponent();
            this.server = server;
            if (Properties.Resources.allow_change_pass.Equals("0"))
            {
                allChangePass = false;
                btn_change_pass.Visible = false;
                tb_id_code.Enabled = false;
                tb_id_code.Text = "不适用";
                tb_id_code.Visible = false;
                lb_veri_code_2.Visible = false;
                lb_veri_code_1.Visible = false;
                this.Size = new Size(325, 300);
            }
            lb_limit_info.Text = "一台电脑不可注册超过"+ Properties.Resources.registerLimit + "个账号";
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
                string idCode = tb_id_code.Text;

                if (!username.Equals("") && !password.Equals("") && !idCode.Equals("")) //确保用户名和密码必填
                {
                    if (password.Length > int.Parse(Properties.Resources.passwd_min)) //确保密码长度 > 3
                    {
                        DBWrapper dw = new DBWrapper(server.getRegisterIp(), server.RegisterDbSchema);
                        regStatus = await Task.Factory.StartNew(() => dw.CreateAccountWithMacVerificationAsync(username, password, idCode));
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
                    MessageBox.Show("请输入用户名, 密码与验证码。");
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
                new MsgBox("[R1]", "注册失败", "无法注册请重试。").ShowDialog();
                this.Close();
            }
        }

        private async void btn_change_pass_Click(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);

                string username = tb_username.Text;
                string newPassword = tb_password.Text;
                string idCode = tb_id_code.Text;

                if (!username.Equals("") && !newPassword.Equals("") && !idCode.Equals("")) //确保用户名和密码必填
                {
                    if (newPassword.Length > int.Parse(Properties.Resources.passwd_min)) //确保密码长度 > 3
                    {
                        DBWrapper dw = new DBWrapper(server.getRegisterIp(), server.RegisterDbSchema);
                        regStatus = await Task.Factory.StartNew(() => dw.ResetAccountPasswordWithIdCode(username, newPassword, idCode));
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
                    MessageBox.Show("请输入用户名, 新密码与验证码。");
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
            catch (NullReferenceException)
            {
                new MsgBox("[R2]", "更改失败", "无法更改请重试。").ShowDialog();
                Close();
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
                btn_change_pass.Enabled = true;
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                tb_id_code.Enabled = allChangePass;
            }
            else
            {
                btn_register.Enabled = false;
                btn_register.UseWaitCursor = true;
                btn_change_pass.Enabled = false;
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                tb_id_code.Enabled = false;
            }
        }

        private void Tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-z^A-Z^0-9]"))
                {
                    e.Handled = true;
                }
            }
        }

        private void Tb_username_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show(@"只允许字母与数字", (TextBox)sender, 0, 31, 3000);
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
            tt.Show(@"只允许字母,数字以及 + @ * / 等符号", (TextBox)sender, 0, 31, 3000);
        }

        
    }
}
