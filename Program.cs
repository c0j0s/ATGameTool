using ShellProgressBar;
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
        //Folder and files
        static string outputPath = "./2 - 出口";
        static string inputFolder = "./1 - 进口";
        static string inputFolderA = "./1 - 进口/本体";
        static string inputFolderB = "./1 - 进口/合并";
        static string isolationPath = outputPath + "/隔离";

        static string aAdb = inputFolder + "/1/dl_adb_all.sql";
        static string aDdb = inputFolder + "/1/dl_ddb_1.sql";
        static string bAdb = inputFolder + "/2/dl_adb_all.sql";
        static string bDdb = inputFolder + "/2/dl_ddb_1.sql";

        //SQL Values
        static List<KeyValuePair<string, string>> aAccount;
        static List<KeyValuePair<string, string>> aData;
        static List<KeyValuePair<string, string>> bAccount;
        static List<KeyValuePair<string, string>> bBasic_char_info;
        static List<KeyValuePair<string, string>> bData;
        static List<KeyValuePair<string, string>> bGid_info;
        static List<KeyValuePair<string, string>> bProperty_recall;

        static List<string> ConflictAccounts = new List<string>();
        static List<List<KeyValuePair<string, string>>> ConflictAccountData = new List<List<KeyValuePair<string, string>>>();

        //Values
        static string oldDistrict = "";
        static string newDistrict = "";
        static int maxGid_info = 0;
        static int maxProperty_recall = 0;
        static string allDataText = "";

        static void Main(string[] args)
        {
            //Opening
            Opening();

            //Read All Values
            ReadValues();

            //ExtractDatabase
            Console.WriteLine("\n开始读取SQL文件");
            ExtractDatabase();

            //Check for account conflicts
            Console.WriteLine("\n【任意键开始检测账号冲突】");
            Console.ReadKey();
            CheckForAccountConflicts();

            Console.WriteLine("\n【任意键开始生成合区数据】");
            Console.ReadKey();
            GenerateCombinedData();

            Console.WriteLine("\n【任意键开始生成合区文件】");
            Console.ReadKey();
            GenerateCombinedSQLFiles();
            
            Ending();

        }

        /// <summary>
        /// Opening and closing task
        /// </summary>
        private static void Opening()
        {
            Console.WriteLine("【合区程序：任意键开始】");
            Console.ReadKey();

            string[] container = {inputFolder,outputPath, isolationPath, inputFolderA, inputFolderB };
            FolderUtil.CreateContainerFolders(container);

            Console.WriteLine("\n已创建文件夹，把一下SQL文件放入相应的文件夹内");
            Console.WriteLine("     ./1 - 进口/1/dl_adb_all.sql");
            Console.WriteLine("     ./1 - 进口/2/dl_adb_all.sql");
            Console.WriteLine("     ./1 - 进口/2/dl_ddb_1.sql");
            Console.WriteLine("     确保SQL文件编码为GB2312！");

            Console.WriteLine("【完成后任意键继续：】");
            Console.ReadKey();
        }


        private static void Ending()
        {
            Console.WriteLine("\n【完成，任意键退出】");
            Console.ReadKey();
        }

        /// <summary>
        /// Read All Values
        /// </summary>
        private static void ReadValues()
        {
            Console.WriteLine("\n输入以下信息");
            Console.Write("     一号区名字 [默认-问道一区]：");
            newDistrict = Console.ReadLine();

            if (newDistrict.Equals(""))
            {
                newDistrict = "问道一区";
            }

            Console.Write("     二号区名字 [默认-问道二区]：");
            oldDistrict = Console.ReadLine();

            if (oldDistrict.Equals(""))
            {
                oldDistrict = "问道二区";
            }


            Console.WriteLine("\n输入数据库一里以下表格的最后一项识别号码");
            string input = "";
            do
            {
                Console.Write("     gid_info表: ");
                input = Console.ReadLine();

            } while (input.Equals(""));
            maxGid_info = Int32.Parse(input);

            do
            {
                Console.Write("     property_recall表: ");
                input = Console.ReadLine();

            } while (input.Equals(""));
            maxProperty_recall = Int32.Parse(input);
            
        }

        /// <summary>
        /// Read All SQL Files
        /// </summary>
        private static void ExtractDatabase()
        {
            const int totalTicks = 5;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true
            };
            using (var pbar = new ProgressBar(totalTicks, "读取SQL文件", options))
            {
                
                pbar.Tick(aAdb);
                aAccount = SQLUtil.OpenSqlFile(aAdb, "account");

                
                pbar.Tick(bDdb);
                aData = SQLUtil.OpenSqlFile(aDdb, "data");

                
                pbar.Tick(bAdb);
                bAccount = SQLUtil.OpenSqlFile(bAdb, "account");

                
                pbar.Tick(bDdb);
                bBasic_char_info = SQLUtil.OpenSqlFile(bDdb, "basic_char_info");
                bData = SQLUtil.OpenSqlFile(bDdb, "data");
                bGid_info = SQLUtil.OpenSqlFile(bDdb, "gid_info");
                bProperty_recall = SQLUtil.OpenSqlFile(bDdb, "property_recall");

                pbar.Tick("读取完成");
            }

        }



        /// <summary>
        /// Check for account conflicts
        /// </summary>
        private static void CheckForAccountConflicts()
        {
            Console.WriteLine("以下账号有冲突：");
            foreach (KeyValuePair<string,string> account in bAccount)
            {
                var result = aAccount.Where(kvp => SQLUtil.GetInsertId(kvp.Value) == SQLUtil.GetInsertId(account.Value));
                foreach (KeyValuePair<string, string> item in result)
                {
                    string accountId = SQLUtil.GetInsertId(item.Value);
                    ConflictAccounts.Add(accountId);
                    Console.WriteLine("      " + accountId);
                }
            }

            Console.Write("\n选项【1 - 隔离【默认】】【2 - 不处理】: ");

            if (Console.ReadLine() == "2")
            {
                Console.WriteLine("已选择不处理");
                return;
            }
            else
            {
                Console.WriteLine("已选择隔离");
                IsolateAccountData();
                return;
            }
        }

        private static void IsolateAccountData()
        {
            //Console.WriteLine(bAccount.Count);
            //Console.WriteLine(bData.Count);
            int totalTicks = ConflictAccounts.Count;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true
            };
            using (var pbar = new ProgressBar(totalTicks, "开始隔离", options))
            {
                
                foreach (string account in ConflictAccounts)
                {
                    
                    pbar.Tick("隔离" + account);
                    IEnumerable<KeyValuePair<string, string>> accountInfo = bAccount.Where(kvp => kvp.Value.Contains("'" + account + "'"));
                    IEnumerable<KeyValuePair<string, string>> accountData = bData.Where(kvp => kvp.Value.Contains("'login', '" + account + "'"));

                    ConflictAccountData.Add(accountInfo.ToList());
                    ConflictAccountData.Add(accountData.ToList());
                    
                    IEnumerable<KeyValuePair<string, string>> accountCleanInfo = bAccount.Where(kvp => !kvp.Value.Contains("'" + account + "'"));
                    IEnumerable<KeyValuePair<string, string>> accountCleanData = bData.Where(kvp => !kvp.Value.Contains("'login', '" + account + "'"));

                    bAccount = accountCleanInfo.ToList();
                    bData = accountCleanData.ToList();

                }
                pbar.Tick("完成隔离");
            }
        }

        private static void GenerateCombinedData()
        {
            int totalTicks = 0;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true
            };

            List<KeyValuePair<string, string>> temp_bBasic_char_info = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> temp_bGid_info = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> temp_bProperty_recall = new List<KeyValuePair<string, string>>();

            /*
             * gid_info
             */
            if (maxGid_info > 0)
            {
                totalTicks = bGid_info.Count;
                using (var pbar = new ProgressBar(totalTicks, "处理 gid_info", options))
                {
                    foreach (KeyValuePair<string, string> item in bGid_info)
                    {
                        string oldId = SQLUtil.GetInsertId(item.Value);
                        int id = Int32.Parse(oldId) + maxGid_info;
                        pbar.Tick(oldId + " -> " + id);
                        temp_bGid_info.Add(new KeyValuePair<string, string>(item.Key, item.Value.Replace("'" + oldId + "'", "'" + id + "'")));
                    }
                    bGid_info = temp_bGid_info;
                }
            }
            /*
             * property_recall
             */
            if (maxProperty_recall > 0)
            {
                totalTicks = bProperty_recall.Count;
                using (var pbar = new ProgressBar(totalTicks, "处理 property_recall", options))
                {
                    
                    foreach (KeyValuePair<string, string> item in bProperty_recall)
                    {
                        string oldId = SQLUtil.GetInsertId(item.Value);
                        int id = Int32.Parse(oldId) + maxProperty_recall;
                        pbar.Tick(oldId + " -> " + id);
                        temp_bProperty_recall.Add(new KeyValuePair<string, string>(item.Key, item.Value.Replace("'" + oldId + "'", "'" + id + "'")));
                    }

                    bProperty_recall = temp_bProperty_recall;
                }
            }

            /*
             * basic_char_info
             */
            List<KeyValuePair<string, string>> hexPairToReplace = new List<KeyValuePair<string, string>>();

            totalTicks = bBasic_char_info.Count;
            using (var pbar = new ProgressBar(totalTicks, "处理 basic_char_info", options))
            {

                foreach (KeyValuePair<string, string> item in bBasic_char_info)
                {
                    string oldHexId = SQLUtil.GetInsertId(item.Value);
                    int oldId = int.Parse(oldHexId, System.Globalization.NumberStyles.HexNumber);
                    int id = oldId + maxGid_info;
                    string newIdHex = id.ToString("X").PadLeft(16, '0');

                    pbar.Tick(oldHexId + " -> " + newIdHex);
                    hexPairToReplace.Add(new KeyValuePair<string, string>(oldHexId, newIdHex));
                    temp_bBasic_char_info.Add(new KeyValuePair<string, string>(item.Key, item.Value.Replace("'" + oldHexId + "'", "'" + newIdHex + "'")));
                }
                bBasic_char_info = temp_bBasic_char_info;
            }
            /*
             * data
             */
            
            Console.WriteLine("\n处理 data冲突: ");
            List<string> aDataValues = new List<string>();
            foreach (KeyValuePair<string,string> item in aData)
            {
                aDataValues.Add(item.Value);
            }
            List<KeyValuePair<string, string>> AllMatchedLines = new List<KeyValuePair<string, string>>();
            totalTicks = aDataValues.Count;
            using (var pbar = new ProgressBar(totalTicks, "检测Data冲突", options))
            {
                foreach (string statement in aDataValues)
                {
                    //match primary keys and extract matching line
                    pbar.Tick();
                    IEnumerable<KeyValuePair<string, string>> MatchItems = bData.Where(kvp => SQLUtil.DataKeyDuplicate(kvp.Value, statement));
                    AllMatchedLines.AddRange(MatchItems);
                }
            }
            
            totalTicks = AllMatchedLines.Count;
            using (var pbar = new ProgressBar(totalTicks, "移除Data冲突", options))
            {
                foreach (KeyValuePair<string, string> item in AllMatchedLines)
                {
                    pbar.Tick("移除: " + item.Value);
                    bData.Remove(item);
                }
            }

            Console.WriteLine("\n处理 data: ");
            foreach (KeyValuePair<string, string> item in bData)
            {
                allDataText += item.Value + "\n";
            }

            totalTicks = hexPairToReplace.Count;
            using (var pbar = new ProgressBar(totalTicks, "处理 data ID", options))
            {
                foreach (KeyValuePair<string, string> pair in hexPairToReplace)
                {
                    pbar.Tick(pair.Key + " -> " + pair.Value);
                    allDataText = allDataText.Replace(pair.Key, pair.Value);
                }
            }

            if (!oldDistrict.Equals(newDistrict))
            {
                Console.WriteLine("\n处理 data 分区名: ");
                allDataText = allDataText.Replace(oldDistrict, newDistrict);
                
            }

            Console.WriteLine("处理完成");
        }

        private static void GenerateCombinedSQLFiles()
        {
            Console.WriteLine("...");
            WriteToSQLFile(outputPath,bAccount);
            WriteToSQLFile(outputPath, allDataText);
            WriteToSQLFile(outputPath, bGid_info);
            WriteToSQLFile(outputPath, bBasic_char_info);
            WriteToSQLFile(outputPath, bProperty_recall);

            foreach (List<KeyValuePair<string, string>> item in ConflictAccountData)
            {
                WriteToSQLFile(isolationPath, item);
            }

            Console.WriteLine("生成完成");
        }

        private static void WriteToSQLFile(string path, List<KeyValuePair<string, string>> item)
        {
            try
            {
                string file = path + "/" + item[0].Key + ".sql";
                Console.WriteLine("Writing to " + file);
                FileStream fcreate = File.Open(file, FileMode.Create);
                StreamWriter sw = new StreamWriter(fcreate, Encoding.GetEncoding("gb2312"));

                foreach (KeyValuePair<string, string> pair in item)
                {
                    sw.WriteLine(pair.Value);
                }
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        private static void WriteToSQLFile(string path, string AllData)
        {
            try
            {
                string file = path + "/data.sql";
                Console.WriteLine("Writing to " + file);
                FileStream fcreate = File.Open(file, FileMode.Create);
                StreamWriter sw = new StreamWriter(fcreate, Encoding.GetEncoding("gb2312"));
                sw.WriteLine(AllData);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

    }
}
