﻿using DataAccess;
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
<<<<<<< HEAD
        public List<Toy> GetAll()
        {
            return toyDA.GetAll();
        }
        public Toy GetByID(int ID)
        {
            List<Toy> list = GetAll();
            foreach(var item in list)
            {
                if (item.Id == ID)
                    return item;
            }
            return null; 
        }
        public int Insert(Toy toy)
        {
            return toyDA.Insert_Update_Delete(toy, 0);
        }
        public int Update(Toy toy)
        {
            return toyDA.Insert_Update_Delete(toy, 1);
        }
        public int Delete(Toy toy)
        {
            return toyDA.Insert_Update_Delete(toy, 2);
=======

        public List<Toy> GetAll()
        {
            return toyDA.GetAlls();
>>>>>>> 84b3e4a6c807ef13b7a7cdc4f83af91917b03ede
        }
    }
}
