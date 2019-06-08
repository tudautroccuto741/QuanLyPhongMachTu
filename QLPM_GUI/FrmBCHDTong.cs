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
    public partial class FrmBCHDTong : Form
    {
        public FrmBCHDTong()
        {
            
            InitializeComponent();
        }

        private void crpView_Load(object sender, EventArgs e)
        {
            crpBCHDTong rpt = new crpBCHDTong();
            crpView.ReportSource = rpt;
        }
    }
}
