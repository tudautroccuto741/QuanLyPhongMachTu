namespace QLPM_GUI
{
    partial class FrmTimKiemBenhNhan_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemBenhNhan_GUI));
            this.cbHoTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.picPhieuKhamBenh = new System.Windows.Forms.PictureBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHoTenBenhNhan
            // 
            this.cbHoTenBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHoTenBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoTenBenhNhan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbHoTenBenhNhan.FormattingEnabled = true;
            this.cbHoTenBenhNhan.Location = new System.Drawing.Point(172, 105);
            this.cbHoTenBenhNhan.Name = "cbHoTenBenhNhan";
            this.cbHoTenBenhNhan.Size = new System.Drawing.Size(191, 21);
            this.cbHoTenBenhNhan.TabIndex = 25;
            this.cbHoTenBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbHoTenBenhNhan_SelectedIndexChanged);
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Location = new System.Drawing.Point(34, 140);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.Size = new System.Drawing.Size(718, 278);
            this.dgvTraCuu.TabIndex = 24;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.ForeColor = System.Drawing.Color.Black;
            this.lblNgayKham.Location = new System.Drawing.Point(88, 105);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(52, 18);
            this.lblNgayKham.TabIndex = 23;
            this.lblNgayKham.Text = "Họ tên";
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Image = ((System.Drawing.Image)(resources.GetObject("picPhieuKhamBenh.Image")));
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(308, 20);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(55, 55);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 22;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Red;
            this.lblTimKiem.Location = new System.Drawing.Point(388, 35);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(98, 25);
            this.lblTimKiem.TabIndex = 21;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(443, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(533, 103);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(138, 20);
            this.txtTimKiem.TabIndex = 27;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmTimKiemBenhNhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(785, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHoTenBenhNhan);
            this.Controls.Add(this.dgvTraCuu);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.lblTimKiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTimKiemBenhNhan_GUI";
            this.Text = "FrmTimKiemBenhNhan_GUI";
            this.Load += new System.EventHandler(this.FrmTimKiemBenhNhan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbHoTenBenhNhan;
        internal System.Windows.Forms.DataGridView dgvTraCuu;
        internal System.Windows.Forms.Label lblNgayKham;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblTimKiem;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtTimKiem;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}