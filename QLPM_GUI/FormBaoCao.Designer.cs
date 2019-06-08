namespace DoAnQuanLiPhongMach
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.picPhieuKhamBenh = new System.Windows.Forms.PictureBox();
            this.lblThemDonVi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 62;
            this.button1.Text = "Báo cáo tổng doanh thu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(158, 152);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 75);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Báo cáo doanh thu theo ngày";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picPhieuKhamBenh
            // 
            this.picPhieuKhamBenh.Image = ((System.Drawing.Image)(resources.GetObject("picPhieuKhamBenh.Image")));
            this.picPhieuKhamBenh.Location = new System.Drawing.Point(233, 13);
            this.picPhieuKhamBenh.Name = "picPhieuKhamBenh";
            this.picPhieuKhamBenh.Size = new System.Drawing.Size(50, 50);
            this.picPhieuKhamBenh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhieuKhamBenh.TabIndex = 60;
            this.picPhieuKhamBenh.TabStop = false;
            // 
            // lblThemDonVi
            // 
            this.lblThemDonVi.AutoSize = true;
            this.lblThemDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemDonVi.ForeColor = System.Drawing.Color.Red;
            this.lblThemDonVi.Location = new System.Drawing.Point(329, 38);
            this.lblThemDonVi.Name = "lblThemDonVi";
            this.lblThemDonVi.Size = new System.Drawing.Size(207, 25);
            this.lblThemDonVi.TabIndex = 59;
            this.lblThemDonVi.Text = "Báo Cáo Doanh Thu";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picPhieuKhamBenh);
            this.Controls.Add(this.lblThemDonVi);
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.picPhieuKhamBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.PictureBox picPhieuKhamBenh;
        internal System.Windows.Forms.Label lblThemDonVi;
    }
}