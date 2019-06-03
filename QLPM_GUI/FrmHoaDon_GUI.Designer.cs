namespace QLPM_GUI
{
    partial class FrmHoaDon_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon_GUI));
            this.checkCoDungThuoc = new System.Windows.Forms.CheckBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxPhieuKham = new System.Windows.Forms.ComboBox();
            this.gbxThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.lblHoTenBenhNhan = new System.Windows.Forms.Label();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbxThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCoDungThuoc
            // 
            this.checkCoDungThuoc.AutoSize = true;
            this.checkCoDungThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCoDungThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCoDungThuoc.ForeColor = System.Drawing.Color.Navy;
            this.checkCoDungThuoc.Location = new System.Drawing.Point(590, 137);
            this.checkCoDungThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.checkCoDungThuoc.Name = "checkCoDungThuoc";
            this.checkCoDungThuoc.Size = new System.Drawing.Size(185, 28);
            this.checkCoDungThuoc.TabIndex = 19;
            this.checkCoDungThuoc.Text = "Không dùng thuốc";
            this.checkCoDungThuoc.UseVisualStyleBackColor = true;
            this.checkCoDungThuoc.CheckedChanged += new System.EventHandler(this.checkCoDungThuoc_CheckedChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(572, 482);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 49);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(47, 482);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxPhieuKham
            // 
            this.cbxPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPhieuKham.FormattingEnabled = true;
            this.cbxPhieuKham.Location = new System.Drawing.Point(291, 138);
            this.cbxPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPhieuKham.Name = "cbxPhieuKham";
            this.cbxPhieuKham.Size = new System.Drawing.Size(203, 24);
            this.cbxPhieuKham.TabIndex = 16;
            this.cbxPhieuKham.SelectedIndexChanged += new System.EventHandler(this.cbxPhieuKham_SelectedIndexChanged);
            // 
            // gbxThongTinHoaDon
            // 
            this.gbxThongTinHoaDon.Controls.Add(this.label1);
            this.gbxThongTinHoaDon.Controls.Add(this.txtNgayKham);
            this.gbxThongTinHoaDon.Controls.Add(this.txtDiaChi);
            this.gbxThongTinHoaDon.Controls.Add(this.label2);
            this.gbxThongTinHoaDon.Controls.Add(this.txtTienThuoc);
            this.gbxThongTinHoaDon.Controls.Add(this.txtMaBenhNhan);
            this.gbxThongTinHoaDon.Controls.Add(this.txtHoVaTen);
            this.gbxThongTinHoaDon.Controls.Add(this.txtTienKham);
            this.gbxThongTinHoaDon.Controls.Add(this.lblTienThuoc);
            this.gbxThongTinHoaDon.Controls.Add(this.lblTienKham);
            this.gbxThongTinHoaDon.Controls.Add(this.lblMaBenhNhan);
            this.gbxThongTinHoaDon.Controls.Add(this.lblHoTenBenhNhan);
            this.gbxThongTinHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinHoaDon.ForeColor = System.Drawing.Color.Navy;
            this.gbxThongTinHoaDon.Location = new System.Drawing.Point(22, 191);
            this.gbxThongTinHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongTinHoaDon.Name = "gbxThongTinHoaDon";
            this.gbxThongTinHoaDon.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongTinHoaDon.Size = new System.Drawing.Size(804, 267);
            this.gbxThongTinHoaDon.TabIndex = 14;
            this.gbxThongTinHoaDon.TabStop = false;
            this.gbxThongTinHoaDon.Text = " Thông tin hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ngày khám";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Location = new System.Drawing.Point(594, 41);
            this.txtNgayKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(159, 24);
            this.txtNgayKham.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(183, 148);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(159, 24);
            this.txtDiaChi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Địa chỉ";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Enabled = false;
            this.txtTienThuoc.Location = new System.Drawing.Point(594, 90);
            this.txtTienThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Size = new System.Drawing.Size(159, 24);
            this.txtTienThuoc.TabIndex = 15;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.Location = new System.Drawing.Point(183, 42);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(159, 24);
            this.txtMaBenhNhan.TabIndex = 13;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Enabled = false;
            this.txtHoVaTen.Location = new System.Drawing.Point(183, 90);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(159, 24);
            this.txtHoVaTen.TabIndex = 12;
            // 
            // txtTienKham
            // 
            this.txtTienKham.Enabled = false;
            this.txtTienKham.Location = new System.Drawing.Point(594, 149);
            this.txtTienKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Size = new System.Drawing.Size(159, 24);
            this.txtTienKham.TabIndex = 8;
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThuoc.ForeColor = System.Drawing.Color.Black;
            this.lblTienThuoc.Location = new System.Drawing.Point(468, 89);
            this.lblTienThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(100, 24);
            this.lblTienThuoc.TabIndex = 4;
            this.lblTienThuoc.Text = "Tiền thuốc";
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKham.ForeColor = System.Drawing.Color.Black;
            this.lblTienKham.Location = new System.Drawing.Point(469, 147);
            this.lblTienKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(99, 24);
            this.lblTienKham.TabIndex = 3;
            this.lblTienKham.Text = "Tiền khám";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(21, 42);
            this.lblMaBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(133, 24);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // lblHoTenBenhNhan
            // 
            this.lblHoTenBenhNhan.AutoSize = true;
            this.lblHoTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenBenhNhan.Location = new System.Drawing.Point(21, 90);
            this.lblHoTenBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenBenhNhan.Name = "lblHoTenBenhNhan";
            this.lblHoTenBenhNhan.Size = new System.Drawing.Size(90, 24);
            this.lblHoTenBenhNhan.TabIndex = 1;
            this.lblHoTenBenhNhan.Text = "Họ và tên";
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuKham.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(118, 138);
            this.lblMaPhieuKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(140, 24);
            this.lblMaPhieuKham.TabIndex = 0;
            this.lblMaPhieuKham.Text = "Mã phiếu khám";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Red;
            this.lblHoaDon.Location = new System.Drawing.Point(584, 60);
            this.lblHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(251, 31);
            this.lblHoaDon.TabIndex = 13;
            this.lblHoaDon.Text = "Hóa đơn thanh toán\r\n";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(834, 200);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(435, 331);
            this.dgvHoaDon.TabIndex = 38;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(291, 482);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(108, 49);
            this.BtnXoa.TabIndex = 40;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(468, 30);
            this.PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(85, 72);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox4.TabIndex = 41;
            this.PictureBox4.TabStop = false;
            // 
            // FrmHoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1291, 582);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.checkCoDungThuoc);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxPhieuKham);
            this.Controls.Add(this.gbxThongTinHoaDon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblMaPhieuKham);
            this.Name = "FrmHoaDon_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon_GUI";
            this.Load += new System.EventHandler(this.FrmHoaDon_GUI_Load);
            this.Click += new System.EventHandler(this.FrmHoaDon_GUI_Click);
            this.gbxThongTinHoaDon.ResumeLayout(false);
            this.gbxThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox checkCoDungThuoc;
        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.ComboBox cbxPhieuKham;
        internal System.Windows.Forms.GroupBox gbxThongTinHoaDon;
        internal System.Windows.Forms.TextBox txtTienThuoc;
        internal System.Windows.Forms.TextBox txtMaBenhNhan;
        internal System.Windows.Forms.TextBox txtHoVaTen;
        internal System.Windows.Forms.TextBox txtTienKham;
        internal System.Windows.Forms.Label lblTienThuoc;
        internal System.Windows.Forms.Label lblTienKham;
        internal System.Windows.Forms.Label lblMaBenhNhan;
        internal System.Windows.Forms.Label lblHoTenBenhNhan;
        internal System.Windows.Forms.Label lblMaPhieuKham;
        internal System.Windows.Forms.Label lblHoaDon;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvHoaDon;
        internal System.Windows.Forms.Button BtnXoa;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNgayKham;
        internal System.Windows.Forms.PictureBox PictureBox4;
    }
}