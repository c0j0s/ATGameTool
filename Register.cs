using System;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATGate
{
    public partial class Register : Form
    {

        bool regStatus = false;

        public Register()
        {
            InitializeComponent();
        }

        public bool RegStatus { get => regStatus; set => regStatus = value; }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (!username.Equals("") && !password.Equals("")) //field not empty
            {
                //check username duplication
                DBWrapper dw = new DBWrapper();
                if (password.Length > 3) //password length > 3
                {

                    var macAddr =
                    (
                        from nic in NetworkInterface.GetAllNetworkInterfaces()
                        where nic.OperationalStatus == OperationalStatus.Up
                        select nic.GetPhysicalAddress().ToString()
                    ).FirstOrDefault();

                    macAddr = macAddr.PadLeft(16, '0');

                    if (!dw.CheckIfMacRegisterLimitExceeds(macAddr))
                    {
                        if (dw.CreateAccount(username,password,macAddr))
                        {
                            MessageBox.Show("注册成功！");
                            regStatus = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("该电脑已超过注册数限制，请联系管理员。QQ:1097808560");
                    }
                }
                else
                {
                    MessageBox.Show("密码过短。");
                }
                //MessageBox.Show("用户名已存在！");
                
            }
            else
            {
                MessageBox.Show("请输入用户名与密码。");
            }

            if (RegStatus)
            {
                this.Close();
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
