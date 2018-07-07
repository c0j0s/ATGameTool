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
            this.lb_serverlist_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_serverlist = new System.Windows.Forms.ListView();
            this.分区 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.延迟 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.操作 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // lb_startGameStatus
            // 
            this.lb_startGameStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lb_startGameStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_startGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_startGameStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startGameStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_startGameStatus.Image = global::ATGate.Properties.Resources.server_online;
            this.lb_startGameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_startGameStatus.Location = new System.Drawing.Point(0, 221);
            this.lb_startGameStatus.Name = "lb_startGameStatus";
            this.lb_startGameStatus.Size = new System.Drawing.Size(348, 29);
            this.lb_startGameStatus.TabIndex = 9;
            this.lb_startGameStatus.Text = "     努力启动游戏中。。。";
            this.lb_startGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_startGameStatus.UseWaitCursor = true;
            this.lb_startGameStatus.Visible = false;
            // 
            // lb_serverlist_title
            // 
            this.lb_serverlist_title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb_serverlist_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_serverlist_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_serverlist_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serverlist_title.Location = new System.Drawing.Point(0, 0);
            this.lb_serverlist_title.Name = "lb_serverlist_title";
            this.lb_serverlist_title.Size = new System.Drawing.Size(348, 32);
            this.lb_serverlist_title.TabIndex = 10;
            this.lb_serverlist_title.Text = "服务区";
            this.lb_serverlist_title.Click += new System.EventHandler(this.lb_serverlist_title_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_startGameStatus);
            this.panel1.Controls.Add(this.lv_serverlist);
            this.panel1.Controls.Add(this.lb_serverlist_title);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 252);
            this.panel1.TabIndex = 11;
            // 
            // lv_serverlist
            // 
            this.lv_serverlist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_serverlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_serverlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.分区,
            this.延迟,
            this.操作});
            this.lv_serverlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_serverlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_serverlist.FullRowSelect = true;
            this.lv_serverlist.GridLines = true;
            this.lv_serverlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_serverlist.HideSelection = false;
            this.lv_serverlist.LabelWrap = false;
            this.lv_serverlist.Location = new System.Drawing.Point(0, 32);
            this.lv_serverlist.MultiSelect = false;
            this.lv_serverlist.Name = "lv_serverlist";
            this.lv_serverlist.Size = new System.Drawing.Size(348, 218);
            this.lv_serverlist.TabIndex = 11;
            this.lv_serverlist.UseCompatibleStateImageBehavior = false;
            this.lv_serverlist.View = System.Windows.Forms.View.Details;
            this.lv_serverlist.SelectedIndexChanged += new System.EventHandler(this.Lv_serverlist_SelectedIndexChanged);
            // 
            // 分区
            // 
            this.分区.Text = "分区";
            this.分区.Width = 180;
            // 
            // 延迟
            // 
            this.延迟.Text = "延迟";
            this.延迟.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.延迟.Width = 70;
            // 
            // 操作
            // 
            this.操作.Text = "操作";
            this.操作.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.操作.Width = 95;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ATGate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_start_game);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = this.ProductName;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lb_startGameStatus;
        private System.Windows.Forms.Label lb_serverlist_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_serverlist;
        private System.Windows.Forms.ColumnHeader 分区;
        private System.Windows.Forms.ColumnHeader 操作;
        private System.Windows.Forms.ColumnHeader 延迟;
    }
}

