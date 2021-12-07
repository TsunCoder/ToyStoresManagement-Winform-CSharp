using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillDetailsBL
    {
        BillDetailsDA bdDA = new BillDetailsDA();

        public List<BillDetails> GetAll()
        {
            return bdDA.GetAll();
        }

        public BillDetails GetByID(int ID)
        {
            List<BillDetails> list = GetAll();
            foreach (var bill in list)
            {
                if (bill.ID == ID)
                {
                    return bill;
                }
            }
            return null;
        }

        public int Insert(BillDetails billDetail)
        {
            return bdDA.Insert_Update_Delete(billDetail, 0);
        }
    }
}
