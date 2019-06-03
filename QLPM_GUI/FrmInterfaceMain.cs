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
    public partial class FrmInterfaceMain : Form
    {
        string _username = "";
        public FrmInterfaceMain()
        {
            InitializeComponent();
        }

        private void FrmInterfaceMain_Load(object sender, EventArgs e)
        {
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
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string vaitro = reader.GetString(0);


                            if (String.Compare(vaitro.Trim(), "...Admin...") == 0)
                            {
                                btnBaoCaoDoanhThu.Enabled = false;
                                btnQuanLyBenhNhan.Enabled = false;
                                btnTaoToaThuoc.Enabled = false;


                            }
                            if (String.Compare(vaitro.Trim(), "...NhanVien...") == 0)
                            {
                                btnQuanLiNhanSu.Enabled = false;
                                btnThayDoiTienKham.Enabled = false;
                                btnTaoToaThuoc.Enabled = false;
                                btnQuanLiThuoc.Enabled = false;
                                btnDonViVaCachDung.Enabled = false;

                            }

                            if (String.Compare(vaitro.Trim(), "...BacSi...") == 0)
                            {
                                btnQuanLyHoaDon.Enabled = false;
                                btnQuanLiNhanSu.Enabled = false;
                                btnQuanLyBenhNhan.Enabled = false;
                                btnThayDoiTienKham.Enabled = false;
                                btnQuanLiThuoc.Enabled = false;
                                btnBaoCaoDoanhThu.Enabled = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Loi");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("saI");
                }
                finally
                {

                   
                    labelUser.Text = _username;
                    DataProvider.connection.Close();
                    DataProvider.connection.Dispose();
                    DataProvider.connection = null;
                }
            }

        }
        


        private void btnQuanLiNhanSu_Click(object sender, EventArgs e)
        {
            FrmNhanSu_GUI FrmNhanSu = new FrmNhanSu_GUI();
            FrmNhanSu.Show();
        }

        private void btnQuanLyBenhNhan_Click(object sender, EventArgs e)
        {
            FrmBenhNhan_GUI FrmBenhNhan = new FrmBenhNhan_GUI();
            FrmBenhNhan.Show();
        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            FrmPhieuKham_GUI FrmPhieuKham = new FrmPhieuKham_GUI();
            FrmPhieuKham.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon_GUI FrmHD = new FrmHoaDon_GUI();
            FrmHD.Show();
        }

        private void btnQuanLiThuoc_Click(object sender, EventArgs e)
        {
            FrmThuoc_GUI FrmThuoc = new FrmThuoc_GUI();
            FrmThuoc.Show();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon_GUI FrmCTHD = new FrmChiTietHoaDon_GUI();
            FrmCTHD.Show();
        }

        private void btnTaoToaThuoc_Click(object sender, EventArgs e)
        {
            FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
            FrmToaThuoc.Show();
        }


        private void pictureBox21_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (blresult == 1)
            {
                Close();

            }
        }
    }
}