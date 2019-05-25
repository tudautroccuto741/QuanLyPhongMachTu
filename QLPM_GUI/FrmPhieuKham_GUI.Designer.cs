namespace QLPM_GUI
{
    partial class FrmPhieuKham_GUI
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
            this.dgvPK = new System.Windows.Forms.DataGridView();
            this.picPhieuKhamBenh = new System.Windows.Forms.PictureBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.lblSoPhieuKham = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.cbxMaBenhNhan = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.lblDanhSachPhieuKham = new System.Windows.Forms.Label();
            this.gbxThongTinPhieuKham = new System.Windows.Forms.GroupBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblPhieuKhamBenh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            this.gbxThongTinPhieuKham.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPK
            // 
            this.dgvPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPK.Location = new System.Drawing.Point(169, 451);
            this.dgvPK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPK.Name = "dgvPK";
            this.dgvPK.Size = new System.Drawing.Size(915, 210);
            this.dgvPK.TabIndex = 27;
            this.dgvPK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPK_CellClick);
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(456, 14);
            this.picPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(73, 68);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 20;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.ForeColor = System.Drawing.Color.Black;
            this.lblTrieuChung.Location = new System.Drawing.Point(9, 263);
            this.lblTrieuChung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(113, 24);
            this.lblTrieuChung.TabIndex = 3;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(8, 144);
            this.lblMaBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(133, 24);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.ForeColor = System.Drawing.Color.Black;
            this.lblNgayKham.Location = new System.Drawing.Point(9, 91);
            this.lblNgayKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(105, 24);
            this.lblNgayKham.TabIndex = 1;
            this.lblNgayKham.Text = "Ngày khám";
            // 
            // lblSoPhieuKham
            // 
            this.lblSoPhieuKham.AutoSize = true;
            this.lblSoPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblSoPhieuKham.Location = new System.Drawing.Point(9, 38);
            this.lblSoPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhieuKham.Name = "lblSoPhieuKham";
            this.lblSoPhieuKham.Size = new System.Drawing.Size(137, 24);
            this.lblSoPhieuKham.TabIndex = 0;
            this.lblSoPhieuKham.Text = "Số phiếu khám";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(799, 264);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(147, 49);
            this.btnCapNhat.TabIndex = 26;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(799, 340);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 49);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(183, 263);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(159, 24);
            this.txtTrieuChung.TabIndex = 8;
            // 
            // cbxMaBenhNhan
            // 
            this.cbxMaBenhNhan.FormattingEnabled = true;
            this.cbxMaBenhNhan.Location = new System.Drawing.Point(183, 142);
            this.cbxMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaBenhNhan.Name = "cbxMaBenhNhan";
            this.cbxMaBenhNhan.Size = new System.Drawing.Size(159, 26);
            this.cbxMaBenhNhan.TabIndex = 7;
            this.cbxMaBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbxMaBenhNhan_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(799, 180);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 49);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(799, 104);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 49);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.Location = new System.Drawing.Point(396, 144);
            this.txtTenBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(187, 24);
            this.txtTenBenhNhan.TabIndex = 10;
            // 
            // lblDanhSachPhieuKham
            // 
            this.lblDanhSachPhieuKham.AutoSize = true;
            this.lblDanhSachPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachPhieuKham.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhSachPhieuKham.Location = new System.Drawing.Point(469, 418);
            this.lblDanhSachPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachPhieuKham.Name = "lblDanhSachPhieuKham";
            this.lblDanhSachPhieuKham.Size = new System.Drawing.Size(261, 25);
            this.lblDanhSachPhieuKham.TabIndex = 28;
            this.lblDanhSachPhieuKham.Text = "Danh sách phiếu khám bệnh";
            // 
            // gbxThongTinPhieuKham
            // 
            this.gbxThongTinPhieuKham.Controls.Add(this.txtTuoi);
            this.gbxThongTinPhieuKham.Controls.Add(this.label2);
            this.gbxThongTinPhieuKham.Controls.Add(this.txtGioiTinh);
            this.gbxThongTinPhieuKham.Controls.Add(this.label1);
            this.gbxThongTinPhieuKham.Controls.Add(this.txtNgayKham);
            this.gbxThongTinPhieuKham.Controls.Add(this.txtTenBenhNhan);
            this.gbxThongTinPhieuKham.Controls.Add(this.txtTrieuChung);
            this.gbxThongTinPhieuKham.Controls.Add(this.cbxMaBenhNhan);
            this.gbxThongTinPhieuKham.Controls.Add(this.txtMaPhieuKham);
            this.gbxThongTinPhieuKham.Controls.Add(this.lblTrieuChung);
            this.gbxThongTinPhieuKham.Controls.Add(this.lblMaBenhNhan);
            this.gbxThongTinPhieuKham.Controls.Add(this.lblNgayKham);
            this.gbxThongTinPhieuKham.Controls.Add(this.lblSoPhieuKham);
            this.gbxThongTinPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxThongTinPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinPhieuKham.ForeColor = System.Drawing.Color.Navy;
            this.gbxThongTinPhieuKham.Location = new System.Drawing.Point(156, 89);
            this.gbxThongTinPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongTinPhieuKham.Name = "gbxThongTinPhieuKham";
            this.gbxThongTinPhieuKham.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongTinPhieuKham.Size = new System.Drawing.Size(617, 303);
            this.gbxThongTinPhieuKham.TabIndex = 22;
            this.gbxThongTinPhieuKham.TabStop = false;
            this.gbxThongTinPhieuKham.Text = " Thông tin phiếu khám";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Enabled = false;
            this.txtTuoi.Location = new System.Drawing.Point(183, 220);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(159, 24);
            this.txtTuoi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tuổi";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(183, 188);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(159, 24);
            this.txtGioiTinh.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giới tính";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Location = new System.Drawing.Point(183, 91);
            this.txtNgayKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(159, 24);
            this.txtNgayKham.TabIndex = 12;
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuKham.Enabled = false;
            this.txtMaPhieuKham.Location = new System.Drawing.Point(183, 38);
            this.txtMaPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.Size = new System.Drawing.Size(159, 24);
            this.txtMaPhieuKham.TabIndex = 5;
            // 
            // lblPhieuKhamBenh
            // 
            this.lblPhieuKhamBenh.AutoSize = true;
            this.lblPhieuKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuKhamBenh.ForeColor = System.Drawing.Color.Red;
            this.lblPhieuKhamBenh.Location = new System.Drawing.Point(537, 30);
            this.lblPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhieuKhamBenh.Name = "lblPhieuKhamBenh";
            this.lblPhieuKhamBenh.Size = new System.Drawing.Size(223, 31);
            this.lblPhieuKhamBenh.TabIndex = 21;
            this.lblPhieuKhamBenh.Text = "Phiếu khám bệnh";
            // 
            // FrmPhieuKham_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 674);
            this.Controls.Add(this.dgvPK);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDanhSachPhieuKham);
            this.Controls.Add(this.gbxThongTinPhieuKham);
            this.Controls.Add(this.lblPhieuKhamBenh);
            this.Name = "FrmPhieuKham_GUI";
            this.Text = "FrmPhieuKham_GUI";
            this.Load += new System.EventHandler(this.FrmPhieuKham_GUI_Load);
            this.Click += new System.EventHandler(this.FrmPhieuKham_GUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            this.gbxThongTinPhieuKham.ResumeLayout(false);
            this.gbxThongTinPhieuKham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvPK;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblTrieuChung;
        internal System.Windows.Forms.Label lblMaBenhNhan;
        internal System.Windows.Forms.Label lblNgayKham;
        internal System.Windows.Forms.Label lblSoPhieuKham;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.TextBox txtTrieuChung;
        internal System.Windows.Forms.ComboBox cbxMaBenhNhan;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.TextBox txtTenBenhNhan;
        internal System.Windows.Forms.Label lblDanhSachPhieuKham;
        internal System.Windows.Forms.GroupBox gbxThongTinPhieuKham;
        internal System.Windows.Forms.TextBox txtTuoi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtGioiTinh;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNgayKham;
        internal System.Windows.Forms.TextBox txtMaPhieuKham;
        internal System.Windows.Forms.Label lblPhieuKhamBenh;
    }
}