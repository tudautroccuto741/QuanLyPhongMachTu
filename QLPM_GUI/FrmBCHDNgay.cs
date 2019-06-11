using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPM_GUI
{
    public partial class FrmBCHDNgay : Form
    {
        public FrmBCHDNgay()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btLapBaoCao_Click(object sender, EventArgs e)
        {
            crpBCHDNgay1.SetParameterValue("starDate", dtpInput.Value);
            crpBCHDNgay1.SetParameterValue("endDate", dtpOutput.Value);
            crpView.ReportSource = crpBCHDNgay1;
            crpView.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
