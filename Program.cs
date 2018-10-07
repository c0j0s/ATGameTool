using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ATDBMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("合区程序：任意键开始");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            //Output Folders
            CreateContainerFolders();

            Console.WriteLine("\n已创建文件夹，把SQL文件放入相应的文件夹内");

            Console.WriteLine("完成后任意键继续");
            Console.ReadKey();

            ReadFirstDatabase();
            ReadSecondDatabase();
            
            Console.WriteLine("\n读取账号表格中");
            ReadAndCheckAccountTable();
            
            GetLastIDs();

            CleanUp();

            Console.WriteLine("\n完成，任意键退出");
            Console.ReadKey();
        }

        private static void CreateContainerFolders() {
            List<string> foldersToCreate = new List<string> {
                "./1 - 进口",
                "./2 - 出口",
                "./2 - 出口/隔离",
                "./tmp",
                "./1 - 进口/1",
                "./1 - 进口/2",
            };

            foreach(string folder in foldersToCreate){
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }
        }

        private static void ReadFirstDatabase()
        {
            string adb = "./1 - 进口/1/dl_adb_all.sql";

            if (File.Exists(adb))
            {
                SplitDatabaseTables(adb);
            }
            else
            {
                //ERROR
                Console.WriteLine("\n未找到文件，拜拜");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void ReadSecondDatabase()
        {
            string adb = "./1 - 进口/2/dl_adb_all.sql";
            string ddb = "./1 - 进口/2/dl_ddb_1.sql";

            if (File.Exists(adb) && File.Exists(ddb))
            {
                SplitDatabaseTables(adb, ddb);
            }
            else {
                //ERROR
                Console.WriteLine("\n未找到文件，拜拜");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void SplitDatabaseTables(string adb)
        {
            List<string> adbTables = new List<string> {
                "account"
            };

            string outputPath = "./tmp/atables";
            List<KeyValuePair<string, string>> atables = ReadSQLFiles(adb, adbTables);


            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }


            foreach (var item in adbTables)
            {
                WriteSplitedTableToFiles(outputPath, item, atables);
            }
        }

        private static void SplitDatabaseTables(string adb, string ddb)
        {
            List<string> adbTables = new List<string> {
                "account"
            };
            List<string> ddbTables = new List<string> {
                "basic_char_info",
                "data",
                "gid_info",
                "property_recall",
            };

            string outputPath = "./tmp/btables";
            List<KeyValuePair<string, string>> atables = ReadSQLFiles(adb, adbTables);
            List<KeyValuePair<string, string>> dtables = ReadSQLFiles(ddb, ddbTables);


            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }


            foreach (var item in adbTables)
            {
                WriteSplitedTableToFiles(outputPath, item, atables);
            }

            foreach (var item in ddbTables)
            {
                WriteSplitedTableToFiles(outputPath, item, dtables);
            }
        }

        private static List<KeyValuePair<string, string>> ReadSQLFiles(string sqlPath, List<string> tablesNames)
        {
            List<KeyValuePair<string, string>> List = new List<KeyValuePair<string, string>>();
                
            using (StreamReader inputReader = new StreamReader(sqlPath, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();

                    foreach (var item in tablesNames)
                    {
                        if (MatchLines(line, item))
                        {
                            List.Add(new KeyValuePair<string, string>(item,line));
                        }
                    }
                }
                return List;
            }
        }

        private static bool MatchLines(String line,String tableName) {
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


        private static void WriteSplitedTableToFiles(string outputPath, string item, List<KeyValuePair<string, string>> dicts)
        {
            string file = outputPath + "/" + item + ".sql";
            Console.WriteLine("Writing to " + file);
            try
            {
                
                FileStream fcreate = File.Open(file, FileMode.Create);
                StreamWriter sw = new StreamWriter(fcreate,Encoding.GetEncoding("gb2312"));

                foreach (KeyValuePair<string, string> kvp in dicts)
                {
                    if (item.Equals(kvp.Key))
                    {
                        sw.WriteLine(kvp.Value);
                    }
                }

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        private static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        /*
         * 
         */

        private static void ReadAndCheckAccountTable() {
            string db1account = "./tmp/atables/account.sql";
            string db2account = "./tmp/btables/account.sql";

            List<string> listOfAccountInA = new List<string>();
            List<string> listOfConflicts = new List<string>();

            using (StreamReader inputReader = new StreamReader(db1account, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    string account = line.Remove(0, 31).Split(',')[0].Replace("'", "");
                    listOfAccountInA.Add(account);
                }
            }

            using (StreamReader inputReader = new StreamReader(db2account, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    string account = line.Remove(0, 31).Split(',')[0].Replace("'", "");
                    if (listOfAccountInA.Contains(account))
                    {
                        listOfConflicts.Add(account);
                    }
                }
            }

            Console.WriteLine("\n以下账号有冲突：");
            foreach (var account in listOfConflicts)
            {
                Console.WriteLine("--" + account);
            }
            Console.WriteLine("\n选项：【1 - 不处理】【2 - 隔离】");

            if(Console.ReadLine() == "2") {
                Console.WriteLine("\n已选择隔离");
                IsolateAccount(listOfConflicts);
                return;
            }
            else {
                Console.WriteLine("\n已选择不处理");
                return;
            }
        }

        private static void IsolateAccount(List<string> listOfConflicts) {
            string accountFile = "./tmp/btables/account.sql";
            string dataFile = "./tmp/btables/data.sql";
            Console.WriteLine("\n隔离中： " );

            string accountFileData = "";
            string dataFileData = "";

            string isoAccountFileData = "";
            string isoDataFileData = "";

            using (StreamReader inputReader = new StreamReader(accountFile, Encoding.GetEncoding("gb2312")))
            {
                Console.WriteLine("- 隔离account");
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    foreach (string account in listOfConflicts)
                    {
                        if (!line.Contains(account))
                        {
                            accountFileData += line + Environment.NewLine ;
                        }
                        else
                        {
                            isoAccountFileData += line + Environment.NewLine;
                        }
                    }
                }
            }

            using (StreamReader inputReader = new StreamReader(dataFile, Encoding.GetEncoding("gb2312")))
            {

                Console.WriteLine("- 隔离data");
                Console.WriteLine("请稍等。。。。");
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    foreach (string account in listOfConflicts)
                    {
                        if (!line.Contains(account))
                        {
                            dataFileData += line + Environment.NewLine;
                        }
                        else {
                            isoDataFileData += line + Environment.NewLine;
                        }
                    }
                }
            }

            Console.WriteLine("保存修改" );
            File.WriteAllText(accountFile, accountFileData, Encoding.GetEncoding("gb2312"));
            File.WriteAllText(dataFile, dataFileData, Encoding.GetEncoding("gb2312"));

            if (!Directory.Exists("./tmp/iso"))
            {
                Directory.CreateDirectory("./tmp/iso");
            }

            Console.WriteLine("写入隔离区" );
            File.WriteAllText(accountFile.Replace("btables","iso"), isoAccountFileData, Encoding.GetEncoding("gb2312"));
            File.WriteAllText(dataFile.Replace("btables", "iso"), isoDataFileData, Encoding.GetEncoding("gb2312"));

            Console.WriteLine("\n隔离完成");
        }

        /*
         * 
         */

        private static void GetLastIDs()
        {
            Console.Write("\n输入一号区名字[默认-问道一区]：");
            string newDistrict = Console.ReadLine();

            if (newDistrict.Equals(""))
            {
                newDistrict = "问道一区";
            }

            Console.Write("\n输入二号区名字[默认-问道二区]：");
            string oldDistrict = Console.ReadLine();

            if (oldDistrict.Equals(""))
            {
                oldDistrict = "问道二区";
            }

            Console.WriteLine("\n输入数据库一里以下表格的最后一项识别号码");
            Console.Write("gid_info表: ");
            
            int gid_info = Int32.Parse(Console.ReadLine());

            Console.Write("property_recall表: ");
            
            int property_recall = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n开始读取");
            List<int> IdsToReplace = ReadGidInfo();
            SearchAndReplace(gid_info, IdsToReplace, oldDistrict,newDistrict, property_recall);
        }

        private static List<int> ReadGidInfo()
        {
            string FilePath = "./tmp/btables/gid_info.sql";
            List<int> IdsToReplace = new List<int>();

            using (StreamReader inputReader = new StreamReader(FilePath, Encoding.GetEncoding("gb2312")))
            {
                while (!inputReader.EndOfStream)
                {
                    var line = inputReader.ReadLine();
                    int id = Int32.Parse(line.Remove(0,31).Split(',')[0].Replace("'",""));
                    IdsToReplace.Add(id);
                }
            }

            return IdsToReplace;
        }

        private static void SearchAndReplace(int gid_info, List<int> idsToReplace, string oldDistrict, string newDistrict, int property_recall)
        {
            List<string> filesToLoop = new List<string> {
                "./tmp/btables/basic_char_info.sql",
                "./tmp/btables/data.sql",
                "./tmp/btables/gid_info.sql",
                "./tmp/btables/property_recall.sql",
            };

            if (!Directory.Exists("./tmp/replaced")) {
                Directory.CreateDirectory("./tmp/replaced");
            }

            foreach (var file in filesToLoop)
            {
                if (file.Equals("./tmp/btables/property_recall.sql"))
                {
                    List<int> prIdstoReplace = new List<int>();
                    using (StreamReader inputReader = new StreamReader(file, Encoding.GetEncoding("gb2312")))
                    {
                        while (!inputReader.EndOfStream)
                        {
                            var line = inputReader.ReadLine();
                            int id = Int32.Parse(line.Remove(0, 38).Split(',')[0].Replace("'", ""));
                            prIdstoReplace.Add(id);
                        }
                    }

                    string prtext = File.ReadAllText(file, Encoding.GetEncoding("gb2312"));
                    foreach (var id in prIdstoReplace)
                    {
                        prtext = prtext.Replace("'" + id + "'", "'" + (id + property_recall) + "'");
                    }
                    File.WriteAllText(file, prtext, Encoding.GetEncoding("gb2312"));
                }

                Console.WriteLine("\n读取中： " + file);
                string text = File.ReadAllText(file, Encoding.GetEncoding("gb2312"));

                foreach (var id in idsToReplace)
                {
                    int newId = gid_info + id;
                    string newIdHex = newId.ToString("X").PadLeft(16, '0');
                    string searchIDString = id.ToString("X").PadLeft(16, '0');
                    Console.WriteLine("-- 替换中: " + id + " to [" + newId + "] [" + newIdHex + "]");

                    if (file.Equals("./tmp/btables/gid_info.sql"))
                    {
                        text = text.Replace("'" + id + "'", "'" + newId + "'");
                    } else {
                        text = text.Replace(searchIDString, newIdHex);
                    }

                    text = text.Replace(oldDistrict, newDistrict);
                    
                }
                File.WriteAllText(file.Replace("btables", "replaced"), text, Encoding.GetEncoding("gb2312"));
                
            }
            
        }

        private static void CleanUp()
        {
            File.Copy("./tmp/btables/account.sql", "./2 - 出口/account.sql");
            File.Copy("./tmp/replaced/basic_char_info.sql", "./2 - 出口/basic_char_info.sql");
            File.Copy("./tmp/replaced/data.sql", "./2 - 出口/data.sql");
            File.Copy("./tmp/replaced/gid_info.sql", "./2 - 出口/gid_info.sql");
            File.Copy("./tmp/replaced/property_recall.sql", "./2 - 出口/property_recall.sql");
            File.Copy("./tmp/iso/account.sql", "./2 - 出口/隔离/account.sql");
            File.Copy("./tmp/iso/data.sql", "./2 - 出口/隔离/data.sql");

            DeleteDirectory("./tmp");
        }

    }
}
