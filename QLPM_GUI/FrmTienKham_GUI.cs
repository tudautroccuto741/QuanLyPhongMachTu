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
    public partial class FrmTienKham_GUI : Form
    {
        DataTable table_ThamSo = new DataTable();
        DataTable table_ChiTiet = new DataTable();
        DataTable table_Test = new DataTable();
        DataRow row_TienKham;

        public FrmTienKham_GUI()
        {
            InitializeComponent();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có muốn thêm bệnh nhân", "Thêm Bệnh Nhân", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                DataProvider.connection = new SqlConnection(DataProvider.connection_String);
                DataProvider.connection.Open();
                try
                {
                    string sql = "Update  tbl_ThamSo  set  TienKham = '" + txtGiaTriMoi.Text + "'";
                    SqlCommand cmd = DataProvider.connection.CreateCommand();
                    cmd.CommandText = sql;

                    int rowCount = cmd.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {

                    DataProvider.connection.Close();
                    DataProvider.connection.Dispose();
                    DataProvider.connection = null;
                    FrmTienKham_GUI FrmThamSo = new FrmTienKham_GUI();
                    Close();
                    FrmThamSo.Show();
                }

            }
        }

        private void HienThi()
        {
            table_ThamSo = DataProvider.LoadCSDL("Select * from tbl_ThamSo");
            row_TienKham = table_ThamSo.Rows[0];
            txtGiaTriCu.Text = row_TienKham["TienKham"].ToString();
            txtGiaTriMoi.Text = "";
        }

        private void FrmTienKham_GUI_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
