namespace QLPM_GUI
{
    partial class FrmBCHDNgay
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
            this.crpView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOutput = new System.Windows.Forms.DateTimePicker();
            this.dtpInput = new System.Windows.Forms.DateTimePicker();
            this.btLapBaoCao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crpBCHDNgay1 = new QLPM_GUI.crpBCHDNgay();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crpView
            // 
            this.crpView.ActiveViewIndex = 0;
            this.crpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpView.Location = new System.Drawing.Point(3, 16);
            this.crpView.Name = "crpView";
            this.crpView.ReportSource = this.crpBCHDNgay1;
            this.crpView.Size = new System.Drawing.Size(770, 324);
            this.crpView.TabIndex = 0;
            this.crpView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOutput);
            this.groupBox1.Controls.Add(this.dtpInput);
            this.groupBox1.Controls.Add(this.btLapBaoCao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập ngày cần xem";
            // 
            // dtpOutput
            // 
            this.dtpOutput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOutput.Location = new System.Drawing.Point(284, 19);
            this.dtpOutput.Name = "dtpOutput";
            this.dtpOutput.Size = new System.Drawing.Size(102, 20);
            this.dtpOutput.TabIndex = 5;
            // 
            // dtpInput
            // 
            this.dtpInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInput.Location = new System.Drawing.Point(117, 19);
            this.dtpInput.Name = "dtpInput";
            this.dtpInput.Size = new System.Drawing.Size(95, 20);
            this.dtpInput.TabIndex = 4;
            // 
            // btLapBaoCao
            // 
            this.btLapBaoCao.Location = new System.Drawing.Point(456, 20);
            this.btLapBaoCao.Name = "btLapBaoCao";
            this.btLapBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btLapBaoCao.TabIndex = 3;
            this.btLapBaoCao.Text = "Lập báo cáo";
            this.btLapBaoCao.UseVisualStyleBackColor = true;
            this.btLapBaoCao.Click += new System.EventHandler(this.btLapBaoCao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crpView);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 343);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // FrmBCHDNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmBCHDNgay";
            this.Text = "FrmBCHDNgay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpView;
        private crpBCHDNgay crpBCHDNgay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOutput;
        private System.Windows.Forms.DateTimePicker dtpInput;
        private System.Windows.Forms.Button btLapBaoCao;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}