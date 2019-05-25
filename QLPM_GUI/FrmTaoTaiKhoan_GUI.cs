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
    public partial class FrmTaoTaiKhoan_GUI : Form
    {
        string _LoginUser = "",MaNhanSu,_matkhau,_vaitro;
        int index;
        DataRow row;
        DataTable table_TaiKhoan = new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        public FrmTaoTaiKhoan_GUI()
        {
            InitializeComponent();
        }



        public void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtTenTK.Text.Trim().Equals("") || txtMatkhau.Text.Trim().Equals("") || txtMatkhauAgain.Text.Trim().Equals(""))
            {
                MessageBox.Show("Loi");

            }
            else
            {
                DataProvider.connection = new SqlConnection(DataProvider.connection_String);
                DataProvider.connection.Open();
                string sql = "Select VaitroNS from tbl_NhanSu where MaNhanSu = '" + txtTenTK.Text + "'";
                table_TaiKhoan = DataProvider.LoadCSDL(sql);
                row = table_TaiKhoan.Rows[0];
                string vaitro = row["VaiTroNS"].ToString();
                try
                {
                    if (String.Compare(txtMatkhau.Text, txtMatkhauAgain.Text) == 0)
                    {
                     
                        _LoginUser = txtTenTK.Text.Trim();
                        MaNhanSu = txtTenTK.Text;
                        _matkhau = txtMatkhau.Text; 
                        _vaitro = vaitro;
               //         string sql1 = "Insert into dbo._User(MaNhanSu, _matkhau,_vaitro)" + " values('"+MaNhanSu+"','"+_matkhau+"','"+_vaitro+"')";
                     //   SqlCommand cmd = DataProvider.connection.CreateCommand();
                      //  cmd.CommandText = sql1;
                     //   int rowCount = cmd.ExecuteNonQuery();
                            string sql1 = "Insert into dbo._User(MaNhanSu, _matkhau,_vaitro)" + " values(@MaNhanSu,@_matkhau,@_vaitro);";
                         SqlCommand cmd = DataProvider.connection.CreateCommand();

                             cmd.CommandText = sql1;
                            cmd.Parameters.Add("@MaNhanSu", SqlDbType.NChar).Value = txtTenTK.Text.Trim();
                            cmd.Parameters.Add("@_matkhau", SqlDbType.NChar).Value = txtMatkhau.Text;
                            cmd.Parameters.Add("@_vaitro", SqlDbType.NChar).Value = vaitro;
                             int rowCount = cmd.ExecuteNonQuery();
                        MessageBox.Show("Thành công");
                    }

                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }       
                }
                catch
                {
                    MessageBox.Show("Loi Catch");
                }
                finally
                {

                    
                    this.txtTenTK.Text = "";
                    this.txtMatkhau.Text = "";
                    this.txtMatkhauAgain.Text = "";
                    DataProvider.connection.Close();
                    DataProvider.connection.Dispose();
                }

            }
        }
    }
}
