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
    public partial class FrmCachDung_GUI : Form
    {
        CachDung_DTO cd_DTO;
        CachDung_BUS cd_BUS;
        //Những biến dùng chung
        DataTable table_CachDung = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataRow row;
        int index;

        public FrmCachDung_GUI()
        {
            InitializeComponent();
        }

        private void FrmCachDung_GUI_Load(object sender, EventArgs e)
        {
            txtMaCachDungMoi.Text = DataProvider.Auto_Create_MaCD();
            Tao_DGV();
            HienThi();
            if (table_CachDung.Rows.Count > 0)
            {
                row = table_CachDung.Rows[0];
            }
        }


        private void Tao_DGV()
        {
            DataColumn _tencd = new DataColumn("Tencachdung");
            DataColumn _macachdung = new DataColumn("MaCachDung");
            table_ChiTiet.Columns.Add(_macachdung);
            table_ChiTiet.Columns.Add(_tencd);

            table_CachDung = DataProvider.LoadCSDL("Select * from tbl_CachDung");
            table_ChiTiet = table_CachDung;
            dgvCachDung.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvCachDung.DataSource = table_CachDung;
            dgvCachDung.Columns["Tencachdung"].HeaderText = "Tên Cách Dùng";
            dgvCachDung.Columns["Tencachdung"].Width = 220;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenCachDung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm cách dùng", "Thêm Cách Dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    cd_DTO = new CachDung_DTO();
                    cd_BUS = new CachDung_BUS();


                    cd_DTO.MaCachDung = txtMaCachDungMoi.Text.Trim();
                    cd_DTO.Tencachdung = txtTenCachDung.Text;

                    cd_BUS.NhapThongTinCachDungMoi(cd_DTO);

                    FrmCachDung_GUI FrmCachDung = new FrmCachDung_GUI();
                    Close();
                    FrmCachDung.Show();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa cách dùng", "Xóa Cách Dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                cd_DTO = new CachDung_DTO();
                cd_BUS = new CachDung_BUS();


                cd_DTO.MaCachDung = txtMaCachDungMoi.Text.Trim();
                cd_BUS.XoaCachDung(cd_DTO);
            }
            FrmCachDung_GUI FrmCachDung = new FrmCachDung_GUI();
            Close();
            FrmCachDung.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenCachDung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn cập nhật cách dùng", "Cập Nhật Cách Dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    cd_DTO = new CachDung_DTO();
                    cd_BUS = new CachDung_BUS();


                    cd_DTO.MaCachDung = txtMaCachDungMoi.Text.Trim();
                    cd_DTO.Tencachdung = txtTenCachDung.Text;
                    cd_BUS.SuaThongTinCachDung(cd_DTO);
                }
                FrmCachDung_GUI FrmCachDung = new FrmCachDung_GUI();
                Close();
                FrmCachDung.Show();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();

        }

        public void ResetForm()
        {
            txtMaCachDungMoi.Text = DataProvider.Auto_Create_MaCD();
            txtTenCachDung.Text = " ";
        }

        private void FrmCachDung_GUI_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnThem.Enabled = true;
        }

        private void dgvCachDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvCachDung.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            txtMaCachDungMoi.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtTenCachDung.Text = row_bs.Cells[1].FormattedValue.ToString();
        }

        private void dgvCachDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
