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
        public List<Toy> GetAlls()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Toy_GetAll;

            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Toy> listToys = new List<Toy>();
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
                toy.HinhAnh = reader["HinhAnh"].ToString();
                listToys.Add(toy);
            }
            sqlConnection.Close();
            return listToys;
        }
    }
}
