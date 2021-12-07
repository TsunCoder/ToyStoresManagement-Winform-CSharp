using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ToyDA
    {
        public List<Toy> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Toy_GetAll;

            // đọc dữ liệu
            SqlDataReader reader = command.ExecuteReader();
            List<Toy> list = new List<Toy>();
            while (reader.Read())
            {
                Toy toy = new Toy();
                toy.Id = Convert.ToInt32(reader["ID"]);
                toy.TenDoChoi = reader["TenSanPham"].ToString();
                toy.ID_Loai = Convert.ToInt32(reader["ID_Loai"]);
                toy.DoTuoi = reader["DoTuoi"].ToString();
                toy.XuatXu = reader["XuatXu"].ToString();
                toy.ThuongHieu = reader["ThuongHieu"].ToString();
                toy.SoLuong = Convert.ToInt32(reader["SoLuongTon"]);
                toy.GiaBan = Convert.ToInt32(reader["GiaBan"]);
                toy.GiaNhap = Convert.ToInt32(reader["GiaNhap"]);
                if(reader["HinhAnh"]is DBNull)
                {
                    toy.HinhAnh = null;
                }
                else
                {
                    toy.HinhAnh = (byte[])reader["HinhAnh"];
                }
                list.Add(toy);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(Toy toy, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DoChoi_InsertUpdateDelete;

            //Thêm tham số
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = toy.Id;
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar, 1000).Value = toy.TenDoChoi;
            command.Parameters.Add("@ID_Loai", SqlDbType.Int).Value = toy.ID_Loai;
            command.Parameters.Add("@DoTuoi", SqlDbType.NVarChar, 100).Value = toy.DoTuoi;
            command.Parameters.Add("@XuatXu", SqlDbType.NVarChar, 1000).Value = toy.XuatXu;
            command.Parameters.Add("@ThuongHieu", SqlDbType.NVarChar, 1000).Value = toy.ThuongHieu;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = toy.SoLuong;
            command.Parameters.Add("@GiaBan", SqlDbType.Int).Value = toy.GiaBan;
            command.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = toy.GiaNhap;
            command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = toy.HinhAnh;
            //cmd.Parameters.Add(new SqlParameter("@DecalLogoFileName", SqlDbType.VarBinary, byteArray.Length)).Value = byteArray;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }

    }
}
