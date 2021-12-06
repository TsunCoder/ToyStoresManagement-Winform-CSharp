using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ToyBL
    {
        ToyDA toyDA = new ToyDA();

        public List<Toy> GetAll()
        {
            return toyDA.GetAlls();
        }
    }
}
