using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace ATGate
{

    class DBConnect
    {
        private MySqlConnection connection;
        private string server_ip = "";
        private string server_ip_display = "";

        public DBConnect(string server_ip, string database) {
            this.server_ip = server_ip;
            server_ip_display = server_ip.Split('.')[2] + "." + server_ip.Split('.')[3];
            string connectionString;
            connectionString = "SERVER=" + server_ip + ";" + "DATABASE=" +
            database + ";" + "UID=" + Properties.Resources.db_uid + ";" + "PASSWORD=" + Properties.Resources.db_passwd + ";";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <returns>真/假</returns>
        private bool OpenConnection()
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
                        new MsgBox("[DC1]", "数据库未连接", "数据库未连接，请联系管理员。", server_ip_display).ShowDialog();
                        break;

                    case 1045:
                        new MsgBox("[DC2]", "数据库未连接", "数据库验证失败，请联系管理员。", server_ip_display).ShowDialog();
                        break;
                }

            }
            catch (Exception e)
            {
                new MsgBox("[DC3]", "发生异常", "发生异常", server_ip_display).ShowDialog();
            }
            return false;
        }


        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <returns>真/假</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection Closed");
                return true;
            }
            catch (MySqlException e)
            {
                new MsgBox("[DC4]", "发生异常", "发生异常\ne: " + e.GetType(), server_ip_display).ShowDialog();
                return false;
            }
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns>数字</returns>
        public int Insert(string statement)
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
                            new MsgBox("[DC5]", "数据库未连接", "数据库未连接，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                        case 1062:
                            new MsgBox("[DC6]", "用户名已注册", "用户名已注册，请使用其他名称。", server_ip_display).ShowDialog();
                            break;
                        default:
                            new MsgBox("[DC7]", "注册失败", "注册失败，请联系管理员。", server_ip_display).ShowDialog();
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
                            new MsgBox("[DC8]", "数据库未连接", "数据库未连接，请联系管理员。", server_ip_display).ShowDialog();
                            break;
                        default:
                            Console.WriteLine(ex.Message);
                            new MsgBox("[DC9]", "更改失败", "更改失败，请联系管理员。", server_ip_display).ShowDialog();
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
        public int InsertNoException(string statement)
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
        public DataTable Select(string query)
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

    }
}
