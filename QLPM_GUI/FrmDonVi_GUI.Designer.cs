namespace QLPM_GUI
{
    partial class FrmDonVi_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi_GUI));
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblTenDonVi = new System.Windows.Forms.Label();
            this.lblMaDonVi = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.picPhieuKhamBenh = new System.Windows.Forms.PictureBox();
            this.lblThemDonVi = new System.Windows.Forms.Label();
            this.dgvDonVi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDonVi.Location = new System.Drawing.Point(272, 197);
            this.txtTenDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(123, 29);
            this.txtTenDonVi.TabIndex = 53;
            this.txtTenDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(272, 121);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(123, 29);
            this.txtMaDV.TabIndex = 52;
            this.txtMaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTenDonVi
            // 
            this.lblTenDonVi.AutoSize = true;
            this.lblTenDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDonVi.ForeColor = System.Drawing.Color.Black;
            this.lblTenDonVi.Location = new System.Drawing.Point(112, 197);
            this.lblTenDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDonVi.Name = "lblTenDonVi";
            this.lblTenDonVi.Size = new System.Drawing.Size(137, 24);
            this.lblTenDonVi.TabIndex = 51;
            this.lblTenDonVi.Text = "Tên đơn vị mới";
            // 
            // lblMaDonVi
            // 
            this.lblMaDonVi.AutoSize = true;
            this.lblMaDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonVi.ForeColor = System.Drawing.Color.Black;
            this.lblMaDonVi.Location = new System.Drawing.Point(112, 121);
            this.lblMaDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDonVi.Name = "lblMaDonVi";
            this.lblMaDonVi.Size = new System.Drawing.Size(129, 24);
            this.lblMaDonVi.TabIndex = 50;
            this.lblMaDonVi.Text = "Mã đơn vị mới";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(279, 279);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 49);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(443, 279);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(117, 49);
            this.btnCapNhat.TabIndex = 48;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(629, 279);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 49);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(112, 279);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 49);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Image = ((System.Drawing.Image)(resources.GetObject("picPhieuKhamBenh.Image")));
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(287, 13);
            this.picPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(67, 62);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 45;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblThemDonVi
            // 
            this.lblThemDonVi.AutoSize = true;
            this.lblThemDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemDonVi.ForeColor = System.Drawing.Color.Red;
            this.lblThemDonVi.Location = new System.Drawing.Point(398, 26);
            this.lblThemDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThemDonVi.Name = "lblThemDonVi";
            this.lblThemDonVi.Size = new System.Drawing.Size(91, 31);
            this.lblThemDonVi.TabIndex = 44;
            this.lblThemDonVi.Text = "Đơn vị";
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonVi.Location = new System.Drawing.Point(427, 89);
            this.dgvDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.Size = new System.Drawing.Size(403, 171);
            this.dgvDonVi.TabIndex = 43;
            this.dgvDonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonVi_CellClick);
            // 
            // FrmDonVi_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(872, 381);
            this.Controls.Add(this.txtTenDonVi);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.lblTenDonVi);
            this.Controls.Add(this.lblMaDonVi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.lblThemDonVi);
            this.Controls.Add(this.dgvDonVi);
            this.Name = "FrmDonVi_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDonVi_GUI";
            this.Load += new System.EventHandler(this.FrmDonVi_GUI_Load);
            this.Click += new System.EventHandler(this.FrmDonVi_GUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTenDonVi;
        internal System.Windows.Forms.TextBox txtMaDV;
        internal System.Windows.Forms.Label lblTenDonVi;
        internal System.Windows.Forms.Label lblMaDonVi;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblThemDonVi;
        internal System.Windows.Forms.DataGridView dgvDonVi;
    }
}