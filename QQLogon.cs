using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATGate
{
    public partial class QQLogon : Form
    {
        public bool verifiedStatus = false;

        public QQLogon()
        {
            InitializeComponent();

            Uri uri = new Uri("http://ui.ptlogin2.qq.com/cgi-bin/login?appid=549000912&style=13&s_url=http://qun.qzone.qq.com/group");
            qqLogonPanel.Navigate(uri);
            WebBrowserNavigatedEventHandler handle = new WebBrowserNavigatedEventHandler(Wb_urlChange_Handler);
            qqLogonPanel.Navigated += handle;
            
        }

        private void Wb_urlChange_Handler(object sender, WebBrowserNavigatedEventArgs e)
        {
            Console.WriteLine("Handle Triggered");

            string sub = qqLogonPanel.Url.ToString().Substring(7, 3);
            Console.WriteLine(sub);
            switch (sub) {
                case "qun":
                    qqLogonPanel.Visible = false;
                    loadingPanel.Visible = true;
                    Uri uri = new Uri("http://bbs.qun.qq.com/forumdisplay?gId=649967463");
                    qqLogonPanel.Navigate(uri);
                    Console.WriteLine("login success");
                    break;
                case "bbs":
                    //Not a member
                    logonStatus.Text = "非成员";
                    requestMembership.Enabled = true;
                    Console.WriteLine("Not a member");
                    break;
                case "qgc":
                    //is a member
                    logonStatus.Text = "成员验证通过";
                    verifiedStatus = true;
                    this.Close();
                    break;
                case "qm.":
                    qqLogonPanel.Visible = true;
                    loadingPanel.Visible = false;
                    break;
            }
           
        }

        private void requestMembership_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://qm.qq.com/cgi-bin/qm/qr?k=2VkJJskQw_SgcwBytKS0pq_qrWUoPcTk");
            qqLogonPanel.Navigate(uri);
        }
    }
}
