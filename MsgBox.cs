using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATGate
{
    public partial class MsgBox : Form
    {
        private string title;
        private string content;
        private string contact = Properties.Resources.admin_qq + "\n" + Properties.Resources.tech_qq;
        private string dist = Properties.Resources.distribute;

        public MsgBox(string eid, string title, string content, string ip=null)
        {
            InitializeComponent();
            this.title = title + " " + eid;
            this.content = content;

            lb_error_details.Text = content;
            lb_contact_details.Text = contact;
            lb_dist.Text = "Dist: " + dist;
            Name = this.title;
            Text = this.title;

            if(ip != null)
            {
                lb_server.Text = "Server: " + ip;
                lb_server.Visible = true;
            }
        }

        private void btn_faq_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

    }
}
