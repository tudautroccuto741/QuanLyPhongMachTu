namespace QLPM_GUI
{
    partial class FrmBCHDTong
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
            this.crpBCHDTong1 = new QLPM_GUI.crpBCHDTong();
            this.SuspendLayout();
            // 
            // crpView
            // 
            this.crpView.ActiveViewIndex = 0;
            this.crpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpView.Location = new System.Drawing.Point(0, 0);
            this.crpView.Name = "crpView";
            this.crpView.ReportSource = this.crpBCHDTong1;
            this.crpView.Size = new System.Drawing.Size(800, 450);
            this.crpView.TabIndex = 0;
            this.crpView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crpView.Load += new System.EventHandler(this.crpView_Load);
            // 
            // FrmBCHDTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpView);
            this.Name = "FrmBCHDTong";
            this.Text = "FrmBCHDTong";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpView;
        private crpBCHDTong crpBCHDTong1;
    }
}