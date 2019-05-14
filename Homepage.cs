using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDBMerger
{
    public partial class Homepage : Form
    {
        private const string TAG = "Homepage";
        private const string cache = "./缓存";
        private Logger logger;

        private Server serverA;
        private Server serverB;

        private MySqlConnection conAA;
        private MySqlConnection conAD;
        private MySqlConnection conBA;
        private MySqlConnection conBD;

        private DBWrapper dBWrapperA;
        private DBWrapper dBWrapperB;

        public Homepage(Logger logger)
        {
            this.logger = logger;
            logger.Log(TAG, "Init: Logger attached to Homepage");
            InitializeComponent();
        }

        private void ToggleDatabaseConfigFields(bool enable) {
            //Tb_db_a_ip.Enabled = enable;
            //Tb_db_a_port.Enabled = enable;
            //Tb_db_a_login.Enabled = enable;
            //Tb_db_a_password.Enabled = enable;
            //Tb_db_a_adb.Enabled = enable;
            //Tb_db_a_ddb.Enabled = enable;

            //Tb_db_b_ip.Enabled = enable;
            //Tb_db_b_port.Enabled = enable;
            //Tb_db_b_login.Enabled = enable;
            //Tb_db_b_password.Enabled = enable;
            //Tb_db_b_adb.Enabled = enable;
            //Tb_db_b_ddb.Enabled = enable;
            Tlp_database_config.Enabled = enable;
            logger.Log(TAG, "Tlp_database_config: "+enable);
        }

        private void ToggleDatabasePrepareStageFields(bool enable)
        {
            Gb_db_prepare.Enabled = enable;
            logger.Log(TAG, "Gb_db_prepare: " + enable);
        }
        
        private void ToggleDatabaseMergeStageFields(bool enable)
        {
            Gb_db_merge.Enabled = enable;
            logger.Log(TAG, "Gb_db_merge: " + enable);
        }

        private void Btn_db_config_connect_Click(object sender, EventArgs e)
        {
            logger.Log(TAG, "Btn_db_config_connect_Click");
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

            conAA = new MySqlConnection(serverA.getDBConnectionString("adb"));
            conAD = new MySqlConnection(serverA.getDBConnectionString("ddb"));
            conBA = new MySqlConnection(serverA.getDBConnectionString("adb"));
            conBD = new MySqlConnection(serverA.getDBConnectionString("ddb"));

            //ToggleDatabaseConnections(true);

            Btn_db_config_connect.Enabled = false;
            Btn_db_config_disconnect.Enabled = true;
            ToggleDatabasePrepareStageFields(true);

            //new Thread(() =>
            //{
            //    Thread.CurrentThread.IsBackground = true;

                

            //    dBWrapperA = new DBWrapper(serverA, cache);
            //    dBWrapperB = new DBWrapper(serverB, cache);

            //    var connectTestA = dBWrapperA.TestConnection();
            //    var connectTestB = dBWrapperB.TestConnection();

            //    logger.Log(TAG, "Btn_db_config_connect_Click: 数据库A: " + connectTestA + "数据库B: " + connectTestB);

            //    if (connectTestA && connectTestB)
            //    {
            //        Invoke((MethodInvoker)delegate {        
            //            if (MessageBox.Show("数据库A: " + connectTestA + "\n数据库B: " + connectTestB, "数据库连接成功") == DialogResult.OK)
            //            {
            //                Btn_db_config_connect.Enabled = false;
            //                Btn_db_config_disconnect.Enabled = true;
            //                ToggleDatabasePrepareStageFields(true);
            //            }
            //        });
            //    }
            //    else
            //    {
            //        Invoke((MethodInvoker)delegate {
            //            if (MessageBox.Show("数据库A: " + connectTestA + "\n数据库B: " + connectTestB, "数据库连接失败") == DialogResult.OK)
            //            {
            //                Btn_db_config_connect.Enabled = true;
            //                Btn_db_config_disconnect.Enabled = false;
            //                ToggleDatabaseConfigFields(true);
            //                ToggleDatabasePrepareStageFields(false);
            //            }
            //        });
            //    }
            //}).Start();

        }

        private bool ToggleDatabaseConnections(bool enable)
        {
            try
            {
                if (enable)
                {
                    conAA.OpenAsync();
                    conAD.OpenAsync();
                    conBA.OpenAsync();
                    conBD.OpenAsync();
                }
                else
                {
                    conAA.CloseAsync();
                    conAD.CloseAsync();
                    conBA.CloseAsync();
                    conBD.CloseAsync();
                }
                return true;
            }
            catch (Exception)
            {
                
            }
            return false;
        }

        private void Btn_db_config_disconnect_Click(object sender, EventArgs e)
        {
            logger.Log(TAG, "Btn_db_config_disconnect_Click");
            ToggleDatabaseConfigFields(true);
            ToggleDatabasePrepareStageFields(false);
            ToggleDatabaseMergeStageFields(false);
            //clear cached files
        }

        private void Btn_download_db_b_Click(object sender, EventArgs e)
        {
            try
            {
                Btn_download_db_b.Enabled = false;

                if (!Directory.Exists(cache))
                {
                    Directory.CreateDirectory(cache);
                }

                //download database b 
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading all database b tables");
                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading account table");
                    //Invoke((MethodInvoker)delegate {
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 开始下载数据库B\n");
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 下载account表\n");
                    //});
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conBA;
                            cmd.Connection.Open();
                            mb.ExportInfo.ExportTableStructure = false;
                            mb.ExportInfo.TablesToBeExportedList = new List<string> {
                                "account"
                            };
                            mb.ExportToFile(cache + "/b_adb.sql");
                            cmd.Connection.Close();
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conBD;
                            cmd.Connection.Open();
                            mb.ExportInfo.ExportTableStructure = false;
                            mb.ExportInfo.TablesToBeExportedList = new List<string> {
                                "data",
                                "basic_char_info",
                                "gid_info",
                                "property_recall"
                            };
                            mb.ExportToFile(cache + "/b_ddb.sql");
                            cmd.Connection.Close();
                        }
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        Btn_prepare_db_b_data.Enabled = true;
                    });
                    //dBWrapperB.DownloadTable(serverB.RegisterDbSchema, "");

                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading data table");
                    //Invoke((MethodInvoker)delegate {
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 下载data表\n");
                    //});
                    //dBWrapperB.DownloadTable(serverB.DataSchema, "data");

                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading basic_char_info table");
                    //Invoke((MethodInvoker)delegate {
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 下载basic_char_info表\n");
                    //});
                    //dBWrapperB.DownloadTable(serverB.DataSchema, "basic_char_info");

                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading gid_info table");
                    //Invoke((MethodInvoker)delegate {
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 下载gid_info表\n");
                    //});
                    //dBWrapperB.DownloadTable(serverB.DataSchema, "gid_info");

                    //logger.Log(TAG, "Btn_download_db_b_Click: Start downloading property_recall table");
                    //Invoke((MethodInvoker)delegate {
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 下载property_recall表\n");
                    //    Tb_prepare_output.AppendText(DateTime.Now + " 完成下载\n");
                    //});
                    //dBWrapperB.DownloadTable(serverB.DataSchema, "property_recall");
                    //logger.Log(TAG, "Btn_download_db_b_Click: database b table download complete");

                }).Start();
                
                //retrieve database infos
                //logger.Log(TAG, "Btn_download_db_b_Click: Getting all database values");
                //Task task1 = Task.Factory.StartNew(() => dBWrapperB.DownloadTable(serverB.RegisterDbSchema, "accounts"));
                //Task.WaitAll(task1, task2, task3, task4, task5);
                //logger.Log(TAG, "Btn_download_db_b_Click: Values retrival completed");

                //enable controls
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
