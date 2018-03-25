﻿using System.Reflection;

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
            this.btn_start_game = new System.Windows.Forms.Button();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.server_status = new System.Windows.Forms.Label();
            this.serverStatusLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusLight)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start_game
            // 
            this.btn_start_game.BackColor = System.Drawing.Color.White;
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Image = global::ATGate.Properties.Resources.btn_start_game;
            this.btn_start_game.Location = new System.Drawing.Point(178, 295);
            this.btn_start_game.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(104, 24);
            this.btn_start_game.TabIndex = 0;
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.Btn_start_game_Click);
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.BackColor = System.Drawing.Color.White;
            this.labelAppVersion.Location = new System.Drawing.Point(306, 13);
            this.labelAppVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(126, 15);
            this.labelAppVersion.TabIndex = 1;
            this.labelAppVersion.Text = "版本：15.0.0.0 开发版";
            // 
            // btn_about
            // 
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_about.Location = new System.Drawing.Point(380, 295);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(52, 24);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "关于";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // server_status
            // 
            this.server_status.AutoSize = true;
            this.server_status.BackColor = System.Drawing.Color.Transparent;
            this.server_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_status.Location = new System.Drawing.Point(28, 11);
            this.server_status.Margin = new System.Windows.Forms.Padding(0);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(79, 15);
            this.server_status.TabIndex = 3;
            this.server_status.Text = "服务器未连接";
            this.server_status.Click += new System.EventHandler(this.Server_status_Click);
            // 
            // serverStatusLight
            // 
            this.serverStatusLight.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusLight.Image = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.InitialImage = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.Location = new System.Drawing.Point(12, 13);
            this.serverStatusLight.Margin = new System.Windows.Forms.Padding(0);
            this.serverStatusLight.Name = "serverStatusLight";
            this.serverStatusLight.Size = new System.Drawing.Size(14, 14);
            this.serverStatusLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serverStatusLight.TabIndex = 4;
            this.serverStatusLight.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATGate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(444, 341);
            this.Controls.Add(this.serverStatusLight);
            this.Controls.Add(this.server_status);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.btn_start_game);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "逍遥问道启动器";
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.PictureBox serverStatusLight;
    }
}

