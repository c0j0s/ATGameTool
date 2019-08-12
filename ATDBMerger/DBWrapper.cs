//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace ATDBMerger
//{
//    public class DBWrapper
//    {
//        private DBConnect dbAdb;
//        private DBConnect dbDdb;
//        private Server server;
//        private string cache;

//        public DBWrapper(Server server, String cache)
//        {
//            this.server = server;
//            this.cache = cache;
//            dbAdb = new DBConnect(server, server.RegisterDbSchema);
//            dbDdb = new DBConnect(server, server.DataSchema);
//        }

//        internal bool TestConnection() {
//            var schemaCheckAdb = CheckIfSchemaExist(server.RegisterDbSchema);
//            var schemaCheckDdb = CheckIfSchemaExist(server.DataSchema);

//            if (schemaCheckAdb && schemaCheckDdb)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        private bool CheckIfSchemaExist(string schemaName) {
//            try
//            {
//                DataTable dt = dbAdb.Select("SELECT COUNT(SCHEMA_NAME) as res FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '"+ schemaName + "'");
//                if (dt.Rows[0].Field<Int64>("res") == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message + "\n" + e.StackTrace);
//            }
//            return false;
//        }

//        internal void DownloadTable(string schema, string table)
//        {
//            string saveToFile = cache + "/" + table + ".sql";
//            string formatToFile = cache + "/" + table + ".csv";
//            if (schema.Contains("adb"))
//            {
//                dbAdb.ExportTable(table, saveToFile);
//            }
//            else
//            {
//                dbDdb.ExportTable(table, saveToFile);
//            }

//            const Int32 BufferSize = 128;
//            using (var fileStream = File.OpenRead(saveToFile))
//            {
//                using (StreamWriter sw = File.AppendText(formatToFile))
//                {
//                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
//                    {
//                        String line;
//                        while ((line = streamReader.ReadLine()) != null)
//                        {
//                            if (line.StartsWith("I"))
//                            {
//                                var splitLine = line.Split('(');
//                                var trimedLine = splitLine[1].Replace(");", "");
//                                sw.WriteLine(trimedLine);
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
