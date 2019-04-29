using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ATDBMerger
{
    public partial class Homepage : Form
    {
        private Logger logger;

        private Server serverA;
        private Server serverB;

        private DBWrapper dBWrapperA;
        private DBWrapper dBWrapperB;

        public Homepage(Logger logger)
        {
            this.logger = logger;
            InitializeComponent();
        }

        private void ToggleDatabaseConfigFields(bool enable) {
            Tb_db_a_ip.Enabled = enable;
            Tb_db_a_port.Enabled = enable;
            Tb_db_a_login.Enabled = enable;
            Tb_db_a_password.Enabled = enable;
            Tb_db_a_adb.Enabled = enable;
            Tb_db_a_ddb.Enabled = enable;

            Tb_db_b_ip.Enabled = enable;
            Tb_db_b_port.Enabled = enable;
            Tb_db_b_login.Enabled = enable;
            Tb_db_b_password.Enabled = enable;
            Tb_db_b_adb.Enabled = enable;
            Tb_db_b_ddb.Enabled = enable;
        }

        private void ToggleDatabasePrepareStageFields(bool enable)
        {
            
        }

        private void Btn_db_config_connect_Click(object sender, EventArgs e)
        {
            Btn_db_config_connect.Enabled = false;
            ToggleDatabaseConfigFields(false);

            serverA = new Server()
            {
                RegisterIp = Tb_db_a_ip.Text,
                Port = Tb_db_a_port.Text,
                DbLogin = Tb_db_a_login.Text,
                DbPassword = Tb_db_a_password.Text,
                RegisterDbSchema = Tb_db_a_adb.Text,
                DataSchema = Tb_db_a_ddb.Text,
            };

            serverB = new Server()
            {
                RegisterIp = Tb_db_b_ip.Text,
                Port = Tb_db_b_port.Text,
                DbLogin = Tb_db_b_login.Text,
                DbPassword = Tb_db_b_password.Text,
                RegisterDbSchema = Tb_db_b_adb.Text,
                DataSchema = Tb_db_b_ddb.Text,
            };

            new Thread(() =>
            {
                dBWrapperA = new DBWrapper(serverA);
                dBWrapperB = new DBWrapper(serverB);

                var connectTestA = dBWrapperA.TestConnection();
                var connectTestB = dBWrapperB.TestConnection();

                if (connectTestA && connectTestB)
                {
                    Invoke((MethodInvoker)delegate {
                        MessageBox.Show("数据库A: " + connectTestA + "\n数据库B: " + connectTestB, "数据库连接成功");
                        Btn_db_config_connect.Enabled = false;
                        Btn_db_config_disconnect.Enabled = true;
                        ToggleDatabasePrepareStageFields(true);
                    });
                }
                else
                {
                    Invoke((MethodInvoker)delegate {
                        MessageBox.Show("数据库A: " + connectTestA + "\n数据库B: " + connectTestB, "数据库连接失败");
                        Btn_db_config_connect.Enabled = true;
                        ToggleDatabaseConfigFields(true);
                    });
                }
            }).Start();

        }
    }
}
