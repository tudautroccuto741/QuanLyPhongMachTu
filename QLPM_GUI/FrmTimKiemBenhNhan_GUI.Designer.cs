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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHoTenBenhNhan
            // 
            this.cbHoTenBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHoTenBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoTenBenhNhan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbHoTenBenhNhan.FormattingEnabled = true;
            this.cbHoTenBenhNhan.Location = new System.Drawing.Point(410, 130);
            this.cbHoTenBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbHoTenBenhNhan.Name = "cbHoTenBenhNhan";
            this.cbHoTenBenhNhan.Size = new System.Drawing.Size(253, 24);
            this.cbHoTenBenhNhan.TabIndex = 25;
            this.cbHoTenBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbHoTenBenhNhan_SelectedIndexChanged);
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Location = new System.Drawing.Point(45, 172);
            this.dgvTraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.Size = new System.Drawing.Size(957, 342);
            this.dgvTraCuu.TabIndex = 24;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.ForeColor = System.Drawing.Color.Black;
            this.lblNgayKham.Location = new System.Drawing.Point(256, 130);
            this.lblNgayKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(66, 24);
            this.lblNgayKham.TabIndex = 23;
            this.lblNgayKham.Text = "Họ tên";
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Image = ((System.Drawing.Image)(resources.GetObject("picPhieuKhamBenh.Image")));
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(410, 24);
            this.picPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(73, 68);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 22;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Red;
            this.lblTimKiem.Location = new System.Drawing.Point(518, 43);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(123, 31);
            this.lblTimKiem.TabIndex = 21;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // FrmTimKiemBenhNhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1047, 532);
            this.Controls.Add(this.cbHoTenBenhNhan);
            this.Controls.Add(this.dgvTraCuu);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.lblTimKiem);
            this.Name = "FrmTimKiemBenhNhan_GUI";
            this.Text = "FrmTimKiemBenhNhan_GUI";
            this.Load += new System.EventHandler(this.FrmTimKiemBenhNhan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbHoTenBenhNhan;
        internal System.Windows.Forms.DataGridView dgvTraCuu;
        internal System.Windows.Forms.Label lblNgayKham;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblTimKiem;
    }
}