using ShellProgressBar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATDBMerger
{
    class Program
    {
        private static Logger logger = new Logger("ATDBMerger.log");

        static void Main(string[] args)
        {
            Application.Run(new Homepage(logger));
        }

    }
}
