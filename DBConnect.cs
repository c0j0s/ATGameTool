﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace ATGate
{

    class DBConnect
    {
        private MySqlConnection connection;

        public DBConnect(string server_ip, string database) {

            string connectionString;
            connectionString = "SERVER=" + server_ip + ";" + "DATABASE=" +
            database + ";" + "UID=" + Properties.Resources.db_uid + ";" + "PASSWORD=" + Properties.Resources.db_passwd + ";";
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
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("数据库未连接，请联系管理员。QQ:" + Properties.Resources.admin_qq);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

            }
            catch (Exception)
            {
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
                    switch (ex.Number)
                    {
                        case 1062:
                            MessageBox.Show("用户名已注册！");
                            break;
                        default:
                            MessageBox.Show("注册失败，请联系管理员。QQ:" + Properties.Resources.admin_qq);
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
