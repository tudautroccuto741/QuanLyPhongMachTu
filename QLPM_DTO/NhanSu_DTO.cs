using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class NhanSu_DTO
    {
        //Bien
        public string gioitinhns;
        public string MaNhanSu, HoTenNhanSu, DiaChiNS, VaiTroNS, NamSinhNS;
        public void Insert()
        {
            DataProvider.connection = new SqlConnection(DataProvider.connection_String);
            DataProvider.connection.Open();
            try
            {
                string sql = "Insert into dbo.tbl_NhanSu(MaNhanSu,HotenNS,GioitinhNS,NamsinhNS,DiachiNS,VaiTroNS)" + "values(@MaNhanSu,@HotenNS,@GioitinhNS,@NamsinhNS,@DiachiNS,@VaiTroNS);";
                SqlCommand cmd = DataProvider.connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@MaNhanSu", SqlDbType.NChar).Value = MaNhanSu;
                cmd.Parameters.Add("@HotenNS", SqlDbType.NChar).Value = HoTenNhanSu;
                cmd.Parameters.Add("@GioitinhNS", SqlDbType.NChar).Value = gioitinhns;
                cmd.Parameters.Add("@NamsinhNS", SqlDbType.NChar).Value = NamSinhNS;
                cmd.Parameters.Add("@DiachiNS", SqlDbType.NChar).Value = DiaChiNS;
                cmd.Parameters.Add("@VaiTroNS", SqlDbType.NChar).Value = VaiTroNS;
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
                string sql = "Delete  from  dbo.tbl_NhanSu where MaNhanSu = '" + MaNhanSu + "'";
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
                string sql = "Update  tbl_NhanSu  set  HotenNS = '" + HoTenNhanSu + "', NamsinhNS = '" + NamSinhNS + "', GioitinhNS = '" + gioitinhns + "', DiachiNS = '" + DiaChiNS + "', VaitroNS ='" + VaiTroNS + "'  where MaNhanSu = '" + MaNhanSu + "'";
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
