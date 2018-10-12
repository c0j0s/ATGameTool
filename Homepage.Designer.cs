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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_serverlist = new System.Windows.Forms.ListView();
            this.分区 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.延迟 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.操作 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start_game
            // 
            this.btn_start_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_start_game.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start_game.Image = global::ATGate.Properties.Resources.startgame_btn;
            this.btn_start_game.Location = new System.Drawing.Point(220, 420);
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
            this.btn_register.Location = new System.Drawing.Point(-3, 391);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(131, 92);
            this.btn_register.TabIndex = 6;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.ForeColor = System.Drawing.Color.Black;
            this.btn_about.Location = new System.Drawing.Point(745, 398);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(51, 30);
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
            this.lb_startGameStatus.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startGameStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_startGameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_startGameStatus.Location = new System.Drawing.Point(0, 185);
            this.lb_startGameStatus.Name = "lb_startGameStatus";
            this.lb_startGameStatus.Size = new System.Drawing.Size(370, 40);
            this.lb_startGameStatus.TabIndex = 9;
            this.lb_startGameStatus.Text = "努力启动游戏中。。。";
            this.lb_startGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_startGameStatus.UseWaitCursor = true;
            this.lb_startGameStatus.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lb_startGameStatus);
            this.panel1.Controls.Add(this.lv_serverlist);
            this.panel1.Location = new System.Drawing.Point(101, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 225);
            this.panel1.TabIndex = 11;
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
            this.lv_serverlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_serverlist.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_serverlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_serverlist.FullRowSelect = true;
            this.lv_serverlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_serverlist.HideSelection = false;
            this.lv_serverlist.LabelWrap = false;
            this.lv_serverlist.Location = new System.Drawing.Point(0, 0);
            this.lv_serverlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_serverlist.MultiSelect = false;
            this.lv_serverlist.Name = "lv_serverlist";
            this.lv_serverlist.Size = new System.Drawing.Size(370, 225);
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
            this.延迟.Width = 70;
            // 
            // 操作
            // 
            this.操作.Text = "操作";
            this.操作.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.操作.Width = 100;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::ATGate.Properties.Resources.Close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(809, -8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 48);
            this.btn_close.TabIndex = 12;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ATGate.Properties.Resources.Title_District;
            this.pictureBox1.Location = new System.Drawing.Point(56, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::ATGate.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(856, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_about);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lb_startGameStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_serverlist;
        private System.Windows.Forms.ColumnHeader 分区;
        private System.Windows.Forms.ColumnHeader 操作;
        private System.Windows.Forms.ColumnHeader 延迟;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

