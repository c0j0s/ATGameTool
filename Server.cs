using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATGate
{
    public class Server
    {
        private string name;
        private string ip;
        private string des;
        private string port;
        private string cmdString;
        private string status;
        private string delay;

        public Server(string name, string ip) {
            this.name = name;
            this.ip = ip;
            this.port = "8101";
            this.status = "未连接";
        }

        public Server(string name, string ip, string port)
        {
            this.name = name;
            this.ip = ip;
            this.port = port;
            this.status = "未连接";
        }

        public string Name { get => name; set => name = value; }

        public string Ip { get => ip; set => ip = value; }

        public string Des { get => des; set => des = value; }

        public string Port { get => port; set => port = value; }

        public string CmdString {
            get => "/C start asktao.mod " + this.name + ";" + this.ip + ";"+Port+";kbd:0;swictch:0;paroxy:0;flag:;uncheck";
            set => cmdString = value;
        }
        public string Status { get => status; set => status = value; }
        public string Delay { get => delay+"ms"; set => delay = value; }
    }
}
