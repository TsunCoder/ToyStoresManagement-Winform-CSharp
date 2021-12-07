using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TypeDA
    {
        public List<TypeToy> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Type_GetAll;

            // đọc dữ liệu
            SqlDataReader reader = command.ExecuteReader();
            List<TypeToy> list = new List<TypeToy>();
            while (reader.Read())
            {
                TypeToy type = new TypeToy();
                type.Id = Convert.ToInt32(reader["ID"]);
                type.TenLoai = reader["TenLoai"].ToString();
                type.GhiChu = reader["MoTa"].ToString();
                type.IdParent = Convert.ToInt32(reader["ID_Cha"].ToString()=="NULL"?"": reader["ID_Cha"].ToString());
               
                list.Add(type);
            }
            sqlConn.Close();
            return list;
        }
    }
}
