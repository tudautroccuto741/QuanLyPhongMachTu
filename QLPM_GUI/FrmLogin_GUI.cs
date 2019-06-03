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
    public partial class FrmLogin_GUI : Form
    {
        public static string username = "";
        public string _LoginUser = "";
        public static Dictionary<string, User> user = null;
        //public static Dictionary<string, User> user = null;
   
        public static string login = "";

        public FrmLogin_GUI()
        {
            InitializeComponent();
            user = new Dictionary<string, User>();
        }

    

        private void FrmLogin_GUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                            FrmLogin_GUI.username = _LoginUser;
                            FrmLogin_GUI.user.ContainsKey(_LoginUser); //Kiểm tra  _user có trong Dictionary hay không
                            User khachhang = new User();
                            FrmLogin_GUI.user.Add(FrmLogin_GUI.username, khachhang);



                            if (String.Compare(vaitro.Trim(), "...Admin...") == 0)
                            {
                                FrmInterfaceMain FrmMain = new FrmInterfaceMain();
                                FrmMain.Show();


                            }
                            if (String.Compare(vaitro.Trim(), "...NhanVien...") == 0)
                            {
                                FrmInterfaceMain FrmMain = new FrmInterfaceMain();
                                FrmMain.Show();

                            }

                            if (String.Compare(vaitro.Trim(), "...BacSi...") == 0)
                            {
                                FrmInterfaceMain FrmMain = new FrmInterfaceMain();
                                FrmMain.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng hoặc tài khoản không đúng");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Loi Catch");
                }
                finally
                {
                    //DataProvider.connection.Close();
                    //   DataProvider.connection.Dispose();
                    Close();

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }
    }
}
