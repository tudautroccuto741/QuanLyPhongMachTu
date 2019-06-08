namespace QLPM_GUI
{
    partial class FrmToaThuoc_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToaThuoc_GUI));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDanhSachThuoc = new System.Windows.Forms.Label();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.lblChiTietPhieuKham = new System.Windows.Forms.Label();
            this.cbxPhieuKham = new System.Windows.Forms.ComboBox();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenDonVi = new System.Windows.Forms.Label();
            this.cbxCachDung = new System.Windows.Forms.ComboBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThuoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBenh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.gbxChiTietPhieuKham = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenBacSi = new System.Windows.Forms.TextBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            this.gbxChiTietPhieuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(844, 282);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 42;
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
            this.btnXoa.Location = new System.Drawing.Point(844, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 40;
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
            this.btnThem.Location = new System.Drawing.Point(844, 124);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDanhSachThuoc
            // 
            this.lblDanhSachThuoc.AutoSize = true;
            this.lblDanhSachThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachThuoc.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhSachThuoc.Location = new System.Drawing.Point(427, 342);
            this.lblDanhSachThuoc.Name = "lblDanhSachThuoc";
            this.lblDanhSachThuoc.Size = new System.Drawing.Size(124, 18);
            this.lblDanhSachThuoc.TabIndex = 38;
            this.lblDanhSachThuoc.Text = "Danh sách thuốc ";
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Location = new System.Drawing.Point(125, 366);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.Size = new System.Drawing.Size(725, 225);
            this.dgvToaThuoc.TabIndex = 37;
            this.dgvToaThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaThuoc_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(844, 229);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 41;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblMaThuoc
            // 
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuoc.ForeColor = System.Drawing.Color.Navy;
            this.lblMaThuoc.Location = new System.Drawing.Point(284, 87);
            this.lblMaThuoc.Name = "lblMaThuoc";
            this.lblMaThuoc.Size = new System.Drawing.Size(109, 18);
            this.lblMaThuoc.TabIndex = 34;
            this.lblMaThuoc.Text = "Mã phiếu khám";
            // 
            // lblChiTietPhieuKham
            // 
            this.lblChiTietPhieuKham.AutoSize = true;
            this.lblChiTietPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPhieuKham.ForeColor = System.Drawing.Color.Red;
            this.lblChiTietPhieuKham.Location = new System.Drawing.Point(410, 20);
            this.lblChiTietPhieuKham.Name = "lblChiTietPhieuKham";
            this.lblChiTietPhieuKham.Size = new System.Drawing.Size(138, 25);
            this.lblChiTietPhieuKham.TabIndex = 32;
            this.lblChiTietPhieuKham.Text = "ĐƠN THUỐC";
            // 
            // cbxPhieuKham
            // 
            this.cbxPhieuKham.FormattingEnabled = true;
            this.cbxPhieuKham.Location = new System.Drawing.Point(412, 87);
            this.cbxPhieuKham.Name = "cbxPhieuKham";
            this.cbxPhieuKham.Size = new System.Drawing.Size(179, 21);
            this.cbxPhieuKham.TabIndex = 44;
            this.cbxPhieuKham.SelectedIndexChanged += new System.EventHandler(this.cbxPhieuKham_SelectedIndexChanged);
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(6, 34);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(105, 18);
            this.lblMaPhieuKham.TabIndex = 0;
            this.lblMaPhieuKham.Text = "Tên bệnh nhân";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblDonGia.Location = new System.Drawing.Point(380, 34);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(71, 18);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Năm sinh";
            // 
            // lblTenDonVi
            // 
            this.lblTenDonVi.AutoSize = true;
            this.lblTenDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDonVi.ForeColor = System.Drawing.Color.Black;
            this.lblTenDonVi.Location = new System.Drawing.Point(8, 73);
            this.lblTenDonVi.Name = "lblTenDonVi";
            this.lblTenDonVi.Size = new System.Drawing.Size(53, 18);
            this.lblTenDonVi.TabIndex = 4;
            this.lblTenDonVi.Text = "Địa chỉ";
            // 
            // cbxCachDung
            // 
            this.cbxCachDung.FormattingEnabled = true;
            this.cbxCachDung.Location = new System.Drawing.Point(512, 158);
            this.cbxCachDung.Name = "cbxCachDung";
            this.cbxCachDung.Size = new System.Drawing.Size(198, 23);
            this.cbxCachDung.TabIndex = 9;
            this.cbxCachDung.SelectedIndexChanged += new System.EventHandler(this.cbxCachDung_SelectedIndexChanged);
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.ForeColor = System.Drawing.Color.Black;
            this.lblDonVi.Location = new System.Drawing.Point(380, 158);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(105, 18);
            this.lblDonVi.TabIndex = 3;
            this.lblDonVi.Text = "Tên cách dùng";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Enabled = false;
            this.txtNamSinh.Location = new System.Drawing.Point(512, 32);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(102, 21);
            this.txtNamSinh.TabIndex = 10;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(166, 73);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(179, 21);
            this.txtDiaChi.TabIndex = 13;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tên thuốc";
            // 
            // cbxThuoc
            // 
            this.cbxThuoc.FormattingEnabled = true;
            this.cbxThuoc.Location = new System.Drawing.Point(166, 158);
            this.cbxThuoc.Name = "cbxThuoc";
            this.cbxThuoc.Size = new System.Drawing.Size(179, 23);
            this.cbxThuoc.TabIndex = 45;
            this.cbxThuoc.SelectedIndexChanged += new System.EventHandler(this.cbxThuoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(512, 73);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(102, 21);
            this.txtGioiTinh.TabIndex = 47;
            this.txtGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Chuẩn đoán";
            // 
            // cbxBenh
            // 
            this.cbxBenh.FormattingEnabled = true;
            this.cbxBenh.Location = new System.Drawing.Point(166, 117);
            this.cbxBenh.Name = "cbxBenh";
            this.cbxBenh.Size = new System.Drawing.Size(179, 23);
            this.cbxBenh.TabIndex = 49;
            this.cbxBenh.SelectedIndexChanged += new System.EventHandler(this.cbxBenh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Đơn vị";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Location = new System.Drawing.Point(512, 122);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(198, 21);
            this.txtDonVi.TabIndex = 51;
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDonVi.TextChanged += new System.EventHandler(this.txtDonVi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(512, 198);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(102, 21);
            this.txtSoLuong.TabIndex = 52;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Enabled = false;
            this.txtTenBN.Location = new System.Drawing.Point(166, 34);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(179, 21);
            this.txtTenBN.TabIndex = 53;
            this.txtTenBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxChiTietPhieuKham
            // 
            this.gbxChiTietPhieuKham.Controls.Add(this.label6);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtTenBacSi);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtTenBN);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtSoLuong);
            this.gbxChiTietPhieuKham.Controls.Add(this.label5);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtDonVi);
            this.gbxChiTietPhieuKham.Controls.Add(this.label4);
            this.gbxChiTietPhieuKham.Controls.Add(this.cbxBenh);
            this.gbxChiTietPhieuKham.Controls.Add(this.label3);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtGioiTinh);
            this.gbxChiTietPhieuKham.Controls.Add(this.label2);
            this.gbxChiTietPhieuKham.Controls.Add(this.cbxThuoc);
            this.gbxChiTietPhieuKham.Controls.Add(this.label1);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtDiaChi);
            this.gbxChiTietPhieuKham.Controls.Add(this.txtNamSinh);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblDonVi);
            this.gbxChiTietPhieuKham.Controls.Add(this.cbxCachDung);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblTenDonVi);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblDonGia);
            this.gbxChiTietPhieuKham.Controls.Add(this.lblMaPhieuKham);
            this.gbxChiTietPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxChiTietPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChiTietPhieuKham.ForeColor = System.Drawing.Color.Navy;
            this.gbxChiTietPhieuKham.Location = new System.Drawing.Point(106, 115);
            this.gbxChiTietPhieuKham.Name = "gbxChiTietPhieuKham";
            this.gbxChiTietPhieuKham.Size = new System.Drawing.Size(722, 224);
            this.gbxChiTietPhieuKham.TabIndex = 36;
            this.gbxChiTietPhieuKham.TabStop = false;
            this.gbxChiTietPhieuKham.Text = "Thông tin thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tên bác sĩ";
            // 
            // txtTenBacSi
            // 
            this.txtTenBacSi.Enabled = false;
            this.txtTenBacSi.Location = new System.Drawing.Point(166, 197);
            this.txtTenBacSi.Name = "txtTenBacSi";
            this.txtTenBacSi.Size = new System.Drawing.Size(179, 21);
            this.txtTenBacSi.TabIndex = 54;
            this.txtTenBacSi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(336, 11);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(52, 61);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 45;
            this.PictureBox5.TabStop = false;
            // 
            // FrmToaThuoc_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.cbxPhieuKham);
            this.Controls.Add(this.gbxChiTietPhieuKham);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDanhSachThuoc);
            this.Controls.Add(this.dgvToaThuoc);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblMaThuoc);
            this.Controls.Add(this.lblChiTietPhieuKham);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmToaThuoc_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmToaThuoc_GUI";
            this.Load += new System.EventHandler(this.FrmToaThuoc_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            this.gbxChiTietPhieuKham.ResumeLayout(false);
            this.gbxChiTietPhieuKham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Label lblDanhSachThuoc;
        internal System.Windows.Forms.DataGridView dgvToaThuoc;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.Label lblMaThuoc;
        internal System.Windows.Forms.Label lblChiTietPhieuKham;
        internal System.Windows.Forms.ComboBox cbxPhieuKham;
        internal System.Windows.Forms.Label lblMaPhieuKham;
        internal System.Windows.Forms.Label lblDonGia;
        internal System.Windows.Forms.Label lblTenDonVi;
        internal System.Windows.Forms.ComboBox cbxCachDung;
        internal System.Windows.Forms.Label lblDonVi;
        internal System.Windows.Forms.TextBox txtNamSinh;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbxThuoc;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtGioiTinh;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cbxBenh;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtDonVi;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtSoLuong;
        internal System.Windows.Forms.TextBox txtTenBN;
        internal System.Windows.Forms.GroupBox gbxChiTietPhieuKham;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTenBacSi;
        internal System.Windows.Forms.PictureBox PictureBox5;
    }
}