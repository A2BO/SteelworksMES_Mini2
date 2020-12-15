using MiniSteelworksMES.Data.Dao;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class WareHouseDao : SingleKeyDao<WareHouse, int>
    {
        protected override Expression<Func<WareHouse, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<WareHouse, bool>> IsKey(int key)
        {
            return x => x.WareHouseId == key;
        }

        public List<WareHouse> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.WareHouses
                            select x;

                return query.ToList();
            }
        }



        public void UpdateWareHouse(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);

            using (var context = new MesEntities())
            {
                var result = context.WareHouses.SingleOrDefault(x => x.WareHouseId == id);

                if (result != null)
                {
                    result.WareHouseId = id;
                    result.AreaSize = Convert.ToInt32(list[1]);
                    result.EmployeeId = Convert.ToInt32(list[2]);
                    result.PhoneNumber = list[3];
                }

                context.SaveChanges();
            }


        }

        public void InsertWareHouse(string[] strArray)
        {
            using (var context = new MesEntities())
            {
                var WareHouses = context.Set<WareHouse>();
                WareHouses.Add(new WareHouse
                {
                    WareHouseId = Convert.ToInt32(strArray[0]),
                    AreaSize = Convert.ToInt32(strArray[1]),
                    EmployeeId = Convert.ToInt32(strArray[2]),
                    PhoneNumber = strArray[3],
                });


                context.SaveChanges();
            }
        }

        public void Delete(string strWareHouseId)
        {
            using (var context = new MesEntities())
            {
                WareHouse wareHouse = context.WareHouses.Find(Convert.ToInt32(strWareHouseId));
                context.WareHouses.Remove(wareHouse);
                context.SaveChanges();
            }

        }
    } 
}

