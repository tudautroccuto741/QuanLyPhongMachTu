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
    public partial class FrmNhanSu_GUI : Form
    {
        NhanSu_DTO ns_DTO;
        NhanSu_BUS ns_BUS;
        //Những biến dùng chung
        DataTable table_NhanSu = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataRow row;
        int index;
        string gioitinhns;
        string vaitro;
        public FrmNhanSu_GUI()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTenNhanSu.Text.Trim().Equals("") || txtDiaChi.Text.Trim().Equals("") ||  txtNamSinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                int blresult;
                blresult = 0;
                blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm nhân sự", "Thêm Nhân Sự", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
                //MessageBox.Show(blresult.ToString());
                if (blresult == 1)
                {
                    ns_DTO = new NhanSu_DTO();
                    ns_BUS = new NhanSu_BUS();

                    if (RadioButton1.Checked == true)
                    {
                        gioitinhns = "Nam";
                    }
                    else if (RadioButton2.Checked == true)
                    {
                        gioitinhns = "Nữ";
                    }
                    check();

                    ns_DTO.MaNhanSu = txtMaNhanSu.Text.Trim();
                    ns_DTO.HoTenNhanSu = txtHoTenNhanSu.Text;
                    ns_DTO.gioitinhns = gioitinhns;
                    ns_DTO.NamSinhNS = txtNamSinh.Text;
                    ns_DTO.DiaChiNS = txtDiaChi.Text;
                    ns_DTO.VaiTroNS = vaitro;

                    ns_BUS.NhapThongTinNhanSuMoi(ns_DTO);

                    FrmNhanSu_GUI FrmNhanSu = new FrmNhanSu_GUI();
                    Close();
                    FrmNhanSu.Show();
                }
            }
        }

        public void check()
        {
            if (cbxVaiTro.Text == "Bác sĩ")
            {
                vaitro = "...BacSi...";
            }

            else if (cbxVaiTro.Text == "Nhân viên")
            {
                vaitro = "...NhanVien...";
            }
            else if (cbxVaiTro.Text == "Admin")
            {
                vaitro = "...Admin...";
            }
        }

        private void FrmNhanSu_GUI_Load(object sender, EventArgs e)
        {
            txtMaNhanSu.Text = DataProvider.Auto_Create_MaNS();
            Tao_DGV();
            HienThi();
            if (table_NhanSu.Rows.Count > 0)
            {
                row = table_NhanSu.Rows[0];
            }
            RadioButton1.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn xóa nhân sự", "Xóa Nhân Sự", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                ns_DTO = new NhanSu_DTO();
                ns_BUS = new NhanSu_BUS();

                ns_DTO.MaNhanSu = txtMaNhanSu.Text;
                ns_BUS.XoaNhanSu(ns_DTO);
            }
            FrmNhanSu_GUI FrmNhanSu = new FrmNhanSu_GUI();
            Close();
            FrmNhanSu.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTenNhanSu.Text.Trim().Equals("") || txtDiaChi.Text.Trim().Equals("") || txtNamSinh.Text.Trim().Equals(""))
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
                    ns_DTO = new NhanSu_DTO();
                    ns_BUS = new NhanSu_BUS();

                    ns_DTO.MaNhanSu = txtMaNhanSu.Text.Trim();
                    ns_DTO.HoTenNhanSu = txtHoTenNhanSu.Text;
                    ns_DTO.gioitinhns = gioitinhns;
                    ns_DTO.NamSinhNS = txtNamSinh.Text;
                    ns_DTO.DiaChiNS = txtDiaChi.Text;
                    ns_DTO.VaiTroNS = vaitro;

                    ns_BUS.SuaThongTinNhanSu(ns_DTO);

                    FrmNhanSu_GUI FrmNhanSu = new FrmNhanSu_GUI();
                    Close();
                    FrmNhanSu.Show();
                }
            }
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tạo và hiển thị DataGridView DGV
        private void Tao_DGV()
        {
            DataColumn _tenns = new DataColumn("HotenNS");
            DataColumn _namsinhns = new DataColumn("NamsinhNS");
            DataColumn _diachins= new DataColumn("DiachiNS");
            DataColumn _gioitinhns = new DataColumn("GioitinhNS");
            DataColumn _vaitro = new DataColumn("VaitroNS");
            DataColumn _manhansu = new DataColumn("MaNhanSu");
            table_ChiTiet.Columns.Add(_manhansu);
            table_ChiTiet.Columns.Add(_tenns);
            table_ChiTiet.Columns.Add(_namsinhns);
            table_ChiTiet.Columns.Add(_diachins);
            table_ChiTiet.Columns.Add(_gioitinhns);
            table_ChiTiet.Columns.Add(_vaitro);
            table_NhanSu = DataProvider.LoadCSDL("Select * from tbl_NhanSu");
            table_ChiTiet = table_NhanSu;
            dgvDSNS.DataSource = table_ChiTiet;
        }

        private void HienThi()
        {
            dgvDSNS.DataSource = table_NhanSu;
            dgvDSNS.Columns["HotenNS"].HeaderText = "Họ Tên";
            dgvDSNS.Columns["NamsinhNS"].HeaderText = "Năm Sinh";
            dgvDSNS.Columns["DiachiNS"].HeaderText = "Địa Chỉ";
            dgvDSNS.Columns["GioitinhNS"].HeaderText = "Giới Tính";
            dgvDSNS.Columns["VaitroNS"].HeaderText = "Vai Trò";
        }

        private void dgvDSNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row_bs = dgvDSNS.Rows[index];
            //dgvDSBS.CurrentRow.Selected = true;
            btnThem.Enabled = false;
            txtMaNhanSu.Text = row_bs.Cells[0].FormattedValue.ToString();
            txtHoTenNhanSu.Text = row_bs.Cells[1].FormattedValue.ToString();
            gioitinhns = row_bs.Cells[2].FormattedValue.ToString();
            txtNamSinh.Text = row_bs.Cells[3].FormattedValue.ToString();
            txtDiaChi.Text = row_bs.Cells[4].FormattedValue.ToString();
            //txt.Text = row_bs.Cells[5].FormattedValue.ToString();
            vaitro = row_bs.Cells[5].FormattedValue.ToString();
            if (gioitinhns == "Nam")
            {
                RadioButton1.Checked = true;
            }
            else if (gioitinhns == "Nữ")
            {
                RadioButton2.Checked = true;
            }

            if ( vaitro == "...BacSi...")
            {
                cbxVaiTro.Text = "Bác sĩ";
            }

            else if (  vaitro == "...NhanVien...")
            {
                cbxVaiTro.Text = "Nhân viên";
            }
            else if (  vaitro == "...Admin...")
            {
                cbxVaiTro.Text = "Admin";
            }
        }

        //Reset Form
        public void ResetForm()
        {
            txtMaNhanSu.Text = DataProvider.Auto_Create_MaNS();
            txtHoTenNhanSu.Text = " ";
            txtNamSinh.Text = " ";
            txtDiaChi.Text = " ";
        }

        private void FrmNhanSu_GUI_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnThem.Enabled = true;
        }
    }
}
