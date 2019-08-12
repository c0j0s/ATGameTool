namespace ATGate
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_contact_details = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_dist = new System.Windows.Forms.Label();
            this.lb_server = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_faq = new System.Windows.Forms.Button();
            this.lb_error_details = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_contact_details);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "联系信息";
            // 
            // lb_contact_details
            // 
            this.lb_contact_details.AutoSize = true;
            this.lb_contact_details.Location = new System.Drawing.Point(88, 27);
            this.lb_contact_details.Name = "lb_contact_details";
            this.lb_contact_details.Size = new System.Drawing.Size(43, 21);
            this.lb_contact_details.TabIndex = 6;
            this.lb_contact_details.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "客服QQ：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lb_error_details);
            this.groupBox2.Controls.Add(this.lb_dist);
            this.groupBox2.Controls.Add(this.lb_server);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "错误详情";
            // 
            // lb_dist
            // 
            this.lb_dist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_dist.AutoSize = true;
            this.lb_dist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_dist.Location = new System.Drawing.Point(2, 110);
            this.lb_dist.Name = "lb_dist";
            this.lb_dist.Size = new System.Drawing.Size(65, 21);
            this.lb_dist.TabIndex = 7;
            this.lb_dist.Text = "Dist:";
            // 
            // lb_server
            // 
            this.lb_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_server.AutoSize = true;
            this.lb_server.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_server.Location = new System.Drawing.Point(2, 131);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(87, 21);
            this.lb_server.TabIndex = 6;
            this.lb_server.Text = "Server:";
            this.lb_server.Visible = false;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ok.FlatAppearance.BorderSize = 3;
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(269, 262);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(136, 42);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_faq
            // 
            this.btn_faq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_faq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_faq.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_faq.FlatAppearance.BorderSize = 3;
            this.btn_faq.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_faq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faq.Location = new System.Drawing.Point(125, 262);
            this.btn_faq.Margin = new System.Windows.Forms.Padding(4);
            this.btn_faq.Name = "btn_faq";
            this.btn_faq.Size = new System.Drawing.Size(136, 42);
            this.btn_faq.TabIndex = 9;
            this.btn_faq.Text = "常见问题";
            this.btn_faq.UseVisualStyleBackColor = false;
            this.btn_faq.Click += new System.EventHandler(this.btn_faq_Click);
            // 
            // lb_error_details
            // 
            this.lb_error_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_error_details.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_error_details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_error_details.CausesValidation = false;
            this.lb_error_details.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_error_details.DetectUrls = false;
            this.lb_error_details.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_error_details.Location = new System.Drawing.Point(6, 30);
            this.lb_error_details.Name = "lb_error_details";
            this.lb_error_details.ReadOnly = true;
            this.lb_error_details.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lb_error_details.Size = new System.Drawing.Size(381, 73);
            this.lb_error_details.TabIndex = 8;
            this.lb_error_details.Text = "";
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.btn_faq);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 340);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_contact_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_faq;
        private System.Windows.Forms.Label lb_dist;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.RichTextBox lb_error_details;
    }
}