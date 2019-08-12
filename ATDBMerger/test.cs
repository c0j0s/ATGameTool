using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ATDBMerger
{
    class test
    {
        static void Main(string[] args) {
            Application.Run(new EncryptionTesting());
        }
        public static Tuple<string, string> EncryptPassword(string account, int privilieges, string gold, string silver)
        {
            string password = Properties.Resources.password;
            string encytPass, checksum;

            byte[] result = Encoding.Default.GetBytes(password.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-", "").ToUpper();

            encytPass = account + encytPass + "20070201";

            result = Encoding.Default.GetBytes(encytPass);
            output = md5.ComputeHash(result);
            encytPass = BitConverter.ToString(output).Replace("-", "").ToUpper();

            checksum = string.Format("{0}{1}{2,8:X8}{3}{4,8:X8}{5,8:X8}{6}{7}{8}{9}{10}ABCDEF", account, encytPass, privilieges, "", Int32.Parse(gold), Int32.Parse(silver), "", "", "", "", "");

            result = Encoding.Default.GetBytes(checksum);
            output = md5.ComputeHash(result);
            checksum = BitConverter.ToString(output).Replace("-", "").ToUpper();

            Tuple<string, string> encrypt = new Tuple<string, string>(encytPass, checksum);

            return encrypt;
        }

    }
}
