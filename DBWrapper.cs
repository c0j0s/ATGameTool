using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ATDBMerger
{
    public class DBWrapper
    {
        private DBConnect db;
        private Server server;

        public DBWrapper(Server server)
        {
            this.server = server;
            db = new DBConnect(server);
        }

        public bool TestConnection() {
            if (db.OpenConnection())
            {
                db.CloseConnection();
                var schemaCheckAdb = CheckIfSchemaExist(server.RegisterDbSchema);
                var schemaCheckDdb = CheckIfSchemaExist(server.DataSchema);

                if (schemaCheckAdb && schemaCheckDdb)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        private bool CheckIfSchemaExist(string schemaName) {
            try
            {
                DataTable dt = db.Select("SELECT COUNT(SCHEMA_NAME) as res FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '"+ schemaName + "'");
                if (dt.Rows[0].Field<Int64>("res") == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            return false;
        }
    }
}
