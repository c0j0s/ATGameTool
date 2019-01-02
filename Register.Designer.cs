namespace ATGate
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_limit_info = new System.Windows.Forms.Label();
            this.lb_veri_code_1 = new System.Windows.Forms.Label();
            this.tb_id_code = new System.Windows.Forms.TextBox();
            this.lb_veri_code_2 = new System.Windows.Forms.Label();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_register.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_register.FlatAppearance.BorderSize = 3;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(19, 261);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(136, 42);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(19, 44);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(276, 31);
            this.tb_username.TabIndex = 1;
            this.tb_username.Enter += new System.EventHandler(this.Tb_username_Enter);
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_username_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码/新密码：";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(19, 116);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(276, 31);
            this.tb_password.TabIndex = 3;
            this.tb_password.Enter += new System.EventHandler(this.Tb_password_Enter);
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_password_KeyPress);
            // 
            // lb_limit_info
            // 
            this.lb_limit_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_limit_info.AutoSize = true;
            this.lb_limit_info.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_limit_info.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_limit_info.Location = new System.Drawing.Point(19, 311);
            this.lb_limit_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_limit_info.Name = "lb_limit_info";
            this.lb_limit_info.Size = new System.Drawing.Size(279, 19);
            this.lb_limit_info.TabIndex = 5;
            this.lb_limit_info.Text = "一台电脑不可注册超过5个账号";
            // 
            // lb_veri_code_1
            // 
            this.lb_veri_code_1.AutoSize = true;
            this.lb_veri_code_1.Location = new System.Drawing.Point(14, 157);
            this.lb_veri_code_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_veri_code_1.Name = "lb_veri_code_1";
            this.lb_veri_code_1.Size = new System.Drawing.Size(98, 21);
            this.lb_veri_code_1.TabIndex = 7;
            this.lb_veri_code_1.Text = "验证码：";
            // 
            // tb_id_code
            // 
            this.tb_id_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id_code.Location = new System.Drawing.Point(19, 188);
            this.tb_id_code.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_code.Name = "tb_id_code";
            this.tb_id_code.Size = new System.Drawing.Size(276, 31);
            this.tb_id_code.TabIndex = 6;
            // 
            // lb_veri_code_2
            // 
            this.lb_veri_code_2.AutoSize = true;
            this.lb_veri_code_2.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veri_code_2.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_veri_code_2.Location = new System.Drawing.Point(15, 223);
            this.lb_veri_code_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_veri_code_2.Name = "lb_veri_code_2";
            this.lb_veri_code_2.Size = new System.Drawing.Size(169, 19);
            this.lb_veri_code_2.TabIndex = 8;
            this.lb_veri_code_2.Text = "用于修改账号密码";
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_change_pass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_change_pass.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_change_pass.FlatAppearance.BorderSize = 3;
            this.btn_change_pass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_change_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_pass.Location = new System.Drawing.Point(159, 261);
            this.btn_change_pass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(136, 42);
            this.btn_change_pass.TabIndex = 9;
            this.btn_change_pass.Text = "修改密码";
            this.btn_change_pass.UseVisualStyleBackColor = false;
            this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
            // 
            // Register
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(309, 342);
            this.Controls.Add(this.btn_change_pass);
            this.Controls.Add(this.lb_veri_code_2);
            this.Controls.Add(this.lb_veri_code_1);
            this.Controls.Add(this.tb_id_code);
            this.Controls.Add(this.lb_limit_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_register);
            this.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_limit_info;
        private System.Windows.Forms.Label lb_veri_code_1;
        private System.Windows.Forms.TextBox tb_id_code;
        private System.Windows.Forms.Label lb_veri_code_2;
        private System.Windows.Forms.Button btn_change_pass;
    }
}