using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ATDBMerger
{
    class SQLUtil
    {
        public static List<KeyValuePair<string, string>> OpenSqlFile(string sqlPath, string tableName)
        {
            List<KeyValuePair<string, string>> List = new List<KeyValuePair<string, string>>();

            using (StreamReader inputReader = new StreamReader(sqlPath, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    if (MatchLines(line, tableName))
                    {
                        List.Add(new KeyValuePair<string, string>(tableName, line));
                    }
                }
                return List;
            }
        }

        public static string ReadSqlFile(string sqlPath, string tableName)
        {
            String text = "";

            using (StreamReader inputReader = new StreamReader(sqlPath, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    if (MatchLines(line, tableName))
                    {
                        text += line + "\n";
                    }
                }
                return text;
            }
        }

        private static bool MatchLines(String line, String tableName)
        {
            if (line.StartsWith("INSERT INTO `" + tableName + "` VALUES"))
            {
                try
                {
                    return true;
                }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
            return false;
        }

        public static string GetInsertId(string statement){
            statement = statement.Remove(0, statement.IndexOf("(") + 1).Split(',')[0].Replace("'", "");
            return statement;
        }

        public static string GetSQLValue(string statement,int index)
        {
            statement = statement.Remove(0, statement.IndexOf("(") + 1).Split(',')[index].Replace("'", "");
            return statement.Replace(" ", "");
        }

        internal static bool DataKeyDuplicate(string input, string compared)
        {
            string[] inputArr = input.Remove(0, input.IndexOf("(") + 1).Split(',');
            string[] comparedArr = compared.Remove(0, compared.IndexOf("(") + 1).Split(',');

            //compare primary key
            if (!inputArr[0].Equals(comparedArr[0])) {
                return false;
            }

            //compare second key
            if (!inputArr[1].Equals(comparedArr[1]))
            {
                return false;
            }
            //compare second key
            if (!inputArr[2].Equals(comparedArr[2]))
            {
                return false;
            }
            return true;
        }

        public static string GenerateNewAccountInfo(string statement)
        {
            string accountid = GetInsertId(statement);
            string newAccountId = accountid + Properties.Resources.suffix;
            string encryptpass = GetSQLValue(statement, 5);
            string gold = GetSQLValue(statement, 9);
            string silver = GetSQLValue(statement, 10);

            string pre = GetSQLValue(statement, 24);

            Tuple<string, string> encrypt = EncryptPassword(newAccountId, pre, gold, silver);

            string oldChecksum = GetSQLValue(statement, 30);
            string newChecksum = encrypt.Item2;
            string newencryptpass = encrypt.Item1;
            statement = statement.Replace(accountid, newAccountId);
            statement = statement.Replace(encryptpass, newencryptpass);
            string newStatement = statement.Replace(oldChecksum, newChecksum);
            return newStatement;
        }

        public static Tuple<string, string> EncryptPassword(string account, string privilieges, string gold, string silver)
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

            checksum = string.Format("{0}{1}{2,8:X8}{3}{4,8:X8}{5,8:X8}{6}{7}{8}{9}{10}ABCDEF", account, encytPass, Int32.Parse(privilieges), "", Int32.Parse(gold), Int32.Parse(silver), "", "", "", "", "");

            result = Encoding.Default.GetBytes(checksum);
            output = md5.ComputeHash(result);
            checksum = BitConverter.ToString(output).Replace("-", "").ToUpper();

            Tuple<string, string> encrypt = new Tuple<string, string>(encytPass, checksum);

            return encrypt;
        }
    }
}
