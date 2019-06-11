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
    public partial class FrmChiTietHoaDon_GUI : Form
    {
        //Những biến dùng chung
        DataTable table_PhieuKham = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_BenhNhan = new DataTable();
        DataTable table_NhanSu = new DataTable();
        DataTable table_Thuoc = new DataTable();
        DataTable table_CachDung = new DataTable();
        DataTable table_Important = new DataTable();
        DataTable table_TienThuoc = new DataTable();
        DataTable table_DataGridView = new DataTable();
        DataTable table_HoaDon = new DataTable();
        DataTable table_Benh = new DataTable();


        DataRow row, row_phieukham, row_LoginUser, row_ThamSo, row_tienthuoc;
        DataRow row_benhnhan, row_thuoc, row_donvi, row_cachdung, row_benh, row_important;

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        public string _username = "";

        int indexbn;
        string mabenhnhan,maphieukham,strtienkham,strtienthuoc,strtongtien;
        int tienkham, tienthuoc, tongtien;
        public FrmChiTietHoaDon_GUI()
        {
            InitializeComponent();
        }

        private void FrmChiTietHoaDon_GUI_Load(object sender, EventArgs e)
        {
            table_Thuoc = DataProvider.LoadCSDL("select * from tbl_Thuoc");
            table_HoaDon = DataProvider.LoadCSDL("SELECT tbl_BenhNhan.MaBenhNhan, tbl_BenhNhan.HotenBN, tbl_BenhNhan.GioitinhBN, tbl_BenhNhan.NamsinhBN, tbl_BenhNhan.DiachiBN, tbl_HoaDon.MaPhieuKham FROM(tbl_HoaDon INNER JOIN tbl_BenhNhan ON tbl_HoaDon.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) ");
            table_BenhNhan = DataProvider.LoadCSDL("select * from tbl_BenhNhan");
            //    table_PhieuKham = DataProvider.LoadCSDL("select * from tbl_H");
            cbxBenhNhan.DataSource = table_HoaDon;
            cbxBenhNhan.DisplayMember = "HotenBN";
            cbxBenhNhan.Enabled = true;
            foreach (KeyValuePair<string, User> entry in FrmLogin_GUI.user)
            {
                if (!FrmLogin_GUI.user.ContainsKey(FrmLogin_GUI.username)) { return; }
                _username = entry.Key;

                DataProvider.connection = new SqlConnection(DataProvider.connection_String);
                DataProvider.connection.Open();
                try
                {
                    string sql = "Select _vaitro from dbo._User where MaNhanSu = '" + _username + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.connection);


                }
                catch
                {
                    MessageBox.Show("saI");
                }
                finally
                {

                
                    txtNhanSu.Text = _username;
                    DataProvider.connection.Close();
                    DataProvider.connection.Dispose();
                    DataProvider.connection = null;
                }
            }
        }

        private void cbxBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexbn = cbxBenhNhan.SelectedIndex;
            row_benhnhan = table_HoaDon.Rows[indexbn];
            mabenhnhan = row_benhnhan["MaBenhNhan"].ToString();

            table_Important = DataProvider.LoadCSDL("SELECT tbl_BenhNhan.MaBenhNhan, tbl_BenhNhan.HotenBN, tbl_BenhNhan.GioitinhBN, tbl_BenhNhan.NamsinhBN, tbl_BenhNhan.DiachiBN, tbl_BenhNhan.NgayKham,tbl_HoaDon.MaPhieuKham, tbl_HoaDon.Tienkham FROM(tbl_HoaDon INNER JOIN tbl_BenhNhan ON tbl_HoaDon.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) WHERE (tbl_HoaDon.MaBenhNhan) = '" + mabenhnhan + "'");
            row_important = table_Important.Rows[0];

            txtMaBenhNhan.Text = mabenhnhan;
            maphieukham = row_important["MaPhieuKham"].ToString();
            txtMaPhieuKham.Text = maphieukham;
            txtNgayKham.Text = row_important["NgayKham"].ToString();
            txtDiaChi.Text = row_important["DiachiBN"].ToString();
            txtGioiTinh.Text = row_important["GioitinhBN"].ToString();
            txtNamSinh.Text = row_important["NamsinhBN"].ToString();

            //Tiền khám
            strtienkham = row_important["Tienkham"].ToString();
            tienkham = Convert.ToInt32(strtienkham);


            table_Benh = DataProvider.LoadCSDL("SELECT tbl_ChuanDoan.Tenbenh  FROM(tbl_ChuanDoan INNER JOIN tbl_ToaThuoc ON tbl_ChuanDoan.MaBenh = tbl_ToaThuoc.MaBenh) where tbl_ToaThuoc.MaPhieuKham ='" + maphieukham + "'");
            row_benh = table_Benh.Rows[0];
            txtBenh.Text = row_benh["Tenbenh"].ToString();


            //Tiền thuốc
            string sql = "	SELECT SUM(tbl_Thuoc.Gia) AS 'Gia' FROM(tbl_Thuoc INNER JOIN Tbl_ToaThuoc ON tbl_Thuoc.MaThuoc = tbl_ToaThuoc.MaThuoc)WHERE Tbl_ToaThuoc.MaPhieuKham = '" + maphieukham + "' ";
            table_TienThuoc = DataProvider.LoadCSDL(sql);
            row_tienthuoc = table_TienThuoc.Rows[0];            
            strtienthuoc = row_tienthuoc["Gia"].ToString();
            tienthuoc = Convert.ToInt32(strtienthuoc);

            //Tổng tiền
            tongtien = tienthuoc + tienkham;
            txtTongTien.Text = tongtien.ToString();

        }

    }
}
