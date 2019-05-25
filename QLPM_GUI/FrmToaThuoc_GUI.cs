using QLPM_BUS;
using QLPM_DTO;
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

namespace QLPM_GUI
{
    public partial class FrmToaThuoc_GUI : Form
    {

        //Những biến dùng chung
        DataTable table_PhieuKham = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_BenhNhan = new DataTable();
        DataTable table_NhanSu = new DataTable();
        DataTable table_Thuoc = new DataTable();
        DataTable table_CachDung = new DataTable();
        DataTable table_Benh = new DataTable();
        DataTable table_Important = new DataTable();
        DataTable table_DonVi = new DataTable();
        DataTable table_USER = new DataTable();
        DataTable table_DataGridView = new DataTable();


        DataRow row, row_phieukham,row_LoginUser;
        DataRow row_benhnhan,row_thuoc,row_donvi,row_cachdung,row_benh;
        
        ToaThuoc_DTO tt_DTO;
        ToaThuoc_BUS tt_BUS;


        int index, indexdv, indexcd;
        string _usename = "";
        public  string _Loginuser = "";
        string manhansu = "USER_003";
        string mabn,matoathuoc,mathuoc,madonvi,macachdung,mabenh;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Cell CLick
        private void dgvToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvToaThuoc.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            cbxThuoc.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtDonVi.Text = row_bs.Cells[1].FormattedValue.ToString();
            cbxCachDung.Text = row_bs.Cells[2].FormattedValue.ToString();
            txtSoLuong.Text = row_bs.Cells[3].FormattedValue.ToString();


        }


        //Cập Nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDonVi.Text.Trim().Equals("") || txtSoLuong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn cập nhật thuốc vào toa thuốc", "Cập Nhật Toa Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {

                    tt_DTO = new ToaThuoc_DTO();
                    tt_BUS = new ToaThuoc_BUS();


               
                    tt_DTO.MaPhieuKham = cbxPhieuKham.Text.Trim();  
                    tt_DTO.MaCachDung = macachdung;
                    tt_DTO.Soluong = txtSoLuong.Text;
                    tt_DTO.MaThuoc = mathuoc;
                    tt_DTO.MaToaThuoc = matoathuoc;
                    tt_BUS.SuaThongTinToaThuoc(tt_DTO);

                    FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
                    Close();
                    FrmToaThuoc.Show();
                }
            }
        }

        //Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa thuốc", "Xóa Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                tt_DTO = new ToaThuoc_DTO();
                tt_BUS = new ToaThuoc_BUS();

                tt_DTO.MaThuoc = mathuoc;
                tt_DTO.MaPhieuKham = cbxPhieuKham.Text;
                tt_BUS.XoaToaThuoc(tt_DTO);

            }

            FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
            Close();
            FrmToaThuoc.Show();
        }




        //Combobox Bệnh
        private void cbxBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexcd = cbxCachDung.SelectedIndex;
            row_benh = table_Benh.Rows[indexcd];
            mabenh = row_benh["MaBenh"].ToString();
        }

      
        //Combox Cách Dùng
        private void cbxCachDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexcd = cbxCachDung.SelectedIndex;
            row_cachdung = table_CachDung.Rows[indexcd];
            macachdung = row_cachdung["MaCachDung"].ToString();
           // table_DonVi = DataProvider.LoadCSDL("Select tbl_DonVi.Tendonvi FROM(tbl_Thuoc INNER JOIN tbl_DonVi ON tbl_Thuoc.MaDonVi = tbl_DonVi.MaDonVi) Where tbl_Thuoc.MaThuoc='" + mathuoc + "'");
         //   row_donvi = table_DonVi.Rows[0];
          //  txtDonVi.Text = row_donvi["Tendonvi"].ToString();
        }

     
        public FrmToaThuoc_GUI()
        {
            InitializeComponent();
        }

     
        private void FrmToaThuoc_GUI_Load(object sender, EventArgs e)
        {
            
            table_PhieuKham = DataProvider.LoadCSDL("select * from tbl_PhieuKham");
            table_BenhNhan = DataProvider.LoadCSDL("select * from tbl_BenhNhan");
            table_NhanSu = DataProvider.LoadCSDL("select * from tbl_NhanSu");
            table_CachDung = DataProvider.LoadCSDL("select * from tbl_CachDung");
            table_Thuoc = DataProvider.LoadCSDL("select * from tbl_Thuoc");
            table_Benh = DataProvider.LoadCSDL("select * from tbl_ChuanDoan");
            table_USER = DataProvider.LoadCSDL("select * from tbl_NhanSu where MaNhanSu='USER_003'");
            
            cbxPhieuKham.DataSource = table_PhieuKham;
            cbxPhieuKham.DisplayMember = "MaPhieuKham";
            cbxPhieuKham.Enabled = true;
 
            cbxCachDung.DataSource = table_CachDung;
            cbxCachDung.DisplayMember = "Tencachdung";
            cbxCachDung.Enabled = true;

            cbxThuoc.DataSource = table_Thuoc;
            cbxThuoc.DisplayMember = "Tenthuoc";
            cbxThuoc.Enabled = true;

            cbxBenh.DataSource = table_Benh;
            cbxBenh.DisplayMember = "Tenbenh";
            cbxBenh.Enabled = true;

            row_LoginUser = table_USER.Rows[0];
            txtTenBacSi.Text = row_LoginUser["HotenNS"].ToString();
            matoathuoc = DataProvider.Auto_Create_MaToaThuoc();
            Tao_DGV();
            HienThi();
        }
        
        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtDonVi.Text.Trim().Equals("")|| txtSoLuong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm thuốc vào toa thuốc", "Thêm Toa Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                     
                    tt_DTO = new ToaThuoc_DTO();
                    tt_BUS = new ToaThuoc_BUS();


                    tt_DTO.MaToaThuoc = matoathuoc;
                    tt_DTO.MaPhieuKham = cbxPhieuKham.Text.Trim();
                    tt_DTO.MaBenhNhan = mabn;
                    tt_DTO.MaBenh = mabenh;
                    tt_DTO.MaCachDung = macachdung;
                    tt_DTO.Soluong = txtSoLuong.Text;
                    tt_DTO.MaNhanSu = manhansu;
                    tt_DTO.MaThuoc = mathuoc;
                    tt_BUS.NhapThongTinToaThuocMoi(tt_DTO);

                    FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
                    Close();
                    FrmToaThuoc.Show();
                }
            }
        }

        private void cbxThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexdv = cbxThuoc.SelectedIndex;
            row_thuoc = table_Thuoc.Rows[indexdv];
            mathuoc = row_thuoc["MaThuoc"].ToString();
            table_DonVi = DataProvider.LoadCSDL("Select tbl_DonVi.Tendonvi FROM(tbl_Thuoc INNER JOIN tbl_DonVi ON tbl_Thuoc.MaDonVi = tbl_DonVi.MaDonVi) Where tbl_Thuoc.MaThuoc='"+ mathuoc + "'");
            row_donvi = table_DonVi.Rows[0];
            txtDonVi.Text = row_donvi["Tendonvi"].ToString();
        }

        private void cbxPhieuKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbxPhieuKham.SelectedIndex;
            row = table_PhieuKham.Rows[index];

            //     row_ngaykham = table_NgayKham.Rows[1];
            mabn = row["MaBenhNhan"].ToString();
            
            table_Important = DataProvider.LoadCSDL("SELECT tbl_BenhNhan.MaBenhNhan, tbl_BenhNhan.HotenBN, tbl_BenhNhan.GioitinhBN, tbl_BenhNhan.NamsinhBN, tbl_BenhNhan.DiachiBN FROM(tbl_PhieuKham INNER JOIN tbl_BenhNhan ON tbl_PhieuKham.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) WHERE (Tbl_PhieuKham.MaBenhNhan) = '" + mabn + "'");

            row_phieukham = table_Important.Rows[0];

            string sql = "SELECT tbl_Thuoc.Tenthuoc,Tbl_DonVi.Tendonvi, Tbl_CachDung.Tencachdung, Tbl_ToaThuoc.Soluong FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc INNER JOIN Tbl_CachDung ON Tbl_CachDung.MaCachDung = tbl_ToaThuoc.MaCachDung) INNER Join Tbl_DonVi ON Tbl_DonVi.MaDonVi = Tbl_Thuoc.MaDonVi Where tbl_ToaThuoc.MaPhieuKham = '" + cbxPhieuKham.Text + "'";
            table_DataGridView = DataProvider.LoadCSDL(sql);
            dgvToaThuoc.DataSource = table_DataGridView;
            txtTenBN.Text = row_phieukham["HotenBN"].ToString();
            txtNamSinh.Text = row_phieukham["NamsinhBN"].ToString();
            txtGioiTinh.Text = row_phieukham["GioitinhBN"].ToString();
            txtDiaChi.Text = row_phieukham["DiachiBN"].ToString();

        }

        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {
            DataColumn _tenthuoc = new DataColumn("Tenthuoc");
            DataColumn _tencachdung = new DataColumn("Tencachdung");
            DataColumn _soluong = new DataColumn("Soluong");
            DataColumn _tendonvi = new DataColumn("Tendonvi");
            table_ChiTiet.Columns.Add(_tenthuoc);
            table_ChiTiet.Columns.Add(_tencachdung);
            table_ChiTiet.Columns.Add(_tendonvi);
            table_ChiTiet.Columns.Add(_soluong);
          /*  SELECT tbl_Thuoc.Tenthuoc,Tbl_DonVi.Tendonvi, Tbl_CachDung.Tencachdung, Tbl_ToaThuoc.Soluong
              FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc
              INNER JOIN Tbl_CachDung ON Tbl_CachDung.MaCachDung = tbl_ToaThuoc.MaCachDung) INNER Join Tbl_DonVi ON Tbl_DonVi.MaDonVi = Tbl_Thuoc.MaDonVi
              Where tbl_ToaThuoc.MaPhieuKham = 'PK_001'*/

            string sql = "SELECT tbl_Thuoc.Tenthuoc,Tbl_DonVi.Tendonvi, Tbl_CachDung.Tencachdung, Tbl_ToaThuoc.Soluong FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc INNER JOIN Tbl_CachDung ON Tbl_CachDung.MaCachDung = tbl_ToaThuoc.MaCachDung) INNER Join Tbl_DonVi ON Tbl_DonVi.MaDonVi = Tbl_Thuoc.MaDonVi Where tbl_ToaThuoc.MaPhieuKham = '"+cbxPhieuKham.Text+"'";
            table_DataGridView = DataProvider.LoadCSDL(sql);
            table_ChiTiet = table_DataGridView;
            dgvToaThuoc.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvToaThuoc.DataSource = table_DataGridView;
            dgvToaThuoc.Columns["Tenthuoc"].HeaderText = "Tên Thuốc";
            dgvToaThuoc.Columns["Tendonvi"].HeaderText = "Tên Đơn Vị";
            dgvToaThuoc.Columns["Tencachdung"].HeaderText = "Tên Cách Dùng";
            dgvToaThuoc.Columns["Soluong"].HeaderText = "Số Lượng";
        }

    }
}
