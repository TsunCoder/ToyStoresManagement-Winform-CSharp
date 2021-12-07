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
        public string HinhAnh { get; set; }
       
        public Toy()
        {

        }

        public Toy(int iD, string tendochoi, int iD_Loai, string dotuoi, string xuatxu, string thuonghieu, int soluong, int giaban, int gianhap, string hinhAnh)
        {
            Id = iD;
            TenDoChoi = tendochoi;
            ID_Loai = iD_Loai;
            DoTuoi = dotuoi;
            XuatXu = xuatxu;
            ThuongHieu = thuonghieu;
            SoLuong = soluong;
            GiaBan = giaban;
            GiaNhap = gianhap;
            HinhAnh = hinhAnh;
        }

    }
}
