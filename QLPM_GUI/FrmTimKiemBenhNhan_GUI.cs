using QLPM_DTO;
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
    public partial class FrmTimKiemBenhNhan_GUI : Form
    {
        DataTable table_BenhNhan = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_Test = new DataTable();
        DataTable table_Timkiem = new DataTable();
        DataRow row;
        string hoten, mabn;
        int indexbn;
        public FrmTimKiemBenhNhan_GUI()
        {
            InitializeComponent();
        }

        private void FrmTimKiemBenhNhan_GUI_Load(object sender, EventArgs e)
        {
            table_BenhNhan = DataProvider.LoadCSDL("Select * from tbl_BenhNhan");
            //  table_Test = DataProvider.LoadCSDL("SELECT BenhNhan.hotenbenhnhan, PhieuKham.ngaykham, LoaiBenh.tenloaibenh, PhieuKham.trieuchungFROM(PhieuKham INNER JOIN BenhNhan ON PhieuKham.mabenhnhan = BenhNhan.mabenhnhan) INNER JOIN LoaiBenh ON PhieuKham.maloaibenh = LoaiBenh.maloaibenh;")
            cbHoTenBenhNhan.DataSource = table_BenhNhan;
            cbHoTenBenhNhan.DisplayMember = "HotenBN";
            cbHoTenBenhNhan.Enabled = true;
            HienThi();
        }
        private void HienThi()
        {
            dgvTraCuu.DataSource = table_BenhNhan;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            table_Timkiem = DataProvider.LoadCSDL("Select * from tbl_BenhNhan where HotenBN Like  '%" + txtTimKiem.Text + "%'");
            dgvTraCuu.DataSource = table_Timkiem;
        }

        private void cbHoTenBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
       //     hoten = cbHoTenBenhNhan.Text;
            indexbn = cbHoTenBenhNhan.SelectedIndex;
            row = table_BenhNhan.Rows[indexbn];
            mabn = row["MaBenhNhan"].ToString();
            table_Test = DataProvider.LoadCSDL("Select * from tbl_BenhNhan where MaBenhNhan =  '" + mabn + "'");

            dgvTraCuu.DataSource = table_Test;
            dgvTraCuu.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            dgvTraCuu.Columns["HotenBN"].HeaderText = "Họ Tên";
            dgvTraCuu.Columns["NamsinhBN"].HeaderText = "Năm Sinh";
            dgvTraCuu.Columns["DiachiBN"].HeaderText = "Địa Chỉ";
            dgvTraCuu.Columns["GioitinhBN"].HeaderText = "Giới Tính";
            dgvTraCuu.Columns["Ngaykham"].HeaderText = "Ngày Khám";
            dgvTraCuu.Columns["CMND"].HeaderText = "CMND";


            dgvTraCuu.DataSource = table_Test;
        }
    }
}
