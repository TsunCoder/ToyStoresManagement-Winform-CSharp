using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDetailsDA
    {
        public List<BillDetails> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.BillDetails_GetAll;

            sqlConnection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<BillDetails> list = new List<BillDetails>();
            while (reader.Read())
            {
                BillDetails billDetails = new BillDetails();
                billDetails.ID = Convert.ToInt32(reader["ID"]);
                billDetails.ID_HoaDon = Convert.ToInt32(reader["ID_HD"]);
                billDetails.ToyID = Convert.ToInt32(reader["ID_DC"]);
                billDetails.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                list.Add(billDetails);
            }
            sqlConnection.Close();
            return list;
        }

        public int Insert_Update_Delete(BillDetails billDetails, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.BillDetails_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = System.Data.ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = billDetails.ID;

            cmd.Parameters.Add("@ID_HD", SqlDbType.Int).Value = billDetails.ID_HoaDon;
            cmd.Parameters.Add("@ToyID", SqlDbType.Int).Value = billDetails.ToyID;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = billDetails.SoLuong;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return (int)cmd.Parameters["@ID"].Value;
            }
            conn.Close();
            return 0;

           
        }
    }
}
