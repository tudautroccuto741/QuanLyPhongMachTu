using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class ChiTietHoaDon_DTO
    {
        //Biến
        public string MaHoaDon, MaNhanSu, Tongtien, Ngaykham;
        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into tbl_ChiTietHoaDon(MaHoaDon, MaNhanSu,Tongtien,NgayKham)" + "values(@MaHoaDon,@MaNhanSu,@Tongtien,@Ngaykham);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaHoaDon", SqlDbType.NChar).Value = MaHoaDon;
                cmd.Parameters.Add("@MaNhanSu", SqlDbType.NChar).Value = MaNhanSu;
                cmd.Parameters.Add("@Tongtien", SqlDbType.NChar).Value = Tongtien;
                cmd.Parameters.Add("@Ngaykham", SqlDbType.NChar).Value = Ngaykham;
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

            }
        }

        public void Delete()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Delete  from tbl_ChiTietHoaDon where MaHoaDon = '" + MaHoaDon + "'";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;
                int rowCount = cmd.ExecuteNonQuery();

            }
            catch
            {
                int k = 1;
            }
            finally
            {
                DataProvider.connection.Close();
                DataProvider.connection.Dispose();
                DataProvider.connection = null;

            }
        }
    }
}
