namespace ATGate
{
    partial class QQLogon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQLogon));
            this.qqLogonPanel = new System.Windows.Forms.WebBrowser();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.requestMembership = new System.Windows.Forms.Button();
            this.logonStatus = new System.Windows.Forms.Label();
            this.logonStatusInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qqLogonPanel
            // 
            this.qqLogonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qqLogonPanel.IsWebBrowserContextMenuEnabled = false;
            this.qqLogonPanel.Location = new System.Drawing.Point(0, 0);
            this.qqLogonPanel.MinimumSize = new System.Drawing.Size(23, 23);
            this.qqLogonPanel.Name = "qqLogonPanel";
            this.qqLogonPanel.ScriptErrorsSuppressed = true;
            this.qqLogonPanel.ScrollBarsEnabled = false;
            this.qqLogonPanel.Size = new System.Drawing.Size(384, 341);
            this.qqLogonPanel.TabIndex = 0;
            this.qqLogonPanel.WebBrowserShortcutsEnabled = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.SystemColors.Window;
            this.loadingPanel.Controls.Add(this.requestMembership);
            this.loadingPanel.Controls.Add(this.logonStatus);
            this.loadingPanel.Controls.Add(this.logonStatusInfo);
            this.loadingPanel.Controls.Add(this.pictureBox1);
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(384, 348);
            this.loadingPanel.TabIndex = 2;
            this.loadingPanel.Visible = false;
            // 
            // requestMembership
            // 
            this.requestMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.requestMembership.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.requestMembership.Enabled = false;
            this.requestMembership.FlatAppearance.BorderSize = 0;
            this.requestMembership.Location = new System.Drawing.Point(12, 299);
            this.requestMembership.Name = "requestMembership";
            this.requestMembership.Size = new System.Drawing.Size(100, 30);
            this.requestMembership.TabIndex = 8;
            this.requestMembership.Text = "申请加群";
            this.requestMembership.UseVisualStyleBackColor = false;
            this.requestMembership.Click += new System.EventHandler(this.RequestMembership_Click);
            // 
            // logonStatus
            // 
            this.logonStatus.AutoSize = true;
            this.logonStatus.Location = new System.Drawing.Point(182, 274);
            this.logonStatus.Name = "logonStatus";
            this.logonStatus.Size = new System.Drawing.Size(66, 15);
            this.logonStatus.TabIndex = 2;
            this.logonStatus.Text = "Checking...";
            // 
            // logonStatusInfo
            // 
            this.logonStatusInfo.AutoSize = true;
            this.logonStatusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logonStatusInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonStatusInfo.Location = new System.Drawing.Point(12, 274);
            this.logonStatusInfo.Name = "logonStatusInfo";
            this.logonStatusInfo.Size = new System.Drawing.Size(164, 15);
            this.logonStatusInfo.TabIndex = 1;
            this.logonStatusInfo.Text = "检查账号是否是群成员中:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ATGate.Properties.Resources.BG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QQLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.qqLogonPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QQLogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = this.ProductName;
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser qqLogonPanel;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label logonStatusInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logonStatus;
        private System.Windows.Forms.Button requestMembership;
    }
}