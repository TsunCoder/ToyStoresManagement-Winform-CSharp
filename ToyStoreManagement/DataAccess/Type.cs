using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Type
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }
        public int IdParent { get; set; }
    }
}
