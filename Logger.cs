using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ATDBMerger
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath);
            }
        }

        private void Log(string tag = "default", string content="unused log function") {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine("["+ DateTime.Now + "]["+tag+"]: " + content);
            }
        }
    }
}
