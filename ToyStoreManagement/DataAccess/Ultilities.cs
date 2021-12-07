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
        public static string Toy_GetAll = "Toy_GetAll";
        public static string DoChoi_InsertUpdateDelete = "DoChoi_InsertUpdateDelete";
        public static string BillDetails_InsertUpdateDelete = "BillDetails_InsertUpdateDelete";
        public static string BillDetails_GetAll = "BillDetails_GetAll";
        //
        public static string Type_GetAll = "Type_GetAll";
    }
}
