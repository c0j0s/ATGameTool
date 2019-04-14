using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATGate
{
    /// <summary>
    /// 服务器对象
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
    }
}
