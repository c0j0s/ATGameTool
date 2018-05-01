using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace ATGate
{

    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string uid;
        private string password;

        public DBConnect(string database) {

            server = "47.106.10.242";
            uid = "root";
            password = "Jbc@database";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Program.LogException(ex);
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("数据库未连接，请联系管理员。QQ:1097808560");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

            }
            catch (Exception e)
            {
                Program.LogException(e);
                MessageBox.Show("发生错误，请重试。");
            }
            return false;
        }
    

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection Closed");
                return true;
            }
            catch (MySqlException ex)
            {
                Program.LogException(ex);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public int Insert(string value)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(value, connection);
                int status = 0;
                try
                {
                    status = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Program.LogException(ex);
                    switch (ex.Number)
                    {
                        case 1062:
                            MessageBox.Show("用户名已注册！");
                            break;
                        default:
                            MessageBox.Show("注册失败，请联系管理员。QQ:1097808560");
                            break;
                    }
                }
                this.CloseConnection();
                return status;
            }
            else
            {
                return 0;
            }
        }

        public int InsertNoException(string value)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(value, connection);
                int status = 0;
                try
                {
                    status = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.CloseConnection();
                return status;
            }
            else
            {
                return 0;
            }
        }

        //Update statement
        public void Update()
        {

        }

        //Delete statement
        public void Delete()
        {

        }

        //Select statement
        public DataTable Select(string query)
        {
            DataTable dt = new DataTable();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                this.CloseConnection();
                return dt;
            }
            else
            {
                return dt;
            }
        }

    }
}
