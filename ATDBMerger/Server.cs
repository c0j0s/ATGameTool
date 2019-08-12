using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATDBMerger
{
    /// <summary>
    /// 服务器对象
    /// 复制与ATGate
    /// </summary>
    public class Server
    {
        private string name;
        private string ip;
        private string registerIp = "";
        private string des;
        private string port;
        private string cmdString;
        private string status = "未连接";
        private bool registerServerStatus = false;
        private string registerDbSchema = "dl_adb_all";
        private string dataSchema = "dl_ddb_1";
        private string dbLogin = "";
        private string dbPassword = "";
        private string delay;

        

        public string Status { get => status; set => status = value; }
        public string Delay { get => delay+"ms"; set => delay = value; }
        public string RegisterIp { get => registerIp; set => registerIp = value; }
        public string Name { get => name; set => name = value; }
        public string Ip { get => ip; set => ip = value; }
        public string Des { get => des; set => des = value; }
        public string Port { get => port; set => port = value; }
        public string CmdString { get => cmdString; set => cmdString = value; }
        public bool RegisterServerStatus { get => registerServerStatus; set => registerServerStatus = value; }

        public string getCmdArgs
        {
            get => " " + this.Name + ";" + this.Ip + ";" + Port + ";kbd:0;swictch:0;paroxy:0;flag:;uncheck";
            set => CmdString = value;
        }
        public string getCmdString {
            get => "/C start asktao.mod " + this.Name + ";" + this.Ip + ";" + Port + ";kbd:0;swictch:0;paroxy:0;flag:;uncheck";
            set => CmdString = value;
        }
        public string RegisterDbSchema { get => registerDbSchema; set => registerDbSchema = value; }
        public string DataSchema { get => dataSchema; set => dataSchema = value; }
        public string DbLogin { get => dbLogin; set => dbLogin = value; }
        public string DbPassword { get => dbPassword; set => dbPassword = value; }

        public string getRegisterIp() {

            if (RegisterIp.Equals(Ip))
            {
                return Ip;
            }

            if (RegisterIp.Equals(""))
            {
                return Ip;
            }
            
            return RegisterIp;
        }

        public string getDBConnectionString(string schema)
        {
            if (schema.Contains("adb"))
            {
                return "SERVER=" + getRegisterIp () + ";" + "DATABASE=" +
                RegisterDbSchema  + ";" + "UID=" + DbLogin + ";" + "PASSWORD=" + DbPassword + ";charset=GB2312;";
            }
            else {
                return "SERVER=" + getRegisterIp() + ";" + "DATABASE=" +
                DataSchema + ";" + "UID=" + DbLogin + ";" + "PASSWORD=" + DbPassword + ";charset=GB2312;";
            }
          
        }
    }
}
