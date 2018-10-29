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

        public DBConnect(string server_ip, string database) {
            this.server_ip = server_ip;
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
                        MessageBox.Show("[DC1]\n数据库未连接，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "数据库未连接");
                        break;

                    case 1045:
                        MessageBox.Show("[DC2]\n数据库验证失败，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "数据库未连接");
                        break;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("[DC3]\n发生异常，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\n Server: " + server_ip + "\n e: " + e.GetType(), "发生异常");
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
                MessageBox.Show("[DC4]\n发生异常，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip + "\ne: " + e.GetType(), "发生异常");
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
                            MessageBox.Show("[DC5]\n数据库未连接，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "数据库未连接");
                            break;

                        case 1062:
                            MessageBox.Show("[DC6]\n用户名已注册，任何问题请联系管理员。QQ:" + Properties.Resources.admin_qq + "\nServer: " + server_ip, "用户名已注册");
                            break;
                        default:
                            MessageBox.Show("[DC7]\n注册失败，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "注册失败");
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
                            MessageBox.Show("[DC8]\n数据库未连接，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "数据库未连接");
                            break;
                        default:
                            Console.WriteLine(ex.Message);
                            MessageBox.Show("[DC9]\n更改失败，请联系管理员。QQ:" + Properties.Resources.tech_qq + "\nServer: " + server_ip, "更改失败");
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
