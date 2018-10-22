namespace ATGate
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pb_divider = new System.Windows.Forms.PictureBox();
            this.textBoxFAQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.label_des_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_divider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("KaiTi", 12F);
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDescription.Location = new System.Drawing.Point(13, 111);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(11, 6, 7, 6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(233, 145);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // pb_divider
            // 
            this.pb_divider.BackColor = System.Drawing.Color.Transparent;
            this.pb_divider.Image = global::ATGate.Properties.Resources.divider;
            this.pb_divider.Location = new System.Drawing.Point(256, 12);
            this.pb_divider.Name = "pb_divider";
            this.pb_divider.Size = new System.Drawing.Size(10, 248);
            this.pb_divider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_divider.TabIndex = 24;
            this.pb_divider.TabStop = false;
            // 
            // textBoxFAQ
            // 
            this.textBoxFAQ.BackColor = System.Drawing.Color.White;
            this.textBoxFAQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFAQ.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFAQ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFAQ.Location = new System.Drawing.Point(274, 39);
            this.textBoxFAQ.Margin = new System.Windows.Forms.Padding(11, 6, 7, 6);
            this.textBoxFAQ.Multiline = true;
            this.textBoxFAQ.Name = "textBoxFAQ";
            this.textBoxFAQ.ReadOnly = true;
            this.textBoxFAQ.Size = new System.Drawing.Size(445, 217);
            this.textBoxFAQ.TabIndex = 25;
            this.textBoxFAQ.TabStop = false;
            this.textBoxFAQ.Text = "1) 运行库问题\r\nSystem.IO.FileLoadException: Could not load file or assembly ...\r\n运行库问题" +
    "，请下载安装最新.Net4.0更新包\r\n\r\n2) 注册限制\r\n请联系客服\r\n\r\n3) 服务器/数据库未连接\r\n请联系客服\r\n\r\n4) 游戏启动问题\r\n在主页勾选" +
    " “本地模式” 后重试\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "常见问题";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(9, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(54, 21);
            this.labelProductName.TabIndex = 28;
            this.labelProductName.Text = "NAME";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(9, 39);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(87, 21);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "VERSION";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCopyright.Location = new System.Drawing.Point(12, 262);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Padding = new System.Windows.Forms.Padding(3);
            this.labelCopyright.Size = new System.Drawing.Size(60, 27);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "COPY";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_des_info
            // 
            this.label_des_info.AutoSize = true;
            this.label_des_info.Location = new System.Drawing.Point(110, 75);
            this.label_des_info.Name = "label_des_info";
            this.label_des_info.Size = new System.Drawing.Size(54, 21);
            this.label_des_info.TabIndex = 31;
            this.label_des_info.Text = "详情";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 299);
            this.Controls.Add(this.label_des_info);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFAQ);
            this.Controls.Add(this.pb_divider);
            this.Controls.Add(this.textBoxDescription);
            this.Font = new System.Drawing.Font("KaiTi", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.pb_divider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pb_divider;
        private System.Windows.Forms.TextBox textBoxFAQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label label_des_info;
    }
}
