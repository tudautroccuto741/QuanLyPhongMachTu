namespace QLPM_GUI
{
    partial class FrmChiTietHoaDon_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHoaDon_GUI));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxBenhNhan = new System.Windows.Forms.ComboBox();
            this.gbxThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.txtNhanSu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.lblHoTenBenhNhan = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.gbxThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(391, 426);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 40);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(213, 426);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Xuất hóa đơn";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBenhNhan.FormattingEnabled = true;
            this.cbxBenhNhan.Location = new System.Drawing.Point(350, 108);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Size = new System.Drawing.Size(153, 21);
            this.cbxBenhNhan.TabIndex = 45;
            this.cbxBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbxBenhNhan_SelectedIndexChanged);
            // 
            // gbxThongTinHoaDon
            // 
            this.gbxThongTinHoaDon.Controls.Add(this.txtNhanSu);
            this.gbxThongTinHoaDon.Controls.Add(this.label5);
            this.gbxThongTinHoaDon.Controls.Add(this.label4);
            this.gbxThongTinHoaDon.Controls.Add(this.txtBenh);
            this.gbxThongTinHoaDon.Controls.Add(this.label3);
            this.gbxThongTinHoaDon.Controls.Add(this.txtTongTien);
            this.gbxThongTinHoaDon.Controls.Add(this.label1);
            this.gbxThongTinHoaDon.Controls.Add(this.txtNgayKham);
            this.gbxThongTinHoaDon.Controls.Add(this.txtDiaChi);
            this.gbxThongTinHoaDon.Controls.Add(this.label2);
            this.gbxThongTinHoaDon.Controls.Add(this.txtNamSinh);
            this.gbxThongTinHoaDon.Controls.Add(this.txtMaBenhNhan);
            this.gbxThongTinHoaDon.Controls.Add(this.txtMaPhieuKham);
            this.gbxThongTinHoaDon.Controls.Add(this.txtGioiTinh);
            this.gbxThongTinHoaDon.Controls.Add(this.lblTienThuoc);
            this.gbxThongTinHoaDon.Controls.Add(this.lblTienKham);
            this.gbxThongTinHoaDon.Controls.Add(this.lblMaBenhNhan);
            this.gbxThongTinHoaDon.Controls.Add(this.lblHoTenBenhNhan);
            this.gbxThongTinHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinHoaDon.ForeColor = System.Drawing.Color.Navy;
            this.gbxThongTinHoaDon.Location = new System.Drawing.Point(76, 154);
            this.gbxThongTinHoaDon.Name = "gbxThongTinHoaDon";
            this.gbxThongTinHoaDon.Size = new System.Drawing.Size(603, 254);
            this.gbxThongTinHoaDon.TabIndex = 44;
            this.gbxThongTinHoaDon.TabStop = false;
            this.gbxThongTinHoaDon.Text = " Thông tin chi tiết hóa đơn";
            // 
            // txtNhanSu
            // 
            this.txtNhanSu.Enabled = false;
            this.txtNhanSu.Location = new System.Drawing.Point(446, 167);
            this.txtNhanSu.Name = "txtNhanSu";
            this.txtNhanSu.Size = new System.Drawing.Size(120, 21);
            this.txtNhanSu.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(321, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Chuẩn đoán";
            // 
            // txtBenh
            // 
            this.txtBenh.Enabled = false;
            this.txtBenh.Location = new System.Drawing.Point(137, 166);
            this.txtBenh.Name = "txtBenh";
            this.txtBenh.Size = new System.Drawing.Size(120, 21);
            this.txtBenh.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(134, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tổng tiền thanh toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(307, 221);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(120, 21);
            this.txtTongTien.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ngày khám";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Location = new System.Drawing.Point(137, 73);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(120, 21);
            this.txtNgayKham.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(137, 120);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(120, 21);
            this.txtDiaChi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Địa chỉ";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Enabled = false;
            this.txtNamSinh.Location = new System.Drawing.Point(446, 73);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(120, 21);
            this.txtNamSinh.TabIndex = 15;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.Location = new System.Drawing.Point(137, 34);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(120, 21);
            this.txtMaBenhNhan.TabIndex = 13;
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Enabled = false;
            this.txtMaPhieuKham.Location = new System.Drawing.Point(446, 35);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.Size = new System.Drawing.Size(120, 21);
            this.txtMaPhieuKham.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(446, 121);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(120, 21);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThuoc.ForeColor = System.Drawing.Color.Black;
            this.lblTienThuoc.Location = new System.Drawing.Point(321, 72);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(71, 18);
            this.lblTienThuoc.TabIndex = 4;
            this.lblTienThuoc.Text = "Năm sinh";
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKham.ForeColor = System.Drawing.Color.Black;
            this.lblTienKham.Location = new System.Drawing.Point(322, 119);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(62, 18);
            this.lblTienKham.TabIndex = 3;
            this.lblTienKham.Text = "Giới tính";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(16, 34);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(101, 18);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // lblHoTenBenhNhan
            // 
            this.lblHoTenBenhNhan.AutoSize = true;
            this.lblHoTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenBenhNhan.Location = new System.Drawing.Point(321, 32);
            this.lblHoTenBenhNhan.Name = "lblHoTenBenhNhan";
            this.lblHoTenBenhNhan.Size = new System.Drawing.Size(109, 18);
            this.lblHoTenBenhNhan.TabIndex = 1;
            this.lblHoTenBenhNhan.Text = "Mã phiếu khám";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Red;
            this.lblHoaDon.Location = new System.Drawing.Point(335, 34);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(176, 25);
            this.lblHoaDon.TabIndex = 43;
            this.lblHoaDon.Text = "Chi Tiết Hóa Đơn";
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(190, 108);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(105, 18);
            this.lblMaPhieuKham.TabIndex = 41;
            this.lblMaPhieuKham.Text = "Tên bệnh nhân";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(213, 21);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(76, 60);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 48;
            this.pictureBox20.TabStop = false;
            // 
            // FrmChiTietHoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(748, 476);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxBenhNhan);
            this.Controls.Add(this.gbxThongTinHoaDon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblMaPhieuKham);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChiTietHoaDon_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietHoaDon_GUI";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDon_GUI_Load);
            this.gbxThongTinHoaDon.ResumeLayout(false);
            this.gbxThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.ComboBox cbxBenhNhan;
        internal System.Windows.Forms.GroupBox gbxThongTinHoaDon;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtTongTien;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNgayKham;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtNamSinh;
        internal System.Windows.Forms.TextBox txtMaBenhNhan;
        internal System.Windows.Forms.TextBox txtMaPhieuKham;
        internal System.Windows.Forms.TextBox txtGioiTinh;
        internal System.Windows.Forms.Label lblTienThuoc;
        internal System.Windows.Forms.Label lblTienKham;
        internal System.Windows.Forms.Label lblMaBenhNhan;
        internal System.Windows.Forms.Label lblHoTenBenhNhan;
        internal System.Windows.Forms.Label lblHoaDon;
        internal System.Windows.Forms.Label lblMaPhieuKham;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtBenh;
        internal System.Windows.Forms.TextBox txtNhanSu;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.PictureBox pictureBox20;
    }
}