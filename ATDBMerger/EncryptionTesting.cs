using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ATDBMerger
{
    public partial class EncryptionTesting : Form
    {
        public EncryptionTesting()
        {
            InitializeComponent();
        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {
            string[] list = tb_input.Lines;
            List<string> output = new List<string>();
            List<string> output2 = new List<string>();
            tb_output.Text = "";
            foreach (string mystring in list)
            {
                if (!mystring.Equals(""))
                {
                    string input = mystring.Replace(" ", "").Replace("\t", "");
                    MD5 md5Hasher = MD5.Create();
                    var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                    var ivalue = BitConverter.ToInt32(hashed, 0);
                    var checksum = BitConverter.ToString(hashed).Replace("-", "").ToUpper();
                    output.Add(ivalue.ToString());
                    output2.Add(checksum.ToString());
                }
                else
                {
                    output.Add("");
                    output2.Add("");
                }
            }
            tb_output.Lines = output.ToArray();
            tb_output2.Lines = output2.ToArray();
        }
    }
}
