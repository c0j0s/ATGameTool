using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace ATDBMerger
{

    public class DBConnect
    {
        private MySqlConnection connection;
        private Server server;
        private string activeSchema;
        //private string server_ip_display = "";

        public DBConnect(Server server, String schema) {
            this.server = server;
            activeSchema = schema;
            //server_ip_display = server.getRegisterIp().Split('.')[2] + "." + server.getRegisterIp().Split('.')[3];
            string connectionString;
            connectionString = "SERVER=" + server.getRegisterIp() + ";" + "DATABASE=" +
            schema + ";" + "UID=" + server.DbLogin + ";" + "PASSWORD=" + server.DbPassword + ";";
            connection = new MySqlConnection(connectionString);
            Console.WriteLine(connectionString);
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <returns>真/假</returns>
        internal bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //new MsgBox("[DC1]", "服务器未连接", "服务器未连接，请联系管理员。", server_ip_display).ShowDialog();
                        break;

                    case 1045:
                        //new MsgBox("[DC2]", "服务器未连接", "服务器验证失败，请联系管理员。", server_ip_display).ShowDialog();
                        break;

                    default:
                        //new MsgBox("[DC2.1]", "服务器未连接", "无法连接服务器，请联系管理员。", server_ip_display).ShowDialog();
                        break;
                }

            }
            catch (Exception)
            {
                //new MsgBox("[DC3]", "发生异常", "发生异常", server_ip_display).ShowDialog();
            }
            return false;
        }


        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <returns>真/假</returns>
        internal bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection Closed");
                return true;
            }
            catch (MySqlException e)
            {
                //new MsgBox("[DC4]", "发生异常", "发生异常\ne: " + e.GetType(), server_ip_display).ShowDialog();
                return false;
            }
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns>数字</returns>
        internal int Insert(string statement)
        {
            //Open connection
            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(statement, connection);
                int status = 0;
                try
                {
                    status = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    switch (ex.Number)
                    {
                        case 0:
                            //new MsgBox("[DC5]", "服务器未连接", "服务器未连接，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                        case 1062:
                            //new MsgBox("[DC6]", "用户名已注册", "用户名已注册，请使用其他名称。", server_ip_display).ShowDialog();
                            break;
                        default:
                            //new MsgBox("[DC7]", "注册失败", "注册失败，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                    }
                }
                CloseConnection();
                return status;
            }
            else
            {
                return 0;
            }
        }

        internal int Update(string statement)
        {
            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(statement, connection);
                int status = 0;
                try
                {
                    status = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    switch (ex.Number)
                    {
                        case 0:
                            //new MsgBox("[DC8]", "服务器未连接", "服务器未连接，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                        default:
                            Console.WriteLine(ex.Message);
                            //new MsgBox("[DC9]", "更改失败", "更改失败，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                    }
                }
                CloseConnection();
                return status;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 写入数据
        /// 无错误提示
        /// </summary>
        /// <param name="value"></param>
        /// <returns>数字</returns>
        internal int InsertNoException(string statement)
        {
            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(statement, connection);
                int status = 0;
                try
                {
                    status = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                CloseConnection();
                return status;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns>数据表</returns>
        internal DataTable Select(string query)
        {
            DataTable dt = new DataTable();

            if (OpenConnection())
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            else
            {
                throw new Exception();
            }
        }

        internal void ExportTable(string table, string saveToFile) {
            
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = connection;
                    OpenConnection();
                    mb.ExportInfo.ExportTableStructure = false;
                    mb.ExportInfo.RowsExportMode = RowsDataExportMode.Insert;
                    mb.ExportInfo.TablesToBeExportedList = new List<string> {
                        table
                    };
                    
                    mb.ExportToFile(saveToFile);
                    CloseConnection();
                }
            }
            
        }

    }
}
