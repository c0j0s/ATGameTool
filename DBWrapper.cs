using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    class DBWrapper
    {
        private DBConnect db;
        private string server_ip = "";

        public DBWrapper(string server_ip, string schema) {
            if (schema.Equals("default"))
            {
                db = new DBConnect(server_ip,"dl_adb_all");
            }
            else if (schema.Equals("launcher"))
            {
                db = new DBConnect(server_ip,"launcher");
            }
            this.server_ip = server_ip;
        }

        /// <summary>
        /// 检查注册限制
        /// </summary>
        /// <param name="macAddr">MAC地址</param>
        /// <returns>真/假</returns>
        public bool CheckIfMacRegisterLimitExceeds(string macAddr)
        {
            try
            {
                int registerLimit = Int32.Parse((Properties.Resources.registerLimit.Equals("")) ? "5" : Properties.Resources.registerLimit);

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
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<bool> CreateAccountWithMacVerificationAsync(string username, string password)
        {
            bool regStatus = false;
            var macAddr = ATGateUtil.GetMacAddr();
            try
            {
                if (!CheckIfMacRegisterLimitExceeds(macAddr))
                {
                    if (CreateAccount(username, password, macAddr))
                    {
                        MessageBox.Show("注册成功！");
                        regStatus = true;
                    }
                }
                else
                {
                    MessageBox.Show("[DW1]\n该电脑已超过注册数限制，请联系管理员。QQ:" + Properties.Resources.tech_qq + " \nServer: " + server_ip + "\nPC: " + macAddr, "超过注册数限制");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("数据库未连接 Server: " + server_ip);
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
    }
}
