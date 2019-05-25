namespace QLPM_GUI
{
    partial class FrmTaoTaiKhoan_GUI
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
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtMatkhauAgain = new System.Windows.Forms.TextBox();
            this.lblSoPhieuKham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(250, 361);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 43);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Đăng kí";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(527, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTenTK
            // 
            this.txtTenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTK.Location = new System.Drawing.Point(452, 137);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(198, 22);
            this.txtTenTK.TabIndex = 42;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatkhau.Location = new System.Drawing.Point(452, 196);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(198, 22);
            this.txtMatkhau.TabIndex = 43;
            // 
            // txtMatkhauAgain
            // 
            this.txtMatkhauAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatkhauAgain.Location = new System.Drawing.Point(452, 262);
            this.txtMatkhauAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhauAgain.Name = "txtMatkhauAgain";
            this.txtMatkhauAgain.Size = new System.Drawing.Size(198, 22);
            this.txtMatkhauAgain.TabIndex = 44;
            // 
            // lblSoPhieuKham
            // 
            this.lblSoPhieuKham.AutoSize = true;
            this.lblSoPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblSoPhieuKham.Location = new System.Drawing.Point(246, 133);
            this.lblSoPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhieuKham.Name = "lblSoPhieuKham";
            this.lblSoPhieuKham.Size = new System.Drawing.Size(124, 24);
            this.lblSoPhieuKham.TabIndex = 45;
            this.lblSoPhieuKham.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(246, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // FrmTaoTaiKhoan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoPhieuKham);
            this.Controls.Add(this.txtMatkhauAgain);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmTaoTaiKhoan_GUI";
            this.Text = "FrmTaoTaiKhoan_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtTenTK;
        internal System.Windows.Forms.TextBox txtMatkhau;
        internal System.Windows.Forms.TextBox txtMatkhauAgain;
        internal System.Windows.Forms.Label lblSoPhieuKham;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
    }
}