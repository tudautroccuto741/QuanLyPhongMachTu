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
    public partial class FrmPhieuKham_GUI : Form
    {
        PhieuKham_DTO pk_DTO;
        PhieuKham_BUS pk_BUS;
        //Những biến dùng chung
        DataTable table_PhieuKham = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_BenhNhan = new DataTable();
        DataTable table_NhanVien = new DataTable();
        DataTable table_NgayKham = new DataTable();
        DataRow row;
        DataRow row_benhnhan;
        string mabn;
     //   DataRow row_nhanvien;
       // DataRow row_ngaykham;
        int index;

        public FrmPhieuKham_GUI()
        {
            InitializeComponent();
        }

        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {
            DataColumn _tenbn = new DataColumn("HotenBN");
       
            DataColumn _maphieukham = new DataColumn("MaPhieuKham");
            DataColumn _trieuchung = new DataColumn("TrieuchungPK");
            DataColumn _mabenhnhan = new DataColumn("MaBenhNhan");
            table_ChiTiet.Columns.Add(_maphieukham);
            table_ChiTiet.Columns.Add(_trieuchung);
            table_ChiTiet.Columns.Add(_mabenhnhan);
          
            table_PhieuKham = DataProvider.LoadCSDL("Select * from tbl_PhieuKham");
            table_ChiTiet = table_PhieuKham;
            dgvPK.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvPK.DataSource = table_ChiTiet;
            dgvPK.Columns["MaPhieuKham"].HeaderText = "Mã Phiếu Khám";
            dgvPK.Columns["Trieuchung"].HeaderText = "Triệu Chứng";     
            dgvPK.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
          //  dgvPK.Columns["HoTenBN"].HeaderText = "Tên Bệnh Nhân";
            dgvPK.Columns["NgayKham"].HeaderText = "Ngày Khám";
        }

      
        //Reset Form
        public void ResetForm()
        {
            txtMaPhieuKham.Text = DataProvider.Auto_Create_MaPK();
            cbxMaBenhNhan.Text = " ";
        }


        private void FrmPhieuKham_GUI_Load(object sender, EventArgs e)
        {
            txtMaPhieuKham.Text = DataProvider.Auto_Create_MaPK();
            table_PhieuKham = DataProvider.LoadCSDL("select * from tbl_PhieuKham");
            table_BenhNhan = DataProvider.LoadCSDL("select * from tbl_BenhNhan");
        //      table_NgayKham = DataProvider.LoadCSDL("SELECT tbl_BenhNhan.Ngaykham FROM(tbl_PhieuKham INNER JOIN tbl_BenhNhan ON tbl_PhieuKham.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) WHERE(((Tbl_PhieuKham.MaBenhNhan) = '"+cbxMaBenhNhan.Text+"'))");
            table_NgayKham = DataProvider.LoadCSDL("select Ngaykham from tbl_BenhNhan where MaBenhNhan ='" + mabn + "'");
            cbxMaBenhNhan.DataSource = table_BenhNhan;
            cbxMaBenhNhan.DisplayMember = "HotenBN";
            cbxMaBenhNhan.Enabled = true;

            Tao_DGV();
            HienThi();
            if (table_PhieuKham.Rows.Count > 0)
            {
                row = table_PhieuKham.Rows[0];
            }

        
         }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa phiếu khám", "Xóa Phiếu Khám", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                pk_DTO = new PhieuKham_DTO();
                pk_BUS = new PhieuKham_BUS();

                pk_DTO.MaPhieuKham = txtMaPhieuKham.Text.Trim();
                pk_BUS.XoaPhieuKham(pk_DTO);
            }

            FrmPhieuKham_GUI FrmPhieuKham = new FrmPhieuKham_GUI();
            Close();
            FrmPhieuKham.Show();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTrieuChung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn cập nhật phiếu khám", "Cập Nhật Phiếu Khám", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    pk_DTO = new PhieuKham_DTO();
                    pk_BUS = new PhieuKham_BUS();


                    pk_DTO.MaPhieuKham = txtMaPhieuKham.Text.Trim();
                    pk_DTO.TrieuChung = txtTrieuChung.Text.Trim();
                    pk_DTO.MaBenhNhan = mabn;
          

                    pk_BUS.SuaThongTinPhieuKham(pk_DTO);

                    FrmPhieuKham_GUI FrmPhieuKham = new FrmPhieuKham_GUI();
                    Close();
                    FrmPhieuKham.Show();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmPhieuKham_GUI_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnThem.Enabled = true;
        }

        private void dgvPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvPK.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;

            txtMaPhieuKham.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtTrieuChung.Text = row_bs.Cells[1].FormattedValue.ToString();
            cbxMaBenhNhan.Text = row_bs.Cells[2].FormattedValue.ToString();
            table_BenhNhan = DataProvider.LoadCSDL("SELECT tbl_PhieuKham.MaPhieuKham, tbl_PhieuKham.TrieuChung, tbl_BenhNhan.MaBenhNhan, tbl_BenhNhan.HotenBN, tbl_BenhNhan.NgayKham FROM(tbl_PhieuKham INNER JOIN tbl_BenhNhan ON tbl_PhieuKham.MaBenhNhan = tbl_BenhNhan.MaBenhNhan) WHERE (Tbl_PhieuKham.MaBenhNhan) = '" + mabn + "'");

        }

        private void cbxMaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbxMaBenhNhan.SelectedIndex;
            row_benhnhan = table_BenhNhan.Rows[index];

            mabn = row_benhnhan["MaBenhNhan"].ToString();
            txtNgayKham.Text = row_benhnhan["Ngaykham"].ToString();
         //   txtTenBenhNhan.Text = row_benhnhan["HotenBN"].ToString();
            txtGioiTinh.Text = row_benhnhan["GioitinhBN"].ToString();
            txtTuoi.Text =  row_benhnhan["NamsinhBN"].ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtTrieuChung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm phiếu khám", "Thêm Phiếu Khám", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    pk_DTO = new PhieuKham_DTO();
                    pk_BUS = new PhieuKham_BUS();


                    pk_DTO.MaPhieuKham = txtMaPhieuKham.Text.Trim();
                    pk_DTO.TrieuChung = txtTrieuChung.Text.Trim();
                    pk_DTO.MaBenhNhan = mabn;
                    pk_DTO.NgayKham = txtNgayKham.Text;

                    pk_BUS.NhapThongTinPhieuKhamMoi(pk_DTO);

                    FrmPhieuKham_GUI FrmPhieuKham = new FrmPhieuKham_GUI();
                    Close();
                    FrmPhieuKham.Show();
                }
            }
        }

        private void txtMaPhieuKham_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
