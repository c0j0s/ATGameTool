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
            this.lb_notice_board = new System.Windows.Forms.ListBox();
            this.lb_startGameStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusLight)).BeginInit();
            this.SuspendLayout();
            // 
            // server_status
            // 
            this.server_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.server_status.AutoSize = true;
            this.server_status.BackColor = System.Drawing.Color.Transparent;
            this.server_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.server_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_status.Location = new System.Drawing.Point(389, 10);
            this.server_status.Margin = new System.Windows.Forms.Padding(0);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(85, 15);
            this.server_status.TabIndex = 3;
            this.server_status.Text = "服务器未连接";
            this.server_status.Click += new System.EventHandler(this.Server_status_Click);
            // 
            // serverStatusLight
            // 
            this.serverStatusLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverStatusLight.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusLight.Image = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.InitialImage = global::ATGate.Properties.Resources.server_offline;
            this.serverStatusLight.Location = new System.Drawing.Point(375, 10);
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
            this.btn_start_game.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start_game.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_start_game.FlatAppearance.BorderSize = 3;
            this.btn_start_game.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start_game.Location = new System.Drawing.Point(375, 160);
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
            this.btn_register.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_register.FlatAppearance.BorderSize = 3;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(375, 196);
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
            this.btn_about.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_about.FlatAppearance.BorderSize = 3;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(374, 232);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(100, 30);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "关于";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // lb_notice_board
            // 
            this.lb_notice_board.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_notice_board.BackColor = System.Drawing.SystemColors.Window;
            this.lb_notice_board.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_notice_board.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notice_board.FormattingEnabled = true;
            this.lb_notice_board.ItemHeight = 25;
            this.lb_notice_board.Location = new System.Drawing.Point(10, 10);
            this.lb_notice_board.Margin = new System.Windows.Forms.Padding(0);
            this.lb_notice_board.MultiColumn = true;
            this.lb_notice_board.Name = "lb_notice_board";
            this.lb_notice_board.Size = new System.Drawing.Size(350, 202);
            this.lb_notice_board.TabIndex = 8;
            this.lb_notice_board.Visible = false;
            // 
            // lb_startGameStatus
            // 
            this.lb_startGameStatus.AutoSize = true;
            this.lb_startGameStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_startGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_startGameStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startGameStatus.Image = global::ATGate.Properties.Resources.server_online;
            this.lb_startGameStatus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_startGameStatus.Location = new System.Drawing.Point(13, 228);
            this.lb_startGameStatus.Name = "lb_startGameStatus";
            this.lb_startGameStatus.Size = new System.Drawing.Size(257, 30);
            this.lb_startGameStatus.TabIndex = 9;
            this.lb_startGameStatus.Text = "    努力启动游戏中。。。";
            this.lb_startGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_startGameStatus.Visible = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ATGate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.lb_startGameStatus);
            this.Controls.Add(this.lb_notice_board);
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
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = this.ProductName;
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
        private System.Windows.Forms.ListBox lb_notice_board;
        private System.Windows.Forms.Label lb_startGameStatus;
    }
}

