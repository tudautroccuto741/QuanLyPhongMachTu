using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class PhieuKham_DTO
    {
        //Biến
        public string MaPhieuKham, TrieuChung, MaNhanVien, MaBenhNhan,NgayKham;
        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into dbo.tbl_PhieuKham(MaPhieuKham, Trieuchung,MaBenhNhan,Ngaykham)" + "values(@MaPhieuKham,@Trieuchung,@MaBenhNhan,@Ngaykham);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaPhieuKham", SqlDbType.NChar).Value = MaPhieuKham;
                cmd.Parameters.Add("@Trieuchung", SqlDbType.NChar).Value = TrieuChung;
                cmd.Parameters.Add("@MaBenhNhan", SqlDbType.NChar).Value = MaBenhNhan;
                cmd.Parameters.Add("@Ngaykham", SqlDbType.NChar).Value = NgayKham;
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
                string sql = "Delete  from tbl_PhieuKham where MaPhieuKham = '" + MaPhieuKham + "'";
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

            }
        }

        public void Update()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Update  tbl_PhieuKham  set TrieuChung ='" + TrieuChung + "', MaBenhNhan ='" + MaBenhNhan + "'  where MaPhieuKham = '" + MaPhieuKham + "'";
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

            }
        }
    }
}
