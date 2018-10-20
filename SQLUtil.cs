using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            return statement;
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
    }
}
