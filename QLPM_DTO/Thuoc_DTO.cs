using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
   public class Thuoc_DTO
    {
        //Những biến dùng chung

        //Bien
        public string MaThuoc, Tenthuoc, MaDonVi, Soluong, Gia;


        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into dbo.tbl_Thuoc(MaThuoc,Tenthuoc,MaDonVi,Soluong,Gia)" + "values(@MaThuoc,@Tenthuoc,@MaDonVi,@Soluong,@Gia);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaThuoc", SqlDbType.NChar).Value = MaThuoc;
                cmd.Parameters.Add("@Tenthuoc", SqlDbType.NChar).Value = Tenthuoc;
                cmd.Parameters.Add("@MaDonVi", SqlDbType.NChar).Value = MaDonVi;
                cmd.Parameters.Add("@Soluong", SqlDbType.NChar).Value = Soluong;
                cmd.Parameters.Add("@Gia", SqlDbType.NChar).Value = Gia;
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
                string sql = "Delete  from tbl_Thuoc where MaThuoc = '" + MaThuoc + "'";
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
                string sql = "Update  tbl_Thuoc  set  Tenthuoc = '" + Tenthuoc + "', MaDonVi = '" + MaDonVi + "', Gia = '" + Gia + "', Soluong = '" + Soluong + "'  where MaThuoc = '" + MaThuoc + "'";
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
