using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TypeBL
    {
        TypeDA typeDA = new TypeDA();
        public List<TypeToy> GetAll()
        {
            return typeDA.GetAll();
        }
     
        public TypeToy GetByID(int ID)
        {
            List<TypeToy> list = GetAll();
            foreach (var item in list)
            {
                if (item.Id == ID)
                    return item;
            }
            return null;
        }
    }
}
