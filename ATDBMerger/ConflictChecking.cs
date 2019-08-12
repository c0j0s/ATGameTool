using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDBMerger
{
    public partial class ConflictChecking : Form
    {
        public ConflictChecking(List<List<string>> a, List<List<string>> b)
        {
            InitializeComponent();

            foreach (var item in a)
            {
                Tb_output_a.AppendText(string.Join(" | ", item) + "\n \n");
            }

            foreach (var item in b)
            {
                Tb_output_b.AppendText(string.Join(" | ", item) + "\n \n");
            }
        }

    }
}
