using QLPM_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLiPhongMach
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmBCHDNgay FrmBaoCaoNgay = new FrmBCHDNgay();
            FrmBaoCaoNgay.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBCHDTong FrmBaoCaoTong = new FrmBCHDTong();
            FrmBaoCaoTong.Show();
        }
    }
}
