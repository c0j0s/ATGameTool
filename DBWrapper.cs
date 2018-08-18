using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    class DBWrapper
    {
        private DBConnect db;

        public DBWrapper(string server_ip, string schema) {
            if (schema.Equals("default"))
            {
                db = new DBConnect(server_ip,"dl_adb_all");
            }
            else if (schema.Equals("launcher"))
            {
                db = new DBConnect(server_ip,"launcher");
            }
        }

        /// <summary>
        /// 检查注册限制
        /// </summary>
        /// <param name="macAddr">MAC地址</param>
        /// <returns>真/假</returns>
        public bool CheckIfMacRegisterLimitExceeds(string macAddr)
        {
            int registerLimit = Int32.Parse((Properties.Resources.registerLimit.Equals(""))? "5": Properties.Resources.registerLimit);

            DataTable dt = db.Select("SELECT first_login_mac from account where first_login_mac = \"" + macAddr + "\";");
            if (dt.Rows.Count >= registerLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> CreateAccountWithMacVerificationAsync(string username, string password)
        {
            bool regStatus = false;
            var macAddr = ATGateUtil.GetMacAddr();

            if (!CheckIfMacRegisterLimitExceeds(macAddr))
            {
                if (CreateAccount(username, password, macAddr))
                {
                    MessageBox.Show("注册成功！");
                    //DBWrapper adw = new DBWrapper("launcher");
                    //await Task.Factory.StartNew(() => adw.RecordGameAccountCreated(username));
                    regStatus = true;
                }
            }
            else
            {
                MessageBox.Show("该电脑已超过注册数限制，请联系管理员。QQ:1097808560");
            }
            return regStatus;
        }

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="account">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="macAddr">MAC地址</param>
        /// <returns>真/假</returns>
        public bool CreateAccount(string account, string password,string macAddr)
        {
            string encytPass, checksum;
            string privilege = "0";
            String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"); ;

            string gold = (Properties.Resources.gold_amt.Equals("")) ? "0" : Properties.Resources.gold_amt;
            string silver = (Properties.Resources.silver_amt.Equals("")) ? "0" : Properties.Resources.silver_amt;

            Tuple<string,string> encrypt = EncryptPassword(account,password);
            encytPass = encrypt.Item1;
            checksum = encrypt.Item2;
            Console.WriteLine(checksum);
            string statement = 
                "INSERT INTO account " +
                " VALUES " +
                "('"+ account +"', '', '', '', '', " +
                "'"+ encytPass + "', '', '0', '', '"+ gold +"', " +
                "'"+ silver + "', '0', '', '', '', " +
                "'', '', '', '', '', " +
                "'0', '', '', '"+ macAddr +"', '"+ privilege +"', " +
                "'', '', '', '', '1', " +
                "'"+ checksum +"', '', '', '', '', " +
                "'', '', '', '0', '', " +
                "'0', '0', '', '0', '', " +
                "'"+ timeStamp + "', '');COMMIT;";
            Console.WriteLine(statement);
            if (db.Insert(statement) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="account">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public Tuple<string, string> EncryptPassword(string account,string password) {
            string encytPass, checksum;
            string gold = (Properties.Resources.gold_amt.Equals(""))? "0" : Properties.Resources.gold_amt;
            string silver = (Properties.Resources.silver_amt.Equals("")) ? "0" : Properties.Resources.silver_amt;

            byte[] result = Encoding.Default.GetBytes(password.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-", "").ToUpper();

            encytPass = account + encytPass + "20070201";

            result = Encoding.Default.GetBytes(encytPass);
            output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-","").ToUpper();

            checksum = string.Format("{0}{1}{2,8:X8}{3}{4,8:X8}{5,8:X8}{6}{7}{8}{9}{10}ABCDEF",account,encytPass,0,"",Int32.Parse(gold), Int32.Parse(silver),"","","","","");
            
            result = Encoding.Default.GetBytes(checksum);
            output = md5.ComputeHash(result);
            checksum = BitConverter.ToString(output).Replace("-", "").ToUpper();
            
            Tuple<string, string> encrypt = new Tuple<string, string>(encytPass,checksum);

            return encrypt;
        }

        //public void CreateAccountRecord(string timeTaken, int loginSuccess, string ipAddr, string macAddr, string launcherVersion) {

        //    string uuid = Guid.NewGuid().ToString().Replace("-", "");
        //    string statement = "INSERT into account values('"+ Program.qq +"','"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
        //    string loginLogStatement = "INSERT into login_log values('"+ uuid +"'," +
        //                                                            "'" + Program.qq + "'," + 
        //                                                            "'" + timeTaken +"'," +
        //                                                            "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',"+ 
        //                                                            "'" + loginSuccess + "'," +
        //                                                            "'" + launcherVersion + "'," +
        //                                                            "'" + ipAddr + "'," +
        //                                                            "'" + macAddr + "'" +
        //                                                            ");";
        //    Console.WriteLine(statement);
        //    Console.WriteLine(loginLogStatement);
        //    db.InsertNoException(loginLogStatement);
        //    db.InsertNoException(statement);
            
        //}

        //public bool UpdateAccountLog(string ipAddr, string macAddr, string launcherVersion)
        //{
        //    string uuid = Guid.NewGuid().ToString().Replace("-", "");
        //    string statement = "INSERT into log values(" +
        //                        "'" + uuid + "'," +
        //                        "'" + Program.qq + "'," +
        //                        "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
        //                        "'"+ launcherVersion +"'," +
        //                        "'"+ ipAddr +"'," +
        //                        "'"+ macAddr +"'" +
        //                        ");"; 

        //    Console.WriteLine(statement);

        //    if (db.InsertNoException(statement) != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool RecordGameAccountCreated(string account)
        //{
        //    string uuid = Guid.NewGuid().ToString().Replace("-", "");
        //    string statement = "INSERT into game_account_log values(" +
        //                        "'" + uuid + "'," +
        //                        "'" + Program.qq + "'," +
        //                        "'" + account + "'," +
        //                        "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
        //                        ")"; ;

        //    Console.WriteLine(statement);

        //    if (db.InsertNoException(statement) != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool SentHandleExceptionLog(string ipAddr, string macAddr, string launcherVersion,string message,string osVersion) {
        //    string uuid = Guid.NewGuid().ToString().Replace("-", "");
        //    string statement = "INSERT into launcher_exception_log values(" +
        //            "'" + uuid + "'," +
        //            "'" + Program.qq + "'," +
        //            "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
        //            "'" + launcherVersion + "'," +
        //            "'" + ipAddr + "'," +
        //            "'" + macAddr + "'," +
        //            "'" + message + "'," +
        //            "'" + osVersion + "'" +
        //            ")"; ;


        //    Console.WriteLine(statement);

        //    if (db.InsertNoException(statement) != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
