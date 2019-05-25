using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class DataProvider
    {
        // Connection String thiết lập các thông số để kết nối.
        public static string connection_String = @"Data Source=DESKTOP-I4MDHTB;Initial Catalog=DoAnQLPM;Integrated Security=True";

        // Tạo kết nối
        public static SqlConnection connection = new SqlConnection(connection_String);

        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable(); //Tạo Một Kho dữ liệu ảo
            connection = new SqlConnection(connection_String);
            SqlCommand cm = new SqlCommand(sql, connection); // Thực hiện câu lệnh truy vấn đến SQL
            SqlDataAdapter da = new SqlDataAdapter(cm); // Lưu dữ liệu lấy được vào đây 
            da.Fill(dt); //Đổ dữ liệu vào kho
            return dt;
        }
        //insert, update, delete
        static public int Change(string sql)
        {
            connection = new SqlConnection(connection_String);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cm = new SqlCommand(sql, connection);
            int kq = cm.ExecuteNonQuery();
            connection.Close();
            return kq;

        }
        public static DataTable DoccautrucBang(string table_name)
        {
            DataTable result = new DataTable();
            string command_string = "Select * from " + table_name;
            SqlCommand cm = new SqlCommand(command_string, connection);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.FillSchema(result, SchemaType.Source);
            return result;
        }

        //Ghi dữ liệu vào bảng


        //TẠO MÃ TỰ ĐỘNG
        //1.Tạo mã Bệnh Nhân tự động
        public static string Auto_Create_MaBN()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_BenhNhan";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "BN_";
            if (count <= 0)
            {
                result = "BN_001";
            }
            else
            {
                int k;
                result = "BN_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //2.Tạo mã Nhân Sự tự động
        public static string Auto_Create_MaNS()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_NhanSu";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "USER_";
            if (count <= 0)
            {
                result = "USER_001";
            }
            else
            {
                int k;
                result = "USER_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(5, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }
        

        //4.Tạo mã Phiếu Khám tự động
        public static string Auto_Create_MaPK()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_PhieuKham";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "PK_";
            if (count <= 0)
            {
                result = "PK_001";
            }
            else
            {
                int k;
                result = "PK_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //5.Tạo mã Hóa Đơn tự động
        public static string Auto_Create_MaHD()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_HoaDon";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "HD_";
            if (count <= 0)
            {
                result = "HD_001";
            }
            else
            {
                int k;
                result = "HD_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //6.Tạo mã Thuốc tự động
        public static string Auto_Create_MaThuoc()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_Thuoc";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "TH_";
            if (count <= 0)
            {
                result = "TH_001";
            }
            else
            {
                int k;
                result = "TH_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //7.Tạo mã Cách Dùng tự động
        public static string Auto_Create_MaCD()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_CachDung";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "CD_";
            if (count <= 0)
            {
                result = "CD_001";
            }
            else
            {
                int k;
                result = "CD_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //8.Tạo mã Bệnh tự động
        public static string Auto_Create_MaBenh()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_ChuanDoan";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "Benh_";
            if (count <= 0)
            {
                result = "Benh_001";
            }
            else
            {
                int k;
                result = "Benh_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        //9.Tạo mã Đơn Vị tự động
        public static string Auto_Create_MaDV()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_DonVi";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "DV_";
            if (count <= 0)
            {
                result = "DV_001";
            }
            else
            {
                int k;
                result = "DV_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        public static string Auto_Create_MaToaThuoc()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from tbl_ToaThuoc";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "ToaT_";
            if (count <= 0)
            {
                result = "ToaT_001";
            }
            else
            {
                int k;
                result = "ToaT_";
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString().Substring(5, 3));
                k = k + 1;
                if (k < 1000)
                {
                    result = result + "00";
                }
                else if (k < 10000)
                {
                    result = result + "0";
                }
                result = result + k.ToString();
            }
            return result;
        }

        public static string Auto_Create_STTTK()
        {
            string result = "";
            DataTable table = new DataTable();
            string sql = "Select * from _User";
            table = LoadCSDL(sql);
            int count = table.Rows.Count;
            count += 1;
            result = "";
            if (count <= 0)
            {
                result = "1";
            }
            else
            {
                int k;
                k = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0].ToString());
                k = k + 1;
                result = result + k.ToString();
            }
            return result;
        }
    }
}
