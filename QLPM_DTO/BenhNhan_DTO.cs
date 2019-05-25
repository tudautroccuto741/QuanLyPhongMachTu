using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class BenhNhan_DTO
    {
        //Những biến dùng chung
        public string gioitinhbn;
        public string gioitinhbn1;
        //Bien
        public string MaBenhNhan, HoTenBenhNhan, DiaChi, CMND, NamSinh, NgayKham;


        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into dbo.tbl_BenhNhan(MaBenhNhan,HotenBN,GioitinhBN,NamsinhBN,DiachiBN,Ngaykham,CMND)" + "values(@MaBenhNhan,@HotenBN,@GioitinhBN,@NamsinhBN,@DiachiBN,@Ngaykham,@CMND);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaBenhNhan", SqlDbType.NChar).Value = MaBenhNhan;
                cmd.Parameters.Add("@HotenBN", SqlDbType.NChar).Value = HoTenBenhNhan;
                cmd.Parameters.Add("@GioitinhBN", SqlDbType.NChar).Value = gioitinhbn;
                cmd.Parameters.Add("@NamsinhBN", SqlDbType.NChar).Value = NamSinh;
                cmd.Parameters.Add("@DiachiBN", SqlDbType.NChar).Value = DiaChi;
                cmd.Parameters.Add("@Ngaykham", SqlDbType.NChar).Value = NgayKham;
                cmd.Parameters.Add("@CMND", SqlDbType.NChar).Value = CMND;
                int rowCount = cmd.ExecuteNonQuery();
            }

            catch
            {
                gioitinhbn1 = "123";
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
                string sql = "Delete  from tbl_BenhNhan where MaBenhNhan = '" + MaBenhNhan + "'";
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
                string sql = "Update  tbl_BenhNhan  set  HotenBN = '" + HoTenBenhNhan + "', NamsinhBN = '" + NamSinh + "', GioitinhBN = '" + gioitinhbn + "', DiachiBN = '" + DiaChi + "', NgayKham ='" + NgayKham + "', CMND= '" + CMND + "'  where MaBenhNhan = '" + MaBenhNhan + "'";
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
