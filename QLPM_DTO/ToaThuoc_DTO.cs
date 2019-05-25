using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class ToaThuoc_DTO
    {
        //Những biến dùng chung

        //Bien
        public string MaToaThuoc, NgayketoaTT, MaNhanSu, MaPhieuKham, MaBenhNhan, MaBenh, MaCachDung, Soluong,MaThuoc;


        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into dbo.tbl_ToaThuoc(MaToaThuoc,MaNhanSu,MaPhieuKham,MaBenhNhan,MaBenh,MaCachDung,Soluong,MaThuoc)" + "values(@MaToaThuoc,@MaNhanSu,@MaPhieuKham,@MaBenhNhan,@MaBenh,@MaCachDung,@Soluong,@MaThuoc);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaToaThuoc", SqlDbType.NChar).Value = MaToaThuoc;
                
                cmd.Parameters.Add("@MaThuoc", SqlDbType.NChar).Value = MaThuoc;
                cmd.Parameters.Add("@MaNhanSu", SqlDbType.NChar).Value = MaNhanSu;
                cmd.Parameters.Add("@MaPhieuKham", SqlDbType.NChar).Value = MaPhieuKham;
                cmd.Parameters.Add("@MaBenhNhan", SqlDbType.NChar).Value = MaBenhNhan;
                cmd.Parameters.Add("@MaBenh", SqlDbType.NChar).Value = MaBenh;
                cmd.Parameters.Add("@MaCachDung", SqlDbType.NChar).Value = MaCachDung;
                cmd.Parameters.Add("@Soluong", SqlDbType.NChar).Value = Soluong;
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
                string sql = "Delete  from tbl_ToaThuoc where MaPhieuKham = '" + MaPhieuKham + "' and MaThuoc ='"+MaThuoc +"'";
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
                
                string sql = "Update  tbl_ToaThuoc  set  Soluong = '" + Soluong   + "', MaCachDung = '" + MaCachDung + "'  where MaPhieuKham = '" + MaPhieuKham + "' and MaThuoc ='"+MaThuoc+"'";
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
