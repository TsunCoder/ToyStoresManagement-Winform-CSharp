using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class Ultilities
    {
        
        // Lấy chuỗi kết nối từ App.config
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        // Các biển của bảng Toy
<<<<<<< HEAD
        public static string Toy_GetAll = "Toy_GetAll";
        public static string DoChoi_InsertUpdateDelete = "DoChoi_InsertUpdateDelete";
=======
        public static string Toy_GetAll = "Toy_GetALL";
>>>>>>> 84b3e4a6c807ef13b7a7cdc4f83af91917b03ede
        //
        public static string Type_GetAll = "Type_GetAll";
    }
}
