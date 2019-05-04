﻿namespace ATDBMerger
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
            this.Gb_config = new System.Windows.Forms.GroupBox();
            this.Btn_db_config_disconnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_db_config_connect = new System.Windows.Forms.Button();
            this.Tlp_database_config = new System.Windows.Forms.TableLayoutPanel();
            this.Gb_config_b = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Tb_db_b_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_db_b_adb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_db_b_ddb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Tb_db_b_password = new System.Windows.Forms.TextBox();
            this.Tb_db_b_login = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Tb_db_b_port = new System.Windows.Forms.TextBox();
            this.Gb_config_a = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tb_db_a_ip = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Tb_db_a_adb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Tb_db_a_ddb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_db_a_password = new System.Windows.Forms.TextBox();
            this.Tb_db_a_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_db_a_port = new System.Windows.Forms.TextBox();
            this.Gb_db_prepare = new System.Windows.Forms.GroupBox();
            this.Tb_prepare_output = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cb_duplicate_character_add_suffix = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Tb_duplicate_charac_suffix = new System.Windows.Forms.TextBox();
            this.Lb_db_b_charac_duplicate_count = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_prepare_db_b_data = new System.Windows.Forms.Button();
            this.Lb_db_b_charac_count = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lb_db_a_charac_max_id_hex = new System.Windows.Forms.Label();
            this.Lb_db_b_duplicate_account_count = new System.Windows.Forms.Label();
            this.Lb_db_b_account_count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_download_db_b = new System.Windows.Forms.Button();
            this.Gb_db_merge = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_duplicate_account_add_suffix = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Tb_duplicate_account_suffix = new System.Windows.Forms.TextBox();
            this.Tb_db_a_charac_max_id_int = new System.Windows.Forms.TextBox();
            this.Gb_config.SuspendLayout();
            this.Tlp_database_config.SuspendLayout();
            this.Gb_config_b.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Gb_config_a.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Gb_db_prepare.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Gb_db_merge.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_config
            // 
            this.Gb_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_config.Controls.Add(this.Btn_db_config_disconnect);
            this.Gb_config.Controls.Add(this.label7);
            this.Gb_config.Controls.Add(this.Btn_db_config_connect);
            this.Gb_config.Controls.Add(this.Tlp_database_config);
            this.Gb_config.Location = new System.Drawing.Point(12, 12);
            this.Gb_config.Name = "Gb_config";
            this.Gb_config.Size = new System.Drawing.Size(638, 192);
            this.Gb_config.TabIndex = 0;
            this.Gb_config.TabStop = false;
            this.Gb_config.Text = "1. 配置数据库";
            // 
            // Btn_db_config_disconnect
            // 
            this.Btn_db_config_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_db_config_disconnect.Enabled = false;
            this.Btn_db_config_disconnect.Location = new System.Drawing.Point(477, 163);
            this.Btn_db_config_disconnect.Name = "Btn_db_config_disconnect";
            this.Btn_db_config_disconnect.Size = new System.Drawing.Size(75, 23);
            this.Btn_db_config_disconnect.TabIndex = 4;
            this.Btn_db_config_disconnect.Text = "断开";
            this.Btn_db_config_disconnect.UseVisualStyleBackColor = true;
            this.Btn_db_config_disconnect.Click += new System.EventHandler(this.Btn_db_config_disconnect_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "数据库B将合并到数据库A里";
            // 
            // Btn_db_config_connect
            // 
            this.Btn_db_config_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_db_config_connect.Location = new System.Drawing.Point(557, 163);
            this.Btn_db_config_connect.Name = "Btn_db_config_connect";
            this.Btn_db_config_connect.Size = new System.Drawing.Size(75, 23);
            this.Btn_db_config_connect.TabIndex = 2;
            this.Btn_db_config_connect.Text = "连接";
            this.Btn_db_config_connect.UseVisualStyleBackColor = true;
            this.Btn_db_config_connect.Click += new System.EventHandler(this.Btn_db_config_connect_Click);
            // 
            // Tlp_database_config
            // 
            this.Tlp_database_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tlp_database_config.ColumnCount = 2;
            this.Tlp_database_config.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_database_config.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_database_config.Controls.Add(this.Gb_config_b, 1, 0);
            this.Tlp_database_config.Controls.Add(this.Gb_config_a, 0, 0);
            this.Tlp_database_config.Location = new System.Drawing.Point(6, 19);
            this.Tlp_database_config.Name = "Tlp_database_config";
            this.Tlp_database_config.RowCount = 1;
            this.Tlp_database_config.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_database_config.Size = new System.Drawing.Size(626, 138);
            this.Tlp_database_config.TabIndex = 1;
            // 
            // Gb_config_b
            // 
            this.Gb_config_b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_config_b.Controls.Add(this.tableLayoutPanel3);
            this.Gb_config_b.Location = new System.Drawing.Point(316, 3);
            this.Gb_config_b.Name = "Gb_config_b";
            this.Gb_config_b.Size = new System.Drawing.Size(307, 132);
            this.Gb_config_b.TabIndex = 1;
            this.Gb_config_b.TabStop = false;
            this.Gb_config_b.Text = "数据库B";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_ip, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_adb, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_ddb, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_password, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_login, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label24, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Tb_db_b_port, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 106);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Tb_db_b_ip
            // 
            this.Tb_db_b_ip.Location = new System.Drawing.Point(40, 3);
            this.Tb_db_b_ip.Name = "Tb_db_b_ip";
            this.Tb_db_b_ip.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_b_ip.TabIndex = 11;
            this.Tb_db_b_ip.Text = "61.160.236.57";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "ADB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_b_adb
            // 
            this.Tb_db_b_adb.Location = new System.Drawing.Point(40, 83);
            this.Tb_db_b_adb.Name = "Tb_db_b_adb";
            this.Tb_db_b_adb.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_b_adb.TabIndex = 9;
            this.Tb_db_b_adb.Text = "dl_adb_all";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "DDB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_b_ddb
            // 
            this.Tb_db_b_ddb.Location = new System.Drawing.Point(181, 83);
            this.Tb_db_b_ddb.Name = "Tb_db_b_ddb";
            this.Tb_db_b_ddb.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_b_ddb.TabIndex = 7;
            this.Tb_db_b_ddb.Text = "dl_ddb_1";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 27);
            this.label21.TabIndex = 1;
            this.label21.Text = "密码";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 27);
            this.label22.TabIndex = 0;
            this.label22.Text = "账号";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_b_password
            // 
            this.Tb_db_b_password.Location = new System.Drawing.Point(40, 56);
            this.Tb_db_b_password.Name = "Tb_db_b_password";
            this.Tb_db_b_password.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_b_password.TabIndex = 3;
            this.Tb_db_b_password.Text = "JbcDatabase";
            // 
            // Tb_db_b_login
            // 
            this.Tb_db_b_login.Location = new System.Drawing.Point(40, 29);
            this.Tb_db_b_login.Name = "Tb_db_b_login";
            this.Tb_db_b_login.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_b_login.TabIndex = 2;
            this.Tb_db_b_login.Text = "root";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(144, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 27);
            this.label24.TabIndex = 4;
            this.label24.Text = "端口";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_b_port
            // 
            this.Tb_db_b_port.Location = new System.Drawing.Point(181, 29);
            this.Tb_db_b_port.Name = "Tb_db_b_port";
            this.Tb_db_b_port.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_b_port.TabIndex = 5;
            this.Tb_db_b_port.Text = "3306";
            // 
            // Gb_config_a
            // 
            this.Gb_config_a.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_config_a.Controls.Add(this.tableLayoutPanel2);
            this.Gb_config_a.Location = new System.Drawing.Point(3, 3);
            this.Gb_config_a.Name = "Gb_config_a";
            this.Gb_config_a.Size = new System.Drawing.Size(307, 132);
            this.Gb_config_a.TabIndex = 0;
            this.Gb_config_a.TabStop = false;
            this.Gb_config_a.Text = "数据库A";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_ip, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_adb, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label20, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_ddb, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_password, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_login, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Tb_db_a_port, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Tb_db_a_ip
            // 
            this.Tb_db_a_ip.Location = new System.Drawing.Point(40, 3);
            this.Tb_db_a_ip.Name = "Tb_db_a_ip";
            this.Tb_db_a_ip.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_a_ip.TabIndex = 11;
            this.Tb_db_a_ip.Text = "61.160.236.57";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 26);
            this.label23.TabIndex = 10;
            this.label23.Text = "IP";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 26);
            this.label19.TabIndex = 6;
            this.label19.Text = "ADB";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_a_adb
            // 
            this.Tb_db_a_adb.Location = new System.Drawing.Point(40, 83);
            this.Tb_db_a_adb.Name = "Tb_db_a_adb";
            this.Tb_db_a_adb.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_a_adb.TabIndex = 9;
            this.Tb_db_a_adb.Text = "dl_adb_all";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(144, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 26);
            this.label20.TabIndex = 8;
            this.label20.Text = "DDB";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_a_ddb
            // 
            this.Tb_db_a_ddb.Location = new System.Drawing.Point(181, 83);
            this.Tb_db_a_ddb.Name = "Tb_db_a_ddb";
            this.Tb_db_a_ddb.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_a_ddb.TabIndex = 7;
            this.Tb_db_a_ddb.Text = "dl_ddb_1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_a_password
            // 
            this.Tb_db_a_password.Location = new System.Drawing.Point(40, 56);
            this.Tb_db_a_password.Name = "Tb_db_a_password";
            this.Tb_db_a_password.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_a_password.TabIndex = 3;
            this.Tb_db_a_password.Text = "JbcDatabase";
            // 
            // Tb_db_a_login
            // 
            this.Tb_db_a_login.Location = new System.Drawing.Point(40, 29);
            this.Tb_db_a_login.Name = "Tb_db_a_login";
            this.Tb_db_a_login.Size = new System.Drawing.Size(98, 20);
            this.Tb_db_a_login.TabIndex = 2;
            this.Tb_db_a_login.Text = "root";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_db_a_port
            // 
            this.Tb_db_a_port.Location = new System.Drawing.Point(181, 29);
            this.Tb_db_a_port.Name = "Tb_db_a_port";
            this.Tb_db_a_port.Size = new System.Drawing.Size(97, 20);
            this.Tb_db_a_port.TabIndex = 5;
            this.Tb_db_a_port.Text = "3306";
            // 
            // Gb_db_prepare
            // 
            this.Gb_db_prepare.Controls.Add(this.Tb_db_a_charac_max_id_int);
            this.Gb_db_prepare.Controls.Add(this.groupBox1);
            this.Gb_db_prepare.Controls.Add(this.Tb_prepare_output);
            this.Gb_db_prepare.Controls.Add(this.groupBox6);
            this.Gb_db_prepare.Controls.Add(this.Lb_db_b_charac_duplicate_count);
            this.Gb_db_prepare.Controls.Add(this.label17);
            this.Gb_db_prepare.Controls.Add(this.Btn_prepare_db_b_data);
            this.Gb_db_prepare.Controls.Add(this.Lb_db_b_charac_count);
            this.Gb_db_prepare.Controls.Add(this.label15);
            this.Gb_db_prepare.Controls.Add(this.Lb_db_a_charac_max_id_hex);
            this.Gb_db_prepare.Controls.Add(this.Lb_db_b_duplicate_account_count);
            this.Gb_db_prepare.Controls.Add(this.Lb_db_b_account_count);
            this.Gb_db_prepare.Controls.Add(this.label10);
            this.Gb_db_prepare.Controls.Add(this.label9);
            this.Gb_db_prepare.Controls.Add(this.label8);
            this.Gb_db_prepare.Controls.Add(this.Btn_download_db_b);
            this.Gb_db_prepare.Location = new System.Drawing.Point(12, 210);
            this.Gb_db_prepare.Name = "Gb_db_prepare";
            this.Gb_db_prepare.Size = new System.Drawing.Size(638, 219);
            this.Gb_db_prepare.TabIndex = 1;
            this.Gb_db_prepare.TabStop = false;
            this.Gb_db_prepare.Text = "2. 准备数据库";
            // 
            // Tb_prepare_output
            // 
            this.Tb_prepare_output.Location = new System.Drawing.Point(162, 153);
            this.Tb_prepare_output.Multiline = true;
            this.Tb_prepare_output.Name = "Tb_prepare_output";
            this.Tb_prepare_output.ReadOnly = true;
            this.Tb_prepare_output.Size = new System.Drawing.Size(470, 57);
            this.Tb_prepare_output.TabIndex = 18;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Cb_duplicate_character_add_suffix);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.Tb_duplicate_charac_suffix);
            this.groupBox6.Location = new System.Drawing.Point(463, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(169, 55);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "重复角色";
            // 
            // Cb_duplicate_character_add_suffix
            // 
            this.Cb_duplicate_character_add_suffix.AutoSize = true;
            this.Cb_duplicate_character_add_suffix.Checked = true;
            this.Cb_duplicate_character_add_suffix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_duplicate_character_add_suffix.Enabled = false;
            this.Cb_duplicate_character_add_suffix.Location = new System.Drawing.Point(6, 0);
            this.Cb_duplicate_character_add_suffix.Name = "Cb_duplicate_character_add_suffix";
            this.Cb_duplicate_character_add_suffix.Size = new System.Drawing.Size(110, 17);
            this.Cb_duplicate_character_add_suffix.TabIndex = 14;
            this.Cb_duplicate_character_add_suffix.Text = "重复角色名更改";
            this.Cb_duplicate_character_add_suffix.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "后缀：";
            // 
            // Tb_duplicate_charac_suffix
            // 
            this.Tb_duplicate_charac_suffix.Enabled = false;
            this.Tb_duplicate_charac_suffix.Location = new System.Drawing.Point(60, 26);
            this.Tb_duplicate_charac_suffix.Name = "Tb_duplicate_charac_suffix";
            this.Tb_duplicate_charac_suffix.Size = new System.Drawing.Size(100, 20);
            this.Tb_duplicate_charac_suffix.TabIndex = 15;
            this.Tb_duplicate_charac_suffix.Text = "_B";
            // 
            // Lb_db_b_charac_duplicate_count
            // 
            this.Lb_db_b_charac_duplicate_count.AutoSize = true;
            this.Lb_db_b_charac_duplicate_count.Location = new System.Drawing.Point(325, 105);
            this.Lb_db_b_charac_duplicate_count.Name = "Lb_db_b_charac_duplicate_count";
            this.Lb_db_b_charac_duplicate_count.Size = new System.Drawing.Size(19, 13);
            this.Lb_db_b_charac_duplicate_count.TabIndex = 13;
            this.Lb_db_b_charac_duplicate_count.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(161, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "数据库B游戏角色名重复数：";
            // 
            // Btn_prepare_db_b_data
            // 
            this.Btn_prepare_db_b_data.Enabled = false;
            this.Btn_prepare_db_b_data.Location = new System.Drawing.Point(6, 153);
            this.Btn_prepare_db_b_data.Name = "Btn_prepare_db_b_data";
            this.Btn_prepare_db_b_data.Size = new System.Drawing.Size(149, 23);
            this.Btn_prepare_db_b_data.TabIndex = 11;
            this.Btn_prepare_db_b_data.Text = "准备数据库B数据";
            this.Btn_prepare_db_b_data.UseVisualStyleBackColor = true;
            // 
            // Lb_db_b_charac_count
            // 
            this.Lb_db_b_charac_count.AutoSize = true;
            this.Lb_db_b_charac_count.Location = new System.Drawing.Point(325, 81);
            this.Lb_db_b_charac_count.Name = "Lb_db_b_charac_count";
            this.Lb_db_b_charac_count.Size = new System.Drawing.Size(19, 13);
            this.Lb_db_b_charac_count.TabIndex = 10;
            this.Lb_db_b_charac_count.Text = "00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(161, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "数据库B游戏角色数：";
            // 
            // Lb_db_a_charac_max_id_hex
            // 
            this.Lb_db_a_charac_max_id_hex.AutoSize = true;
            this.Lb_db_a_charac_max_id_hex.Location = new System.Drawing.Point(368, 57);
            this.Lb_db_a_charac_max_id_hex.Name = "Lb_db_a_charac_max_id_hex";
            this.Lb_db_a_charac_max_id_hex.Size = new System.Drawing.Size(67, 13);
            this.Lb_db_a_charac_max_id_hex.TabIndex = 8;
            this.Lb_db_a_charac_max_id_hex.Text = "0000000000";
            // 
            // Lb_db_b_duplicate_account_count
            // 
            this.Lb_db_b_duplicate_account_count.AutoSize = true;
            this.Lb_db_b_duplicate_account_count.Location = new System.Drawing.Point(410, 23);
            this.Lb_db_b_duplicate_account_count.Name = "Lb_db_b_duplicate_account_count";
            this.Lb_db_b_duplicate_account_count.Size = new System.Drawing.Size(19, 13);
            this.Lb_db_b_duplicate_account_count.TabIndex = 7;
            this.Lb_db_b_duplicate_account_count.Text = "00";
            // 
            // Lb_db_b_account_count
            // 
            this.Lb_db_b_account_count.AutoSize = true;
            this.Lb_db_b_account_count.Location = new System.Drawing.Point(256, 24);
            this.Lb_db_b_account_count.Name = "Lb_db_b_account_count";
            this.Lb_db_b_account_count.Size = new System.Drawing.Size(19, 13);
            this.Lb_db_b_account_count.TabIndex = 6;
            this.Lb_db_b_account_count.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "重复账号数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "数据库A游戏角色最大ID：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "已提取账号数：";
            // 
            // Btn_download_db_b
            // 
            this.Btn_download_db_b.Location = new System.Drawing.Point(6, 19);
            this.Btn_download_db_b.Name = "Btn_download_db_b";
            this.Btn_download_db_b.Size = new System.Drawing.Size(149, 23);
            this.Btn_download_db_b.TabIndex = 0;
            this.Btn_download_db_b.Text = "提取数据库B";
            this.Btn_download_db_b.UseVisualStyleBackColor = true;
            this.Btn_download_db_b.Click += new System.EventHandler(this.Btn_download_db_b_Click);
            // 
            // Gb_db_merge
            // 
            this.Gb_db_merge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_db_merge.Controls.Add(this.button6);
            this.Gb_db_merge.Controls.Add(this.button5);
            this.Gb_db_merge.Enabled = false;
            this.Gb_db_merge.Location = new System.Drawing.Point(12, 437);
            this.Gb_db_merge.Name = "Gb_db_merge";
            this.Gb_db_merge.Size = new System.Drawing.Size(638, 54);
            this.Gb_db_merge.TabIndex = 2;
            this.Gb_db_merge.TabStop = false;
            this.Gb_db_merge.Text = "3. 合并数据库";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "导出SQL文件";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "上传到数据库A";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_duplicate_account_add_suffix);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.Tb_duplicate_account_suffix);
            this.groupBox1.Location = new System.Drawing.Point(463, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重复角色";
            // 
            // Cb_duplicate_account_add_suffix
            // 
            this.Cb_duplicate_account_add_suffix.AutoSize = true;
            this.Cb_duplicate_account_add_suffix.Checked = true;
            this.Cb_duplicate_account_add_suffix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_duplicate_account_add_suffix.Enabled = false;
            this.Cb_duplicate_account_add_suffix.Location = new System.Drawing.Point(6, 0);
            this.Cb_duplicate_account_add_suffix.Name = "Cb_duplicate_account_add_suffix";
            this.Cb_duplicate_account_add_suffix.Size = new System.Drawing.Size(98, 17);
            this.Cb_duplicate_account_add_suffix.TabIndex = 14;
            this.Cb_duplicate_account_add_suffix.Text = "重复账号更改";
            this.Cb_duplicate_account_add_suffix.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "后缀：";
            // 
            // Tb_duplicate_account_suffix
            // 
            this.Tb_duplicate_account_suffix.Enabled = false;
            this.Tb_duplicate_account_suffix.Location = new System.Drawing.Point(60, 26);
            this.Tb_duplicate_account_suffix.Name = "Tb_duplicate_account_suffix";
            this.Tb_duplicate_account_suffix.Size = new System.Drawing.Size(100, 20);
            this.Tb_duplicate_account_suffix.TabIndex = 15;
            this.Tb_duplicate_account_suffix.Text = "_B";
            // 
            // Tb_db_a_charac_max_id_int
            // 
            this.Tb_db_a_charac_max_id_int.Enabled = false;
            this.Tb_db_a_charac_max_id_int.Location = new System.Drawing.Point(328, 54);
            this.Tb_db_a_charac_max_id_int.Name = "Tb_db_a_charac_max_id_int";
            this.Tb_db_a_charac_max_id_int.Size = new System.Drawing.Size(34, 20);
            this.Tb_db_a_charac_max_id_int.TabIndex = 19;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 503);
            this.Controls.Add(this.Gb_db_merge);
            this.Controls.Add(this.Gb_db_prepare);
            this.Controls.Add(this.Gb_config);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Homepage";
            this.Text = "AT合区工具";
            this.Gb_config.ResumeLayout(false);
            this.Gb_config.PerformLayout();
            this.Tlp_database_config.ResumeLayout(false);
            this.Gb_config_b.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Gb_config_a.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Gb_db_prepare.ResumeLayout(false);
            this.Gb_db_prepare.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Gb_db_merge.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_config;
        private System.Windows.Forms.TableLayoutPanel Tlp_database_config;
        private System.Windows.Forms.GroupBox Gb_config_b;
        private System.Windows.Forms.GroupBox Gb_config_a;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_db_a_login;
        private System.Windows.Forms.TextBox Tb_db_a_password;
        private System.Windows.Forms.TextBox Tb_db_a_port;
        private System.Windows.Forms.Button Btn_db_config_connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Gb_db_prepare;
        private System.Windows.Forms.Button Btn_download_db_b;
        private System.Windows.Forms.GroupBox Gb_db_merge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lb_db_b_charac_count;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Lb_db_a_charac_max_id_hex;
        private System.Windows.Forms.Label Lb_db_b_duplicate_account_count;
        private System.Windows.Forms.Label Lb_db_b_account_count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Lb_db_b_charac_duplicate_count;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Btn_prepare_db_b_data;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox Cb_duplicate_character_add_suffix;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Tb_duplicate_charac_suffix;
        private System.Windows.Forms.TextBox Tb_prepare_output;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Tb_db_a_adb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Tb_db_a_ddb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Btn_db_config_disconnect;
        private System.Windows.Forms.TextBox Tb_db_a_ip;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Tb_db_b_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_db_b_adb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_db_b_ddb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Tb_db_b_password;
        private System.Windows.Forms.TextBox Tb_db_b_login;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Tb_db_b_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Cb_duplicate_account_add_suffix;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Tb_duplicate_account_suffix;
        private System.Windows.Forms.TextBox Tb_db_a_charac_max_id_int;
    }
}