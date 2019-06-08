using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class HoaDon_DTO
    {
            //Biến
            public string MaHoaDon, MaPhieuKham, MaBenhNhan, MaBenh, Tienkham,Tienthuoc, NgayKham;
        string k;
            public void Insert()
            {
                DataProvider.connection = new SqlConnection(DataProvider.connection_String);
                DataProvider.connection.Open();
                try
                {
                    string sql = "Insert into tbl_HoaDon(MaHoaDon, MaPhieuKham,MaBenhNhan,Tienkham, Tienthuoc,NgayKham)" + "values(@MaHoaDon,@MaPhieuKham,@MaBenhNhan,@Tienkham,@Tienthuoc,@NgayKham);";
                    SqlCommand cmd = DataProvider.connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@MaHoaDon", SqlDbType.NChar).Value = MaHoaDon;
                    cmd.Parameters.Add("@MaPhieuKham", SqlDbType.NChar).Value = MaPhieuKham;                  
                    cmd.Parameters.Add("@MaBenhNhan", SqlDbType.NChar).Value = MaBenhNhan;
                    cmd.Parameters.Add("@Tienkham", SqlDbType.NChar).Value = Tienkham;
                    cmd.Parameters.Add("@Tienthuoc", SqlDbType.NChar).Value = Tienthuoc;
                    cmd.Parameters.Add("@NgayKham", SqlDbType.NChar).Value = NgayKham;
                    int rowCount = cmd.ExecuteNonQuery();
                }

                catch
                {
                k = "123";
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
                    string sql = "Delete  from tbl_HoaDon where MaHoaDon = '" + MaHoaDon + "'";
                    SqlCommand cmd = DataProvider.connection.CreateCommand();
                    cmd.CommandText = sql;
                    int rowCount = cmd.ExecuteNonQuery();

                }
                catch
                {
                string k = "123";
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
           //     string sql = "Update  tbl_PhieuKham  set TrieuChung ='" + TrieuChung + "', MaBenhNhan ='" + MaBenhNhan + "'  where MaPhieuKham = '" + MaPhieuKham + "'";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
               // cmd.CommandText = sql;
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
