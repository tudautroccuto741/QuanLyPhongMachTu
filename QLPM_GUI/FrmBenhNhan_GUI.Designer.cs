namespace QLPM_GUI
{
    partial class FrmBenhNhan_GUI
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gbxThongTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenChuyenMon = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.txtHoTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongTinBenhNhan = new System.Windows.Forms.Label();
            this.gbxThongTinBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(418, 203);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 49);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(418, 283);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 49);
            this.btnCapNhat.TabIndex = 57;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gbxThongTinBenhNhan
            // 
            this.gbxThongTinBenhNhan.Controls.Add(this.dtpNgayKham);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtNamSinh);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtCMND);
            this.gbxThongTinBenhNhan.Controls.Add(this.label1);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblTenChuyenMon);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtDiaChi);
            this.gbxThongTinBenhNhan.Controls.Add(this.dtpNamSinh);
            this.gbxThongTinBenhNhan.Controls.Add(this.RadioButton2);
            this.gbxThongTinBenhNhan.Controls.Add(this.RadioButton1);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtHoTenBenhNhan);
            this.gbxThongTinBenhNhan.Controls.Add(this.txtMaBenhNhan);
            this.gbxThongTinBenhNhan.Controls.Add(this.Label6);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblTrieuChung);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblGioiTinh);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblNgayKham);
            this.gbxThongTinBenhNhan.Controls.Add(this.lblMaBacSi);
            this.gbxThongTinBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxThongTinBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinBenhNhan.ForeColor = System.Drawing.Color.Navy;
            this.gbxThongTinBenhNhan.Location = new System.Drawing.Point(3, 117);
            this.gbxThongTinBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongTinBenhNhan.Name = "gbxThongTinBenhNhan";
            this.gbxThongTinBenhNhan.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongTinBenhNhan.Size = new System.Drawing.Size(395, 412);
            this.gbxThongTinBenhNhan.TabIndex = 53;
            this.gbxThongTinBenhNhan.TabStop = false;
            this.gbxThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(202, 300);
            this.dtpNgayKham.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(183, 24);
            this.dtpNgayKham.TabIndex = 29;
            this.dtpNgayKham.Value = new System.DateTime(2018, 6, 27, 0, 0, 0, 0);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(204, 179);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(183, 24);
            this.txtNamSinh.TabIndex = 28;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMND.Location = new System.Drawing.Point(203, 360);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(183, 24);
            this.txtCMND.TabIndex = 27;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "CMND";
            // 
            // lblTenChuyenMon
            // 
            this.lblTenChuyenMon.AutoSize = true;
            this.lblTenChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuyenMon.ForeColor = System.Drawing.Color.Black;
            this.lblTenChuyenMon.Location = new System.Drawing.Point(8, 301);
            this.lblTenChuyenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenChuyenMon.Name = "lblTenChuyenMon";
            this.lblTenChuyenMon.Size = new System.Drawing.Size(105, 24);
            this.lblTenChuyenMon.TabIndex = 24;
            this.lblTenChuyenMon.Text = "Ngày khám";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(107, 242);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(280, 24);
            this.txtDiaChi.TabIndex = 21;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSinh.Location = new System.Drawing.Point(202, 210);
            this.dtpNamSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(183, 24);
            this.dtpNamSinh.TabIndex = 15;
            this.dtpNamSinh.Value = new System.DateTime(2018, 6, 27, 0, 0, 0, 0);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton2.ForeColor = System.Drawing.Color.Black;
            this.RadioButton2.Location = new System.Drawing.Point(313, 134);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(56, 28);
            this.RadioButton2.TabIndex = 14;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Nữ";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton1.ForeColor = System.Drawing.Color.Black;
            this.RadioButton1.Location = new System.Drawing.Point(203, 134);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(71, 28);
            this.RadioButton1.TabIndex = 13;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Nam";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // txtHoTenBenhNhan
            // 
            this.txtHoTenBenhNhan.Location = new System.Drawing.Point(202, 87);
            this.txtHoTenBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenBenhNhan.Name = "txtHoTenBenhNhan";
            this.txtHoTenBenhNhan.Size = new System.Drawing.Size(183, 24);
            this.txtHoTenBenhNhan.TabIndex = 12;
            this.txtHoTenBenhNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.Location = new System.Drawing.Point(202, 38);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(183, 24);
            this.txtMaBenhNhan.TabIndex = 5;
            this.txtMaBenhNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(8, 242);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(67, 24);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Địa chỉ";
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.ForeColor = System.Drawing.Color.Black;
            this.lblTrieuChung.Location = new System.Drawing.Point(8, 191);
            this.lblTrieuChung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(90, 24);
            this.lblTrieuChung.TabIndex = 3;
            this.lblTrieuChung.Text = "Năm sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(8, 138);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(78, 24);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.ForeColor = System.Drawing.Color.Black;
            this.lblNgayKham.Location = new System.Drawing.Point(8, 86);
            this.lblNgayKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(163, 24);
            this.lblNgayKham.TabIndex = 1;
            this.lblNgayKham.Text = "Họ tên bệnh nhân";
            // 
            // lblMaBacSi
            // 
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBacSi.ForeColor = System.Drawing.Color.Black;
            this.lblMaBacSi.Location = new System.Drawing.Point(8, 36);
            this.lblMaBacSi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(133, 24);
            this.lblMaBacSi.TabIndex = 0;
            this.lblMaBacSi.Text = "Mã bệnh nhân";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(418, 359);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 49);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Location = new System.Drawing.Point(558, 128);
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.RowTemplate.Height = 24;
            this.dgvDSBN.Size = new System.Drawing.Size(708, 432);
            this.dgvDSBN.TabIndex = 58;
            this.dgvDSBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBN_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(418, 128);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 49);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongTinBenhNhan
            // 
            this.lblThongTinBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinBenhNhan.Location = new System.Drawing.Point(440, 23);
            this.lblThongTinBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinBenhNhan.Name = "lblThongTinBenhNhan";
            this.lblThongTinBenhNhan.Size = new System.Drawing.Size(304, 36);
            this.lblThongTinBenhNhan.TabIndex = 52;
            this.lblThongTinBenhNhan.Text = "Thông tin bệnh nhân\n";
            // 
            // FrmBenhNhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 651);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.gbxThongTinBenhNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvDSBN);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongTinBenhNhan);
            this.Name = "FrmBenhNhan_GUI";
            this.Text = "FrmBenhNhan_GUI";
            this.Load += new System.EventHandler(this.FrmBenhNhan_GUI_Load);
            this.Click += new System.EventHandler(this.FrmBenhNhan_GUI_Click);
            this.gbxThongTinBenhNhan.ResumeLayout(false);
            this.gbxThongTinBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.GroupBox gbxThongTinBenhNhan;
        internal System.Windows.Forms.DateTimePicker dtpNgayKham;
        internal System.Windows.Forms.TextBox txtNamSinh;
        internal System.Windows.Forms.TextBox txtCMND;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblTenChuyenMon;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.DateTimePicker dtpNamSinh;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.TextBox txtHoTenBenhNhan;
        internal System.Windows.Forms.TextBox txtMaBenhNhan;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblTrieuChung;
        internal System.Windows.Forms.Label lblGioiTinh;
        internal System.Windows.Forms.Label lblNgayKham;
        internal System.Windows.Forms.Label lblMaBacSi;
        internal System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvDSBN;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Label lblThongTinBenhNhan;
    }
}