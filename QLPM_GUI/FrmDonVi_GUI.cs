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
    public partial class FrmDonVi_GUI : Form
    {
        DonVi_DTO dv_DTO;
        DonVi_BUS dv_BUS;
        //Những biến dùng chung
        DataTable table_DonVi = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataRow row;
        int index;
        public FrmDonVi_GUI()
        {
            InitializeComponent();
        }

        private void FrmDonVi_GUI_Load(object sender, EventArgs e)
        {
            txtMaDV.Text = DataProvider.Auto_Create_MaDV();
            Tao_DGV();
            HienThi();
            if (table_DonVi.Rows.Count > 0)
            {
                row = table_DonVi.Rows[0];
            }
        }

        private void Tao_DGV()
        {
            DataColumn _tendv = new DataColumn("Tendonvi");
            DataColumn _madonvi = new DataColumn("MaDonVi");
            table_ChiTiet.Columns.Add(_madonvi);
            table_ChiTiet.Columns.Add(_tendv);

            table_DonVi = DataProvider.LoadCSDL("Select * from tbl_DonVi");
            table_ChiTiet = table_DonVi;
            dgvDonVi.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvDonVi.DataSource = table_DonVi;
            dgvDonVi.Columns["Tendonvi"].HeaderText = "Tên Đơn Vị";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDonVi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm đơn vị", "Thêm Đơn Vị", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    dv_DTO = new DonVi_DTO();
                    dv_BUS = new DonVi_BUS();


                    dv_DTO.MaDonVi = txtMaDV.Text.Trim();
                    dv_DTO.Tendonvi = txtTenDonVi.Text;

                    dv_BUS.NhapThongTinDonViMoi(dv_DTO);

                    FrmDonVi_GUI FrmDonVi = new FrmDonVi_GUI();
                    Close();
                    FrmDonVi.Show();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa đơn vị", "Xóa Đơn Vị", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                dv_DTO = new DonVi_DTO();
                dv_BUS = new DonVi_BUS();


                dv_DTO.MaDonVi = txtMaDV.Text.Trim();
                dv_BUS.XoaDonVi(dv_DTO);
            }
            FrmDonVi_GUI FrmDonVi = new FrmDonVi_GUI();
            Close();
            FrmDonVi.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenDonVi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn cập nhật đơn vị", "Cập Nhật Đơn Vị", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    dv_DTO = new DonVi_DTO();
                    dv_BUS = new DonVi_BUS();


                    dv_DTO.MaDonVi = txtMaDV.Text.Trim();
                    dv_DTO.Tendonvi = txtTenDonVi.Text;

                    dv_BUS.SuaThongTinDonVi(dv_DTO);

                    FrmDonVi_GUI FrmDonVi = new FrmDonVi_GUI();
                    Close();
                    FrmDonVi.Show();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        //REST FORM
        public void ResetForm()
        {
            txtMaDV.Text = DataProvider.Auto_Create_MaDV();
            txtTenDonVi.Text = " ";
        }

        private void FrmDonVi_GUI_Click(object sender, EventArgs e)
        {

            ResetForm();
            btnThem.Enabled = true;
        }

        private void dgvDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvDonVi.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            txtMaDV.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtTenDonVi.Text = row_bs.Cells[1].FormattedValue.ToString();
        }
    }
}
