namespace QLPM_GUI
{
    partial class FrmTienKham_GUI
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.txtGiaTriMoi = new System.Windows.Forms.TextBox();
            this.txtGiaTriCu = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(283, 175);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(173, 49);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DongY.FlatAppearance.BorderSize = 0;
            this.btn_DongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.ForeColor = System.Drawing.Color.White;
            this.btn_DongY.Location = new System.Drawing.Point(58, 175);
            this.btn_DongY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(173, 49);
            this.btn_DongY.TabIndex = 29;
            this.btn_DongY.Text = "Đồng ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // txtGiaTriMoi
            // 
            this.txtGiaTriMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriMoi.Location = new System.Drawing.Point(283, 102);
            this.txtGiaTriMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTriMoi.Name = "txtGiaTriMoi";
            this.txtGiaTriMoi.Size = new System.Drawing.Size(147, 29);
            this.txtGiaTriMoi.TabIndex = 28;
            // 
            // txtGiaTriCu
            // 
            this.txtGiaTriCu.Enabled = false;
            this.txtGiaTriCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriCu.Location = new System.Drawing.Point(283, 34);
            this.txtGiaTriCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTriCu.Name = "txtGiaTriCu";
            this.txtGiaTriCu.Size = new System.Drawing.Size(147, 29);
            this.txtGiaTriCu.TabIndex = 27;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(44, 102);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(187, 50);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Giá trị tiền khám mới\r\n\r\n";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(44, 36);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(177, 25);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Giá trị tiền khám cũ\r\n";
            // 
            // FrmTienKham_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 274);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.txtGiaTriMoi);
            this.Controls.Add(this.txtGiaTriCu);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "FrmTienKham_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienKham_GUI";
            this.Load += new System.EventHandler(this.FrmTienKham_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btn_DongY;
        internal System.Windows.Forms.TextBox txtGiaTriMoi;
        internal System.Windows.Forms.TextBox txtGiaTriCu;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}