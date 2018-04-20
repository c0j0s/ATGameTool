using System.Reflection;

namespace ATGate
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.server_status = new System.Windows.Forms.Label();
            this.serverStatusLight = new System.Windows.Forms.PictureBox();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusLight)).BeginInit();
            this.SuspendLayout();
            // 
            // server_status
            // 
            this.server_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.server_status.AutoSize = true;
            this.server_status.BackColor = System.Drawing.Color.Transparent;
            this.server_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.server_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_status.Location = new System.Drawing.Point(387, 9);
            this.server_status.Margin = new System.Windows.Forms.Padding(0);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(85, 15);
            this.server_status.TabIndex = 3;
            this.server_status.Text = "服务器未连接";
            this.server_status.Click += new System.EventHandler(this.Server_status_Click);
            // 
            // serverStatusLight
            // 
            this.serverStatusLight.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusLight.Image = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.InitialImage = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.Location = new System.Drawing.Point(372, 9);
            this.serverStatusLight.Margin = new System.Windows.Forms.Padding(0);
            this.serverStatusLight.Name = "serverStatusLight";
            this.serverStatusLight.Size = new System.Drawing.Size(14, 14);
            this.serverStatusLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serverStatusLight.TabIndex = 4;
            this.serverStatusLight.TabStop = false;
            // 
            // btn_start_game
            // 
            this.btn_start_game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start_game.BackColor = System.Drawing.SystemColors.Control;
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.Location = new System.Drawing.Point(372, 159);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(100, 30);
            this.btn_start_game.TabIndex = 5;
            this.btn_start_game.Text = "进入游戏";
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.Btn_start_game_Click);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.BackColor = System.Drawing.SystemColors.Control;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.Location = new System.Drawing.Point(372, 195);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(100, 30);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "注册账号";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.BackColor = System.Drawing.SystemColors.Control;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.Location = new System.Drawing.Point(372, 231);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(100, 30);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "关于";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATGate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 273);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.serverStatusLight);
            this.Controls.Add(this.server_status);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "逍遥问道启动器";
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.PictureBox serverStatusLight;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_about;
    }
}

