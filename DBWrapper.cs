using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace ATGate
{
    class DBWrapper
    {
        DBConnect db;
        public DBWrapper() {
            db = new DBConnect();
        }

        //Not needed
        public bool CheckIfAccountExist(string account) {
            
            DataTable dt = db.Select("SELECT * from account where account = \"" + account + "\";");
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckIfMacRegisterLimitExceeds(string macAddr)
        {

            DataTable dt = db.Select("SELECT first_login_mac from account where first_login_mac = \"" + macAddr + "\";");
            if (dt.Rows.Count > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateAccount(string account, string password,string macAddr)
        {
            string encytPass, checksum;
            string privilege = "0";
            String timeStamp = DateTime.Now.ToString();

            Tuple<string,string> encrypt = EncryptPassword(account,password);
            encytPass = encrypt.Item1;
            checksum = encrypt.Item2;

            string statement = 
                "INSERT INTO account " +
                " VALUES " +
                "('"+ account +"', '', '', '', '', " +
                "'"+ encytPass + "', '', '0', '', '10000000', " +
                "'0', '0', '', '', '', " +
                "'', '', '', '', '', " +
                "'0', '', '', '"+ macAddr +"', '"+ privilege +"', " +
                "'', '', '', '', '1', " +
                "'"+ checksum +"', '', '', '', '', " +
                "'', '', '', '0', '', " +
                "'0', '0', '', '', '', " +
                "'"+ timeStamp + "', '');";

            if (db.Insert(statement) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Tuple<string, string> EncryptPassword(string account,string password) {
            string encytPass, checksum;

            byte[] result = Encoding.Default.GetBytes(password.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-", "").ToUpper();

            encytPass = account + encytPass + "20070201";

            result = Encoding.Default.GetBytes(encytPass);
            output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-","").ToUpper();

            checksum = string.Format("{0}{1}{2,8:X8}" + "{3}{4,8:X8}{5,8:X8}" + "{6}{7}{8}" + "{9}{10}" + "ABCDEF",account,encytPass,0,"",10000000,0,"","","","","");

            result = Encoding.Default.GetBytes(checksum);
            output = md5.ComputeHash(result);
            checksum = BitConverter.ToString(output).Replace("-", "").ToUpper();

            Tuple<string, string> encrypt = new Tuple<string, string>(encytPass,checksum);

            return encrypt;
        }
    }
}
