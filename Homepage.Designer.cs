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
            this.btn_close = new System.Windows.Forms.Button();
            this.pb_title_disct = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.Button();
            this.pb_ctrl_bg = new System.Windows.Forms.PictureBox();
            this.pb_title_notification = new System.Windows.Forms.PictureBox();
            this.lb_notification = new System.Windows.Forms.Label();
            this.pb_text_delay = new System.Windows.Forms.PictureBox();
            this.pb_divider = new System.Windows.Forms.PictureBox();
            this.cb_use_cp_mode = new System.Windows.Forms.CheckBox();
            this.lb_use_cp_mode_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title_disct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ctrl_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title_notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_text_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_divider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start_game
            // 
            this.btn_start_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_start_game.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start_game.Image = ((System.Drawing.Image)(resources.GetObject("btn_start_game.Image")));
            this.btn_start_game.Location = new System.Drawing.Point(261, 430);
            this.btn_start_game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(367, 64);
            this.btn_start_game.TabIndex = 5;
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.Btn_start_game_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Image = global::ATGate.Properties.Resources.register_btn;
            this.btn_register.Location = new System.Drawing.Point(29, 402);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(123, 92);
            this.btn_register.TabIndex = 6;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Location = new System.Drawing.Point(861, 94);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(19, 68);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "常见问题";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // lb_startGameStatus
            // 
            this.lb_startGameStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_startGameStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_startGameStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_startGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_startGameStatus.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_startGameStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_startGameStatus.Image = global::ATGate.Properties.Resources.min_btn;
            this.lb_startGameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_startGameStatus.Location = new System.Drawing.Point(261, 392);
            this.lb_startGameStatus.Name = "lb_startGameStatus";
            this.lb_startGameStatus.Size = new System.Drawing.Size(367, 36);
            this.lb_startGameStatus.TabIndex = 9;
            this.lb_startGameStatus.Text = "加载游戏中，先喝口水吧。。。";
            this.lb_startGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_startGameStatus.UseWaitCursor = true;
            this.lb_startGameStatus.Visible = false;
            // 
            // lv_serverlist
            // 
            this.lv_serverlist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_serverlist.BackColor = System.Drawing.Color.White;
            this.lv_serverlist.BackgroundImage = global::ATGate.Properties.Resources.table_bg;
            this.lv_serverlist.BackgroundImageTiled = true;
            this.lv_serverlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_serverlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.分区,
            this.延迟,
            this.操作});
            this.lv_serverlist.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_serverlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_serverlist.FullRowSelect = true;
            this.lv_serverlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_serverlist.HideSelection = false;
            this.lv_serverlist.LabelWrap = false;
            this.lv_serverlist.Location = new System.Drawing.Point(151, 132);
            this.lv_serverlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_serverlist.MultiSelect = false;
            this.lv_serverlist.Name = "lv_serverlist";
            this.lv_serverlist.Size = new System.Drawing.Size(370, 152);
            this.lv_serverlist.TabIndex = 11;
            this.lv_serverlist.UseCompatibleStateImageBehavior = false;
            this.lv_serverlist.View = System.Windows.Forms.View.Details;
            this.lv_serverlist.SelectedIndexChanged += new System.EventHandler(this.Lv_serverlist_SelectedIndexChanged);
            // 
            // 分区
            // 
            this.分区.Text = "";
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
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(858, 37);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 28);
            this.btn_close.TabIndex = 12;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // pb_title_disct
            // 
            this.pb_title_disct.BackColor = System.Drawing.Color.Transparent;
            this.pb_title_disct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_title_disct.Image = global::ATGate.Properties.Resources.Title_District;
            this.pb_title_disct.Location = new System.Drawing.Point(151, 72);
            this.pb_title_disct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_title_disct.Name = "pb_title_disct";
            this.pb_title_disct.Size = new System.Drawing.Size(370, 85);
            this.pb_title_disct.TabIndex = 13;
            this.pb_title_disct.TabStop = false;
            this.pb_title_disct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // min_btn
            // 
            this.min_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.min_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_btn.BackgroundImage")));
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.min_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.min_btn.FlatAppearance.BorderSize = 0;
            this.min_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.min_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_btn.ForeColor = System.Drawing.Color.Black;
            this.min_btn.Location = new System.Drawing.Point(858, 67);
            this.min_btn.Margin = new System.Windows.Forms.Padding(0);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(24, 25);
            this.min_btn.TabIndex = 14;
            this.min_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.min_btn.UseVisualStyleBackColor = false;
            this.min_btn.Click += new System.EventHandler(this.Min_btn_Click);
            // 
            // pb_ctrl_bg
            // 
            this.pb_ctrl_bg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_ctrl_bg.BackColor = System.Drawing.Color.Transparent;
            this.pb_ctrl_bg.BackgroundImage = global::ATGate.Properties.Resources.controls_bg;
            this.pb_ctrl_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ctrl_bg.Location = new System.Drawing.Point(852, 20);
            this.pb_ctrl_bg.Name = "pb_ctrl_bg";
            this.pb_ctrl_bg.Size = new System.Drawing.Size(36, 160);
            this.pb_ctrl_bg.TabIndex = 15;
            this.pb_ctrl_bg.TabStop = false;
            this.pb_ctrl_bg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // pb_title_notification
            // 
            this.pb_title_notification.BackColor = System.Drawing.Color.Transparent;
            this.pb_title_notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_title_notification.Image = global::ATGate.Properties.Resources.text_notification;
            this.pb_title_notification.Location = new System.Drawing.Point(553, 102);
            this.pb_title_notification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_title_notification.Name = "pb_title_notification";
            this.pb_title_notification.Size = new System.Drawing.Size(90, 46);
            this.pb_title_notification.TabIndex = 16;
            this.pb_title_notification.TabStop = false;
            this.pb_title_notification.Visible = false;
            this.pb_title_notification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // lb_notification
            // 
            this.lb_notification.AutoSize = true;
            this.lb_notification.BackColor = System.Drawing.Color.Transparent;
            this.lb_notification.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_notification.Location = new System.Drawing.Point(549, 159);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(46, 21);
            this.lb_notification.TabIndex = 17;
            this.lb_notification.Text = "...";
            this.lb_notification.Visible = false;
            this.lb_notification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // pb_text_delay
            // 
            this.pb_text_delay.BackColor = System.Drawing.Color.Transparent;
            this.pb_text_delay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_text_delay.Image = global::ATGate.Properties.Resources.text_delay;
            this.pb_text_delay.Location = new System.Drawing.Point(368, 121);
            this.pb_text_delay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_text_delay.Name = "pb_text_delay";
            this.pb_text_delay.Size = new System.Drawing.Size(33, 16);
            this.pb_text_delay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_text_delay.TabIndex = 18;
            this.pb_text_delay.TabStop = false;
            this.pb_text_delay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowMoveWindow_MouseDown);
            // 
            // pb_divider
            // 
            this.pb_divider.BackColor = System.Drawing.Color.Transparent;
            this.pb_divider.Image = global::ATGate.Properties.Resources.divider;
            this.pb_divider.Location = new System.Drawing.Point(531, 101);
            this.pb_divider.Name = "pb_divider";
            this.pb_divider.Size = new System.Drawing.Size(10, 271);
            this.pb_divider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_divider.TabIndex = 19;
            this.pb_divider.TabStop = false;
            // 
            // cb_use_cp_mode
            // 
            this.cb_use_cp_mode.AutoSize = true;
            this.cb_use_cp_mode.BackColor = System.Drawing.Color.Transparent;
            this.cb_use_cp_mode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_use_cp_mode.FlatAppearance.BorderSize = 0;
            this.cb_use_cp_mode.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_use_cp_mode.Location = new System.Drawing.Point(655, 454);
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
            this.lb_use_cp_mode_info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lb_use_cp_mode_info.Location = new System.Drawing.Point(679, 454);
            this.lb_use_cp_mode_info.Name = "lb_use_cp_mode_info";
            this.lb_use_cp_mode_info.Size = new System.Drawing.Size(85, 12);
            this.lb_use_cp_mode_info.TabIndex = 21;
            this.lb_use_cp_mode_info.Text = "使用本地开启模式";
            this.lb_use_cp_mode_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_use_cp_mode_info.Click += new System.EventHandler(this.lb_use_cp_mode_info_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::ATGate.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.lb_use_cp_mode_info);
            this.Controls.Add(this.cb_use_cp_mode);
            this.Controls.Add(this.pb_text_delay);
            this.Controls.Add(this.pb_title_disct);
            this.Controls.Add(this.lv_serverlist);
            this.Controls.Add(this.lb_startGameStatus);
            this.Controls.Add(this.pb_divider);
            this.Controls.Add(this.lb_notification);
            this.Controls.Add(this.pb_title_notification);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.pb_ctrl_bg);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_start_game);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_title_disct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ctrl_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title_notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_text_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_divider)).EndInit();
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
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pb_title_disct;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.PictureBox pb_ctrl_bg;
        private System.Windows.Forms.PictureBox pb_title_notification;
        private System.Windows.Forms.Label lb_notification;
        private System.Windows.Forms.PictureBox pb_text_delay;
        private System.Windows.Forms.PictureBox pb_divider;
        private System.Windows.Forms.CheckBox cb_use_cp_mode;
        private System.Windows.Forms.Label lb_use_cp_mode_info;
    }
}

