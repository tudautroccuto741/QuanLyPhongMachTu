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
    public partial class FrmBenhNhan_GUI : Form
    {
        BenhNhan_DTO bn_DTO;
        BenhNhan_BUS bn_BUS;
        //Những biến dùng chung
        DataTable table_BenhNhan = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataRow row;
        int index;
        string gioitinhbn;


        public FrmBenhNhan_GUI()
        {
            InitializeComponent();
        }

      
        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {
            DataColumn _tenbn = new DataColumn("HotenBN");
            DataColumn _namsinhbn = new DataColumn("NamsinhBN");
            DataColumn _diachibn = new DataColumn("DiachiBN");
            DataColumn _gioitinhbn = new DataColumn("GioitinhBN");
            DataColumn _ngaykham = new DataColumn("Ngaykham");
            DataColumn _cmnd = new DataColumn("CMND");
            DataColumn _mabenhnhan = new DataColumn("MaBenhNhan");
            table_ChiTiet.Columns.Add(_mabenhnhan);
            table_ChiTiet.Columns.Add(_tenbn);
            table_ChiTiet.Columns.Add(_namsinhbn);
            table_ChiTiet.Columns.Add(_diachibn);
            table_ChiTiet.Columns.Add(_gioitinhbn);
            table_ChiTiet.Columns.Add(_ngaykham);
            table_ChiTiet.Columns.Add(_cmnd);
            table_BenhNhan = DataProvider.LoadCSDL("Select * from tbl_BenhNhan");
            table_ChiTiet = table_BenhNhan;
            dgvDSBN.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvDSBN.DataSource = table_BenhNhan;
            dgvDSBN.Columns["HotenBN"].HeaderText = "Họ Tên";
            dgvDSBN.Columns["NamsinhBN"].HeaderText = "Năm Sinh";
            dgvDSBN.Columns["DiachiBN"].HeaderText = "Địa Chỉ";
            dgvDSBN.Columns["GioitinhBN"].HeaderText = "Giới Tính";
            dgvDSBN.Columns["Ngaykham"].HeaderText = "Ngày Khám";
            dgvDSBN.Columns["CMND"].HeaderText = "CMND";
        }

        //Reset Form
        public void ResetForm()
        {
            txtMaBenhNhan.Text = DataProvider.Auto_Create_MaBN();
            txtHoTenBenhNhan.Text = " ";
            txtNamSinh.Text = " ";
            txtDiaChi.Text = " ";
            txtCMND.Text = " ";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTenBenhNhan.Text.Trim().Equals("") || txtDiaChi.Text.Trim().Equals("") || txtCMND.Text.Trim().Equals("") || txtNamSinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm bệnh nhân", "Thêm Bệnh Nhân", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    bn_DTO = new BenhNhan_DTO();
                    bn_BUS = new BenhNhan_BUS();
                  
                        if (RadioButton1.Checked == true)
                        {
                            gioitinhbn = "Nam";
                        }
                        else if (RadioButton2.Checked == true)
                        {
                            gioitinhbn = "Nữ";
                        }
                        bn_DTO.MaBenhNhan = txtMaBenhNhan.Text.Trim();
                        bn_DTO.HoTenBenhNhan = txtHoTenBenhNhan.Text.Trim();
                        bn_DTO.gioitinhbn = gioitinhbn;
                        bn_DTO.NamSinh = txtNamSinh.Text.Trim();
                        bn_DTO.DiaChi = txtDiaChi.Text.Trim();
                        bn_DTO.NgayKham = dtpNgayKham.Value.ToString("dd/MM/yyyy");
                        bn_DTO.CMND = txtCMND.Text.Trim();

                        bn_BUS.NhapThongTinBenhNhanMoi(bn_DTO);

                        FrmBenhNhan_GUI FrmBenhNhan = new FrmBenhNhan_GUI();
                        Close();
                        FrmBenhNhan.Show();
                    
                }
            }
        }
     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa benh nhan", "Xóa Benh Nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                bn_DTO = new BenhNhan_DTO();
                bn_BUS = new BenhNhan_BUS();
                bn_DTO.MaBenhNhan = txtMaBenhNhan.Text.Trim();
                bn_BUS.XoaBenhNhan(bn_DTO);
            }
            FrmBenhNhan_GUI FrmBenhNhan = new FrmBenhNhan_GUI();
            Close();
            FrmBenhNhan.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTenBenhNhan.Text.Trim().Equals("") || txtDiaChi.Text.Trim().Equals("") || txtCMND.Text.Trim().Equals("") || txtNamSinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn cập nhật bệnh nhân", "Cập Nhật Bệnh Nhân", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    bn_DTO = new BenhNhan_DTO();
                    bn_BUS = new BenhNhan_BUS();

                    if (RadioButton1.Checked == true)
                    {
                        gioitinhbn = "Nam";
                    }
                    else if (RadioButton2.Checked == true)
                    {
                        gioitinhbn = "Nữ";
                    }
                    bn_DTO.MaBenhNhan = txtMaBenhNhan.Text.Trim();
                    bn_DTO.HoTenBenhNhan = txtHoTenBenhNhan.Text;
                    bn_DTO.gioitinhbn = gioitinhbn;
                    bn_DTO.NamSinh = txtNamSinh.Text;
                    bn_DTO.DiaChi = txtDiaChi.Text;
                    bn_DTO.NgayKham = dtpNgayKham.Value.ToString();
                    bn_DTO.CMND = txtCMND.Text;

                    bn_BUS.SuaThongTinBenhNhan(bn_DTO);

                    FrmBenhNhan_GUI FrmBenhNhan = new FrmBenhNhan_GUI();
                    Close();
                    FrmBenhNhan.Show();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDSBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvDSBN.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            txtMaBenhNhan.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtHoTenBenhNhan.Text = row_bs.Cells[1].FormattedValue.ToString();
            gioitinhbn = row_bs.Cells[2].FormattedValue.ToString();
            txtNamSinh.Text = row_bs.Cells[3].FormattedValue.ToString();
            txtDiaChi.Text = row_bs.Cells[4].FormattedValue.ToString();
            //txt.Text = row_bs.Cells[5].FormattedValue.ToString();
            txtCMND.Text = row_bs.Cells[6].FormattedValue.ToString();
            if (gioitinhbn == "Nam")
            {
                RadioButton1.Checked = true;
            }
            else if (gioitinhbn == "Nữ")
            {
                RadioButton2.Checked = true;
            }
        }

        private void FrmBenhNhan_GUI_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnThem.Enabled = true;
        }

        private void FrmBenhNhan_GUI_Load(object sender, EventArgs e)
        {
            txtMaBenhNhan.Text = DataProvider.Auto_Create_MaBN();
            Tao_DGV();
            HienThi();
            if (table_BenhNhan.Rows.Count > 0)
            {
                row = table_BenhNhan.Rows[0];
            }
        }
    }
}
