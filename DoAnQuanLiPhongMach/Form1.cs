using QLPM_DTO;
using QLPM_GUI;
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

 namespace DoAnQuanLiPhongMach
{
    public partial class Form1 : Form
    {
        public static string username = "";
        public string _LoginUser = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Equals("") || txtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                DataProvider.connection = new SqlConnection(DataProvider.connection_String);
                DataProvider.connection.Open();
                try
                {
                    string sql = "Select _vaitro from dbo._User where MaNhanSu = @MaNhanSu and _matkhau = @_matkhau;";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.connection);
                    cmd.Parameters.Add("@MaNhanSu", SqlDbType.NChar).Value = txtLogin.Text;
                    cmd.Parameters.Add("@_matkhau", SqlDbType.NChar).Value = txtPass.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string vaitro = reader.GetString(0);
                            _LoginUser = txtLogin.Text.Trim();


                            if (String.Compare(vaitro.Trim(), "...Admin...") == 0)
                            {


                              //  FrmThuoc_GUI FrmThuoc = new FrmThuoc_GUI();
                             //   FrmThuoc.Show();
                                FrmHoaDon_GUI FrmHoaDon = new FrmHoaDon_GUI();
                                FrmHoaDon.Show();

                            }
                            if (String.Compare(vaitro.Trim(), "...NhanVien...") == 0)
                            {
                                // FrmBenhNhan_GUI FrmNhanVien = new FrmBenhNhan_GUI();
                                //FrmNhanVien.Show();
                                // FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
                                //  FrmToaThuoc.Show();


                                FrmChiTietHoaDon_GUI FrmChiTietHD = new FrmChiTietHoaDon_GUI();
                                FrmChiTietHD.Show();
                               
                            }

                            if (String.Compare(vaitro.Trim(), "...BacSi...") == 0)
                            {
                                //  FrmBacSi_GUI FrmBacSi = new FrmBacSi_GUI();
                                //  FrmBacSi.Show();
                                //  FrmPhieuKham_GUI FrmPhieuKham = new FrmPhieuKham_GUI();
                                //  FrmPhieuKham.Show();
                                FrmToaThuoc_GUI FrmToaThuoc = new FrmToaThuoc_GUI();
                                FrmToaThuoc.Show();
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
                    MessageBox.Show("Loi Catch");
                }
                finally
                {
                    this.txtLogin.Text = "";
                    this.txtPass.Text = "";
                    DataProvider.connection.Close();
                    DataProvider.connection.Dispose();
                }

            }
        }

  
    }
}
