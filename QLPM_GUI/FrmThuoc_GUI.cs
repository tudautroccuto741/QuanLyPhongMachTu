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
    public partial class FrmThuoc_GUI : Form
    {
        Thuoc_DTO th_DTO;
        Thuoc_BUS th_BUS;
        //Những biến dùng chung
        DataTable table_Thuoc= new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_DonVi = new DataTable();
        DataRow row;
        DataRow row_thuoc;
        int index;
        public FrmThuoc_GUI()
        {
            InitializeComponent();
        }

        private void FrmThuoc_GUI_Load(object sender, EventArgs e)
        {

            txtMaThuoc.Text = DataProvider.Auto_Create_MaThuoc();
            table_Thuoc = DataProvider.LoadCSDL("select * from tbl_Thuoc");
            table_DonVi = DataProvider.LoadCSDL("select * from tbl_DonVi");
            cbxDonVi.DataSource = table_DonVi;
            cbxDonVi.DisplayMember = "Tendonvi";
            cbxDonVi.Enabled = true;

            Tao_DGV();
            HienThi();
            if (table_Thuoc.Rows.Count > 0)
            {
                row = table_Thuoc.Rows[0];
            }

        }
        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {
            DataColumn _tenthuoc = new DataColumn("Tenthuoc");
            DataColumn _soluong = new DataColumn("Soluong");
            DataColumn _mathuoc = new DataColumn("MaThuoc");
            DataColumn _gia = new DataColumn("Gia");
            DataColumn _madonvi = new DataColumn("MaDonVi");
            table_ChiTiet.Columns.Add(_mathuoc);
            table_ChiTiet.Columns.Add(_tenthuoc);
            table_ChiTiet.Columns.Add(_madonvi);
            table_ChiTiet.Columns.Add(_soluong);
            table_ChiTiet.Columns.Add(_gia);
            table_Thuoc = DataProvider.LoadCSDL("Select * from tbl_Thuoc");
            table_ChiTiet = table_Thuoc;
            dgvThuoc.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvThuoc.DataSource = table_Thuoc;
            dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns["Tenthuoc"].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns["MaDonVi"].HeaderText = "Mã Đơn Vị";
            dgvThuoc.Columns["Soluong"].HeaderText = "Số Lượng";
            dgvThuoc.Columns["Gia"].HeaderText = "Giá";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuongTon.Text.Trim().Equals("")|| txtTenThuoc.Text.Trim().Equals("")|| txtDonGiaThuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm thuốc", "Thêm Thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    th_DTO = new Thuoc_DTO();
                    th_BUS = new Thuoc_BUS();


                    th_DTO.MaThuoc = txtMaThuoc.Text.Trim();
                    th_DTO.Tenthuoc = txtTenThuoc.Text.Trim();
                    th_DTO.MaDonVi = cbxDonVi.Text;
                    th_DTO.Soluong = txtSoLuongTon.Text;
                    th_DTO.Gia = txtDonGiaThuoc.Text;
                    th_BUS.NhapThongTinThuocMoi(th_DTO);

                    FrmThuoc_GUI FrmThuoc = new FrmThuoc_GUI();
                    Close();
                    FrmThuoc.Show();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa Thuoc", "Xóa Thuoc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                th_DTO = new Thuoc_DTO();
                th_BUS = new Thuoc_BUS();

                th_DTO.MaThuoc = txtMaThuoc.Text.Trim();
                th_BUS.XoaThuoc(th_DTO);
            }

            FrmThuoc_GUI FrmThuoc = new FrmThuoc_GUI();
            Close();
            FrmThuoc.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSoLuongTon.Text.Trim().Equals("") || txtTenThuoc.Text.Trim().Equals("") || txtDonGiaThuoc.Text.Trim().Equals(""))
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
                    th_DTO = new Thuoc_DTO();
                    th_BUS = new Thuoc_BUS();


                    th_DTO.MaThuoc = txtMaThuoc.Text.Trim();
                    th_DTO.Tenthuoc = txtTenThuoc.Text.Trim();
                    th_DTO.MaDonVi = cbxDonVi.Text;
                    th_DTO.Soluong = txtSoLuongTon.Text;
                    th_DTO.Gia = txtDonGiaThuoc.Text;
                    th_BUS.SuaThongTinThuoc(th_DTO);

                    FrmThuoc_GUI FrmThuoc = new FrmThuoc_GUI();
                    Close();
                    FrmThuoc.Show();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvThuoc.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            txtMaThuoc.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtTenThuoc.Text = row_bs.Cells[1].FormattedValue.ToString();
            cbxDonVi.Text = row_bs.Cells[2].FormattedValue.ToString();
            txtSoLuongTon.Text = row_bs.Cells[3].FormattedValue.ToString();
            txtDonGiaThuoc.Text = row_bs.Cells[3].FormattedValue.ToString();
        }

        //Reset Form
        public void ResetForm()
        {
            txtMaThuoc.Text = DataProvider.Auto_Create_MaThuoc();
            txtTenThuoc.Text = " ";
            txtTenDonVi.Text = " ";
            txtDonGiaThuoc.Text = " ";
            txtSoLuongTon.Text = " ";
        }

        private void FrmThuoc_GUI_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnThem.Enabled = true;
        }
    }
}
