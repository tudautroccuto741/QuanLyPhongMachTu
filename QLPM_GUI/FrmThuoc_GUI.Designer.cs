namespace QLPM_GUI
{
    partial class FrmThuoc_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThuoc_GUI));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDanhSachThuoc = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.lblChiTietPhieuKham = new System.Windows.Forms.Label();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.txtDonGiaThuoc = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.gbxChiTietPhieuKham = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.gbxChiTietPhieuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(970, 332);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 43);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(970, 209);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 43);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(970, 149);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 43);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDanhSachThuoc
            // 
            this.lblDanhSachThuoc.AutoSize = true;
            this.lblDanhSachThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachThuoc.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhSachThuoc.Location = new System.Drawing.Point(508, 418);
            this.lblDanhSachThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachThuoc.Name = "lblDanhSachThuoc";
            this.lblDanhSachThuoc.Size = new System.Drawing.Size(157, 24);
            this.lblDanhSachThuoc.TabIndex = 27;
            this.lblDanhSachThuoc.Text = "Danh sách thuốc ";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(106, 448);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.Size = new System.Drawing.Size(967, 277);
            this.dgvThuoc.TabIndex = 26;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(970, 268);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 43);
            this.btnCapNhat.TabIndex = 30;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Enabled = false;
            this.txtMaThuoc.Location = new System.Drawing.Point(488, 104);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(232, 22);
            this.txtMaThuoc.TabIndex = 24;
            this.txtMaThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaThuoc
            // 
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuoc.ForeColor = System.Drawing.Color.Navy;
            this.lblMaThuoc.Location = new System.Drawing.Point(379, 104);
            this.lblMaThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaThuoc.Name = "lblMaThuoc";
            this.lblMaThuoc.Size = new System.Drawing.Size(88, 24);
            this.lblMaThuoc.TabIndex = 23;
            this.lblMaThuoc.Text = "Mã thuốc\r\n";
            // 
            // lblChiTietPhieuKham
            // 
            this.lblChiTietPhieuKham.AutoSize = true;
            this.lblChiTietPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPhieuKham.ForeColor = System.Drawing.Color.Red;
            this.lblChiTietPhieuKham.Location = new System.Drawing.Point(507, 22);
            this.lblChiTietPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiTietPhieuKham.Name = "lblChiTietPhieuKham";
            this.lblChiTietPhieuKham.Size = new System.Drawing.Size(181, 62);
            this.lblChiTietPhieuKham.TabIndex = 21;
            this.lblChiTietPhieuKham.Text = "Quản lý thuốc\r\n\r\n";
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(8, 42);
            this.lblMaPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(96, 24);
            this.lblMaPhieuKham.TabIndex = 0;
            this.lblMaPhieuKham.Text = "Tên thuốc";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblDonGia.Location = new System.Drawing.Point(535, 42);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(75, 24);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenThuoc.Location = new System.Drawing.Point(221, 37);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(238, 24);
            this.txtTenThuoc.TabIndex = 5;
            this.txtTenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Location = new System.Drawing.Point(221, 87);
            this.cbxDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(237, 26);
            this.cbxDonVi.TabIndex = 9;
            this.cbxDonVi.SelectedIndexChanged += new System.EventHandler(this.cbxDonVi_SelectedIndexChanged);
            // 
            // txtDonGiaThuoc
            // 
            this.txtDonGiaThuoc.Location = new System.Drawing.Point(699, 37);
            this.txtDonGiaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaThuoc.Name = "txtDonGiaThuoc";
            this.txtDonGiaThuoc.Size = new System.Drawing.Size(135, 24);
            this.txtDonGiaThuoc.TabIndex = 10;
            this.txtDonGiaThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(450, 163);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(135, 24);
            this.txtSoLuongTon.TabIndex = 11;
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongTon.Location = new System.Drawing.Point(299, 163);
            this.lblSoLuongTon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(91, 24);
            this.lblSoLuongTon.TabIndex = 19;
            this.lblSoLuongTon.Text = "Số lượng ";
            // 
            // gbxChiTietPhieuKham
            // 
            this.gbxChiTietPhieuKham.Controls.Add(this.label2);
            this.gbxChiTietPhieuKham.Controls.Add(this.cbxNhaCungCap);
            this.gbxChiTietPhieuKham.Controls.Add(this.label1);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblSoLuongTon);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtSoLuongTon);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtDonGiaThuoc);
            this.gbxChiTietPhieuKham.Controls.Add(this.cbxDonVi);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtTenThuoc);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblDonGia);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblMaPhieuKham);
            this.gbxChiTietPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxChiTietPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChiTietPhieuKham.ForeColor = System.Drawing.Color.Navy;
            this.gbxChiTietPhieuKham.Location = new System.Drawing.Point(80, 138);
            this.gbxChiTietPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChiTietPhieuKham.Name = "gbxChiTietPhieuKham";
            this.gbxChiTietPhieuKham.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChiTietPhieuKham.Size = new System.Drawing.Size(857, 238);
            this.gbxChiTietPhieuKham.TabIndex = 25;
            this.gbxChiTietPhieuKham.TabStop = false;
            this.gbxChiTietPhieuKham.Text = "Thông tin thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(499, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // cbxNhaCungCap
            // 
            this.cbxNhaCungCap.FormattingEnabled = true;
            this.cbxNhaCungCap.Location = new System.Drawing.Point(699, 93);
            this.cbxNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhaCungCap.Name = "cbxNhaCungCap";
            this.cbxNhaCungCap.Size = new System.Drawing.Size(135, 26);
            this.cbxNhaCungCap.TabIndex = 33;
            this.cbxNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbxNhaCungCap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên Đơn vị";
            // 
            // PictureBox11
            // 
            this.PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox11.Image")));
            this.PictureBox11.Location = new System.Drawing.Point(414, 22);
            this.PictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(85, 62);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox11.TabIndex = 32;
            this.PictureBox11.TabStop = false;
            // 
            // FrmThuoc_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1206, 673);
            this.Controls.Add(this.PictureBox11);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDanhSachThuoc);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.gbxChiTietPhieuKham);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.lblMaThuoc);
            this.Controls.Add(this.lblChiTietPhieuKham);
            this.Name = "FrmThuoc_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThuoc_GUI";
            this.Load += new System.EventHandler(this.FrmThuoc_GUI_Load);
            this.Click += new System.EventHandler(this.FrmThuoc_GUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.gbxChiTietPhieuKham.ResumeLayout(false);
            this.gbxChiTietPhieuKham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Label lblDanhSachThuoc;
        internal System.Windows.Forms.DataGridView dgvThuoc;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.TextBox txtMaThuoc;
        internal System.Windows.Forms.Label lblMaThuoc;
        internal System.Windows.Forms.Label lblChiTietPhieuKham;
        internal System.Windows.Forms.Label lblMaPhieuKham;
        internal System.Windows.Forms.Label lblDonGia;
        internal System.Windows.Forms.TextBox txtTenThuoc;
        internal System.Windows.Forms.ComboBox cbxDonVi;
        internal System.Windows.Forms.TextBox txtDonGiaThuoc;
        internal System.Windows.Forms.TextBox txtSoLuongTon;
        internal System.Windows.Forms.Label lblSoLuongTon;
        internal System.Windows.Forms.GroupBox gbxChiTietPhieuKham;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cbxNhaCungCap;
        internal System.Windows.Forms.PictureBox PictureBox11;
    }
}