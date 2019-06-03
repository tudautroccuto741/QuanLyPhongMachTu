namespace QLPM_GUI
{
    partial class FrmCachDung_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCachDung_GUI));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvCachDung = new System.Windows.Forms.DataGridView();
            this.txtTenCachDung = new System.Windows.Forms.TextBox();
            this.txtMaCachDungMoi = new System.Windows.Forms.TextBox();
            this.lblTenCachDung = new System.Windows.Forms.Label();
            this.lblMaCachDung = new System.Windows.Forms.Label();
            this.picPhieuKhamBenh = new System.Windows.Forms.PictureBox();
            this.lblThemDonVi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(182, 283);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 49);
            this.btnXoa.TabIndex = 59;
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
            this.btnCapNhat.Location = new System.Drawing.Point(358, 283);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 49);
            this.btnCapNhat.TabIndex = 58;
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
            this.btnHuy.Location = new System.Drawing.Point(537, 283);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 49);
            this.btnHuy.TabIndex = 57;
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
            this.btnThem.Location = new System.Drawing.Point(14, 283);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 49);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvCachDung
            // 
            this.dgvCachDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachDung.Location = new System.Drawing.Point(358, 87);
            this.dgvCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCachDung.Name = "dgvCachDung";
            this.dgvCachDung.Size = new System.Drawing.Size(536, 171);
            this.dgvCachDung.TabIndex = 55;
            this.dgvCachDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCachDung_CellClick);
            // 
            // txtTenCachDung
            // 
            this.txtTenCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCachDung.Location = new System.Drawing.Point(213, 194);
            this.txtTenCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCachDung.Name = "txtTenCachDung";
            this.txtTenCachDung.Size = new System.Drawing.Size(123, 29);
            this.txtTenCachDung.TabIndex = 54;
            this.txtTenCachDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaCachDungMoi
            // 
            this.txtMaCachDungMoi.Enabled = false;
            this.txtMaCachDungMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCachDungMoi.Location = new System.Drawing.Point(213, 107);
            this.txtMaCachDungMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCachDungMoi.Name = "txtMaCachDungMoi";
            this.txtMaCachDungMoi.Size = new System.Drawing.Size(123, 29);
            this.txtMaCachDungMoi.TabIndex = 53;
            this.txtMaCachDungMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTenCachDung
            // 
            this.lblTenCachDung.AutoSize = true;
            this.lblTenCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCachDung.ForeColor = System.Drawing.Color.Black;
            this.lblTenCachDung.Location = new System.Drawing.Point(9, 197);
            this.lblTenCachDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenCachDung.Name = "lblTenCachDung";
            this.lblTenCachDung.Size = new System.Drawing.Size(175, 24);
            this.lblTenCachDung.TabIndex = 52;
            this.lblTenCachDung.Text = "Tên cách dùng mới";
            // 
            // lblMaCachDung
            // 
            this.lblMaCachDung.AutoSize = true;
            this.lblMaCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCachDung.ForeColor = System.Drawing.Color.Black;
            this.lblMaCachDung.Location = new System.Drawing.Point(9, 111);
            this.lblMaCachDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCachDung.Name = "lblMaCachDung";
            this.lblMaCachDung.Size = new System.Drawing.Size(167, 24);
            this.lblMaCachDung.TabIndex = 51;
            this.lblMaCachDung.Text = "Mã cách dùng mới";
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Image = ((System.Drawing.Image)(resources.GetObject("picPhieuKhamBenh.Image")));
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(369, 13);
            this.picPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(60, 55);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 50;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblThemDonVi
            // 
            this.lblThemDonVi.AutoSize = true;
            this.lblThemDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemDonVi.ForeColor = System.Drawing.Color.Red;
            this.lblThemDonVi.Location = new System.Drawing.Point(473, 25);
            this.lblThemDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThemDonVi.Name = "lblThemDonVi";
            this.lblThemDonVi.Size = new System.Drawing.Size(145, 31);
            this.lblThemDonVi.TabIndex = 49;
            this.lblThemDonVi.Text = "Cách dùng";
            // 
            // FrmCachDung_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1024, 412);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCachDung);
            this.Controls.Add(this.txtTenCachDung);
            this.Controls.Add(this.txtMaCachDungMoi);
            this.Controls.Add(this.lblTenCachDung);
            this.Controls.Add(this.lblMaCachDung);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.lblThemDonVi);
            this.Name = "FrmCachDung_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCachDung_GUI";
            this.Load += new System.EventHandler(this.FrmCachDung_GUI_Load);
            this.Click += new System.EventHandler(this.FrmCachDung_GUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnCapNhat;
        internal System.Windows.Forms.Button btnHuy;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.DataGridView dgvCachDung;
        internal System.Windows.Forms.TextBox txtTenCachDung;
        internal System.Windows.Forms.TextBox txtMaCachDungMoi;
        internal System.Windows.Forms.Label lblTenCachDung;
        internal System.Windows.Forms.Label lblMaCachDung;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblThemDonVi;
    }
}