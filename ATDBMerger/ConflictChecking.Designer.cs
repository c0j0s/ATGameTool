namespace ATDBMerger
{
    partial class ConflictChecking
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tb_output_a = new System.Windows.Forms.TextBox();
            this.Tb_output_b = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Tb_output_b, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tb_output_a, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Tb_output_a
            // 
            this.Tb_output_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_output_a.Location = new System.Drawing.Point(3, 3);
            this.Tb_output_a.Multiline = true;
            this.Tb_output_a.Name = "Tb_output_a";
            this.Tb_output_a.ReadOnly = true;
            this.Tb_output_a.Size = new System.Drawing.Size(270, 444);
            this.Tb_output_a.TabIndex = 19;
            // 
            // Tb_output_b
            // 
            this.Tb_output_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_output_b.Location = new System.Drawing.Point(279, 3);
            this.Tb_output_b.Multiline = true;
            this.Tb_output_b.Name = "Tb_output_b";
            this.Tb_output_b.ReadOnly = true;
            this.Tb_output_b.Size = new System.Drawing.Size(271, 444);
            this.Tb_output_b.TabIndex = 20;
            // 
            // ConflictChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConflictChecking";
            this.Text = "查看数据";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Tb_output_b;
        private System.Windows.Forms.TextBox Tb_output_a;
    }
}