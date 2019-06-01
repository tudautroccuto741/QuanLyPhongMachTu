using QLPM_BUS;
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
    public partial class FrmHoaDon_GUI : Form
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
        DataTable table_TienThuoc = new DataTable();
        DataTable table_DataGridView = new DataTable();
        DataTable table_HoaDon = new DataTable();
        DataTable table_ThamSo = new DataTable();
        DataTable table_T = new DataTable();

        DataTable table_ChiTietHoaDon = new DataTable();



        DataRow row, row_phieukham, row_LoginUser, row_ThamSo,row_tienthuoc;
        DataRow row_benhnhan, row_thuoc, row_donvi, row_cachdung, row_benh, row_cthd;

        HoaDon_DTO hd_DTO;
        HoaDon_BUS hd_BUS;
        ChiTietHoaDon_DTO cthd_DTO;
        ChiTietHoaDon_BUS cthd_BUS;

        string _usename = "";
        public string _Loginuser = "";
        string manhansu = "USER_002";
        string mabn, matoathuoc, mathuoc, mahoadon, macachdung, mabenh;

        private void FrmHoaDon_GUI_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        string strtienkham, strtienthuoc;
        int tienkham, tongtien,tienthuoc;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa thuốc", "Xóa Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                hd_DTO = new HoaDon_DTO();
                hd_BUS = new HoaDon_BUS();


                hd_DTO.MaHoaDon = mahoadon;
                


                cthd_DTO = new ChiTietHoaDon_DTO();
                cthd_BUS = new ChiTietHoaDon_BUS();
                cthd_DTO.MaHoaDon = mahoadon;

                hd_BUS.XoaHoaDon(hd_DTO);
                cthd_BUS.XoaChiTietHoaDon(cthd_DTO);

                FrmHoaDon_GUI FrmHoaDon = new FrmHoaDon_GUI();
                Close();
                FrmHoaDon.Show();
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvHoaDon.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            mahoadon = row_bs.Cells[0].FormattedValue.ToString();
            cbxPhieuKham.Text = row_bs.Cells[1].FormattedValue.ToString();
            txtMaBenhNhan.Text = row_bs.Cells[2].FormattedValue.ToString();
            txtTienKham.Text = row_bs.Cells[3].FormattedValue.ToString();
            txtTienThuoc.Text = row_bs.Cells[4].FormattedValue.ToString();
            txtHoVaTen.Text = row_bs.Cells[5].FormattedValue.ToString();
            txtNgayKham.Text = row_bs.Cells[6].FormattedValue.ToString();
        }

        private void checkCoDungThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCoDungThuoc.Checked == true)
            {
                txtTienThuoc.Text = "0";
                strtienthuoc = "0";
                tienthuoc = 0;
            }
            else if (checkCoDungThuoc.Checked == false)
                txtTienThuoc.Text = strtienthuoc;
        }

        int indexthamso,indextienthuoc;

        private void cbxPhieuKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbxPhieuKham.SelectedIndex;
            row = table_PhieuKham.Rows[index];

            //     row_ngaykham = table_NgayKham.Rows[1];
            mabn = row["MaBenhNhan"].ToString();

            table_Important = DataProvider.LoadCSDL("SELECT tbl_BenhNhan.MaBenhNhan, tbl_BenhNhan.HotenBN, tbl_BenhNhan.GioitinhBN, tbl_BenhNhan.NamsinhBN, tbl_BenhNhan.DiachiBN,tbl_BenhNhan.NgayKham FROM(tbl_PhieuKham INNER JOIN tbl_BenhNhan ON tbl_PhieuKham.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) WHERE (Tbl_PhieuKham.MaBenhNhan) = '" + mabn + "'");

            row_phieukham = table_Important.Rows[0];

            //string sql = "SELECT tbl_Thuoc.Tenthuoc,Tbl_DonVi.Tendonvi, Tbl_CachDung.Tencachdung, Tbl_ToaThuoc.Soluong FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc INNER JOIN Tbl_CachDung ON Tbl_CachDung.MaCachDung = tbl_ToaThuoc.MaCachDung) INNER Join Tbl_DonVi ON Tbl_DonVi.MaDonVi = Tbl_Thuoc.MaDonVi Where tbl_ToaThuoc.MaPhieuKham = '" + cbxPhieuKham.Text + "'";
            //   table_DataGridView = DataProvider.LoadCSDL(sql);
            //  dgvHoaDon.DataSource = table_ChiTiet;
            txtMaBenhNhan.Text = mabn;
            txtHoVaTen.Text = row_phieukham["HotenBN"].ToString();
            txtNgayKham.Text = row_phieukham["NgayKham"].ToString();
            txtDiaChi.Text = row_phieukham["DiachiBN"].ToString();



            string sql = "	SELECT SUM(tbl_Thuoc.Gia) AS 'Gia' FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc)WHERE Tbl_ToaThuoc.MaPhieuKham = '" + cbxPhieuKham.Text + "' ";
            table_TienThuoc = DataProvider.LoadCSDL(sql);
            row_tienthuoc = table_TienThuoc.Rows[0];
            strtienthuoc = row_tienthuoc["Gia"].ToString();
            txtTienThuoc.Text = strtienthuoc;

           


        }

        int index, indexdv;

        private void btnThem_Click(object sender, EventArgs e)
        {
         
                int blresult;
                blresult = 0;
                tienthuoc = Int32.Parse(strtienthuoc);
            //  string tong = (txtTienKham.Text + txtTienThuoc.Text).ToString();
            tongtien = tienthuoc + tienkham;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm thuốc vào toa thuốc", "Thêm Toa Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));

            //MessageBox.Show(blresult.ToString());
            //Tổng tiền

        
                if (blresult == 1)
                {

                    hd_DTO = new HoaDon_DTO();
                    hd_BUS = new HoaDon_BUS();

                    hd_DTO.MaHoaDon = mahoadon;
                    hd_DTO.MaPhieuKham = cbxPhieuKham.Text;
                    hd_DTO.MaBenhNhan = mabn;
                    hd_DTO.Tienkham = txtTienKham.Text;
                    hd_DTO.Tienthuoc = txtTienThuoc.Text;
                    hd_DTO.NgayKham = txtNgayKham.Text;

                    hd_BUS.NhapThongTinHoaDonMoi(hd_DTO);
                
                    cthd_DTO = new ChiTietHoaDon_DTO();
                    cthd_BUS = new ChiTietHoaDon_BUS();
                    cthd_DTO.MaHoaDon = mahoadon;
                    cthd_DTO.MaNhanSu = manhansu;
                    cthd_DTO.Ngaykham = txtNgayKham.Text;
                    cthd_DTO.Tongtien = tongtien.ToString();
                    cthd_BUS.NhapThongTinChiTietHoaDonMoi(cthd_DTO);

                    FrmHoaDon_GUI FrmHoaDon = new FrmHoaDon_GUI();
                    Close();
                    FrmHoaDon.Show();
                }
            
        }

        public FrmHoaDon_GUI()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_GUI_Load(object sender, EventArgs e)
        {

            table_PhieuKham = DataProvider.LoadCSDL("select * from tbl_PhieuKham");
            table_BenhNhan = DataProvider.LoadCSDL("select * from tbl_BenhNhan");
            table_NhanSu = DataProvider.LoadCSDL("select * from tbl_NhanSu ");
            table_CachDung = DataProvider.LoadCSDL("select * from tbl_CachDung");
            table_Thuoc = DataProvider.LoadCSDL("select * from tbl_Thuoc");
            table_Benh = DataProvider.LoadCSDL("select * from tbl_ChuanDoan");
            table_HoaDon = DataProvider.LoadCSDL("select * from tbl_HoaDon");
            table_ThamSo = DataProvider.LoadCSDL("select * from tbl_ThamSo");

            cbxPhieuKham.DataSource = table_PhieuKham;
            cbxPhieuKham.DisplayMember = "MaPhieuKham";
            cbxPhieuKham.Enabled = true;

            row_ThamSo = table_ThamSo.Rows[0];
            txtTienKham.Text = row_ThamSo["TienKham"].ToString();

            tienkham = Convert.ToInt32(txtTienKham.Text);
            mahoadon = DataProvider.Auto_Create_MaHD();
            Tao_DGV();
            HienThi();
        }
        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {

            DataColumn _mahoadon = new DataColumn("MaHoaDon");
            DataColumn _maphieukham = new DataColumn("MaPhieuKham");
            DataColumn _mabenhnhan = new DataColumn("MaBenhNhan");
            DataColumn _tienkham = new DataColumn("Tienkham");
            DataColumn _tienthuoc = new DataColumn("Tienthuoc");
            DataColumn _ngaykham = new DataColumn("Ngaykham");

            table_ChiTiet.Columns.Add(_mahoadon);
            table_ChiTiet.Columns.Add(_maphieukham);
            table_ChiTiet.Columns.Add(_mabenhnhan);
            table_ChiTiet.Columns.Add(_ngaykham);
            table_ChiTiet.Columns.Add(_tienkham);
            table_ChiTiet.Columns.Add(_tienthuoc);
            /*  SELECT tbl_Thuoc.Tenthuoc,Tbl_DonVi.Tendonvi, Tbl_CachDung.Tencachdung, Tbl_ToaThuoc.Soluong
                FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc
                INNER JOIN Tbl_CachDung ON Tbl_CachDung.MaCachDung = tbl_ToaThuoc.MaCachDung) INNER Join Tbl_DonVi ON Tbl_DonVi.MaDonVi = Tbl_Thuoc.MaDonVi
                Where tbl_ToaThuoc.MaPhieuKham = 'PK_001'*/


            string sql= "Select tbl_HoaDon.MaHoaDon,tbl_HoaDon.MaPhieuKham,tbl_HoaDon.MaBenhNhan,tbl_HoaDon.Tienkham,tbl_HoaDon.Tienthuoc, tbl_BenhNhan.HotenBN,tbl_BenhNhan.Ngaykham FROM(tbl_HoaDon INNER JOIN tbl_BenhNhan ON tbl_HoaDon.MaBenhNhan = tbl_BenhNhan.MaBenhNhan)";
            table_ChiTiet = DataProvider.LoadCSDL(sql);
            dgvHoaDon.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvHoaDon.DataSource = table_ChiTiet;
            dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns["MaPhieuKham"].HeaderText = "Mã Phiếu Khám";
            dgvHoaDon.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            dgvHoaDon.Columns["HotenBN"].HeaderText = "Họ Tên";
            dgvHoaDon.Columns["NgayKham"].HeaderText = "Ngày Khám";
            dgvHoaDon.Columns["Tienkham"].HeaderText = "Tiền Khám";
            dgvHoaDon.Columns["Tienthuoc"].HeaderText = "Tiền Thuốc";
        }
    }
}
