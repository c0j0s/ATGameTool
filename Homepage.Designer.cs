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
            this.btn_start_game = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.lb_startGameStatus = new System.Windows.Forms.Label();
            this.lv_serverlist = new System.Windows.Forms.ListView();
            this.分区 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.延迟 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.操作 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_use_cp_mode = new System.Windows.Forms.CheckBox();
            this.lb_use_cp_mode_info = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_skip_ping = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_client_version = new System.Windows.Forms.Label();
            this.btn_create_shortcut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start_game
            // 
            this.btn_start_game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start_game.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start_game.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_start_game.FlatAppearance.BorderSize = 3;
            this.btn_start_game.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start_game.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_start_game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start_game.Location = new System.Drawing.Point(414, 203);
            this.btn_start_game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(159, 39);
            this.btn_start_game.TabIndex = 5;
            this.btn_start_game.Text = "开始游戏";
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.Btn_start_game_Click);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_register.FlatAppearance.BorderSize = 3;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Location = new System.Drawing.Point(414, 246);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(159, 39);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "注册账号";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.Black;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_about.Location = new System.Drawing.Point(414, 69);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(159, 36);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "常见问题";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // lb_startGameStatus
            // 
            this.lb_startGameStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_startGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_startGameStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startGameStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_startGameStatus.Image = global::ATGate.Properties.Resources.min_btn;
            this.lb_startGameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_startGameStatus.Location = new System.Drawing.Point(-62, 259);
            this.lb_startGameStatus.Name = "lb_startGameStatus";
            this.lb_startGameStatus.Size = new System.Drawing.Size(682, 39);
            this.lb_startGameStatus.TabIndex = 9;
            this.lb_startGameStatus.Text = "加载游戏中，先喝口水吧。。。";
            this.lb_startGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_startGameStatus.UseWaitCursor = true;
            this.lb_startGameStatus.Visible = false;
            this.lb_startGameStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // lv_serverlist
            // 
            this.lv_serverlist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_serverlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_serverlist.BackColor = System.Drawing.Color.White;
            this.lv_serverlist.BackgroundImageTiled = true;
            this.lv_serverlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_serverlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.分区,
            this.延迟,
            this.操作});
            this.lv_serverlist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_serverlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_serverlist.FullRowSelect = true;
            this.lv_serverlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_serverlist.HideSelection = false;
            this.lv_serverlist.LabelWrap = false;
            this.lv_serverlist.Location = new System.Drawing.Point(10, 57);
            this.lv_serverlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_serverlist.MultiSelect = false;
            this.lv_serverlist.Name = "lv_serverlist";
            this.lv_serverlist.Size = new System.Drawing.Size(392, 228);
            this.lv_serverlist.TabIndex = 11;
            this.lv_serverlist.UseCompatibleStateImageBehavior = false;
            this.lv_serverlist.View = System.Windows.Forms.View.Details;
            this.lv_serverlist.SelectedIndexChanged += new System.EventHandler(this.Lv_serverlist_SelectedIndexChanged);
            // 
            // 分区
            // 
            this.分区.Text = "分区";
            this.分区.Width = 200;
            // 
            // 延迟
            // 
            this.延迟.Text = "延迟";
            this.延迟.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.延迟.Width = 75;
            // 
            // 操作
            // 
            this.操作.Text = "操作";
            this.操作.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.操作.Width = 95;
            // 
            // cb_use_cp_mode
            // 
            this.cb_use_cp_mode.AutoSize = true;
            this.cb_use_cp_mode.BackColor = System.Drawing.Color.Transparent;
            this.cb_use_cp_mode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_use_cp_mode.FlatAppearance.BorderSize = 0;
            this.cb_use_cp_mode.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_use_cp_mode.Location = new System.Drawing.Point(8, 30);
            this.cb_use_cp_mode.Name = "cb_use_cp_mode";
            this.cb_use_cp_mode.Size = new System.Drawing.Size(15, 14);
            this.cb_use_cp_mode.TabIndex = 20;
            this.cb_use_cp_mode.UseVisualStyleBackColor = false;
            // 
            // lb_use_cp_mode_info
            // 
            this.lb_use_cp_mode_info.AutoSize = true;
            this.lb_use_cp_mode_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_use_cp_mode_info.Cursor = System.Windows.Forms.Cursors.Help;
            this.lb_use_cp_mode_info.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_use_cp_mode_info.Location = new System.Drawing.Point(23, 25);
            this.lb_use_cp_mode_info.Name = "lb_use_cp_mode_info";
            this.lb_use_cp_mode_info.Size = new System.Drawing.Size(93, 19);
            this.lb_use_cp_mode_info.TabIndex = 21;
            this.lb_use_cp_mode_info.Text = "使用本地模式";
            this.lb_use_cp_mode_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_use_cp_mode_info.Click += new System.EventHandler(this.lb_use_cp_mode_info_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cb_skip_ping);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_use_cp_mode);
            this.groupBox2.Controls.Add(this.lb_use_cp_mode_info);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(414, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 81);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选项";
            // 
            // cb_skip_ping
            // 
            this.cb_skip_ping.AutoSize = true;
            this.cb_skip_ping.BackColor = System.Drawing.Color.Transparent;
            this.cb_skip_ping.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_skip_ping.FlatAppearance.BorderSize = 0;
            this.cb_skip_ping.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_skip_ping.Location = new System.Drawing.Point(8, 47);
            this.cb_skip_ping.Name = "cb_skip_ping";
            this.cb_skip_ping.Size = new System.Drawing.Size(154, 23);
            this.cb_skip_ping.TabIndex = 22;
            this.cb_skip_ping.Text = "跳过服务器状态检测";
            this.cb_skip_ping.UseVisualStyleBackColor = false;
            this.cb_skip_ping.CheckedChanged += new System.EventHandler(this.cb_skip_ping_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("KaiTi", 10.5F);
            this.label3.Location = new System.Drawing.Point(-80, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 23;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_client_version
            // 
            this.lb_client_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_client_version.AutoSize = true;
            this.lb_client_version.BackColor = System.Drawing.Color.Transparent;
            this.lb_client_version.Font = new System.Drawing.Font("KaiTi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_client_version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_client_version.Location = new System.Drawing.Point(411, 12);
            this.lb_client_version.Name = "lb_client_version";
            this.lb_client_version.Size = new System.Drawing.Size(70, 14);
            this.lb_client_version.TabIndex = 4;
            this.lb_client_version.Text = "0.0.0.000";
            this.lb_client_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_client_version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // btn_create_shortcut
            // 
            this.btn_create_shortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_shortcut.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_shortcut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_create_shortcut.FlatAppearance.BorderSize = 0;
            this.btn_create_shortcut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_create_shortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_create_shortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_shortcut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_shortcut.ForeColor = System.Drawing.Color.Tomato;
            this.btn_create_shortcut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_create_shortcut.Location = new System.Drawing.Point(416, 28);
            this.btn_create_shortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create_shortcut.Name = "btn_create_shortcut";
            this.btn_create_shortcut.Size = new System.Drawing.Size(160, 37);
            this.btn_create_shortcut.TabIndex = 24;
            this.btn_create_shortcut.Text = "添加快捷方式";
            this.btn_create_shortcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_create_shortcut.UseVisualStyleBackColor = false;
            this.btn_create_shortcut.Click += new System.EventHandler(this.btn_create_shortcut_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 275);
            this.label4.TabIndex = 25;
            this.label4.Text = "服务区";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::ATGate.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 297);
            this.Controls.Add(this.lb_startGameStatus);
            this.Controls.Add(this.lv_serverlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_create_shortcut);
            this.Controls.Add(this.lb_client_version);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_about);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = this.ProductName;
            this.TransparencyKey = System.Drawing.SystemColors.ScrollBar;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lb_startGameStatus;
        private System.Windows.Forms.ListView lv_serverlist;
        private System.Windows.Forms.ColumnHeader 分区;
        private System.Windows.Forms.ColumnHeader 操作;
        private System.Windows.Forms.ColumnHeader 延迟;
        private System.Windows.Forms.CheckBox cb_use_cp_mode;
        private System.Windows.Forms.Label lb_use_cp_mode_info;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_skip_ping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_client_version;
        private System.Windows.Forms.Button btn_create_shortcut;
        private System.Windows.Forms.Label label4;
    }
}

