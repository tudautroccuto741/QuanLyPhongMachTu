using QLPM_DTO;
using QLPM_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace DoAnQuanLiPhongMach
{
    public partial class Form1 : Form
    {
        public static string username = "";
        public string _LoginUser = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn phải đăng nhập trước!!!!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin_GUI FrmLogin = new FrmLogin_GUI();
            FrmLogin.Show();
        }

        private void btnBaoCaoDungThuoc_Click(object sender, EventArgs e)
        {
     

        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
       
        }
    }
}
