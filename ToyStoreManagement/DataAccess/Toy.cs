using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Toy
    {
        public int Id { get; set; }
        public string TenDoChoi { get; set; }
        public int ID_Loai { get; set; }
        public string DoTuoi { get; set; }
        public string XuatXu { get; set; }
        public string ThuongHieu { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
        public int GiaNhap { get; set; }
        public byte[] HinhAnh { get; set; }

    }
}
