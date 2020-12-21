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
    public class ResourceWareHouseDao : SingleKeyDao<ResourceWareHouse, int>
    {
        protected override Expression<Func<ResourceWareHouse, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<ResourceWareHouse, bool>> IsKey(int key)
        {
            return x => x.ResourceWareHouseId == key;
        }

      



        public void UpdateWareHouse(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);

            using (var context = DbContextCreator.Create())
            {
                var result = context.ResourceWareHouses.SingleOrDefault(x => x.ResourceWareHouseId == id);

                if (result != null)
                {
                    result.ResourceWareHouseId = id;
                    result.AreaSize = Convert.ToInt32(list[1]);
                    result.EmployeeId = Convert.ToInt32(list[2]);
                    result.PhoneNumber = list[3];
                }

                context.SaveChanges();
            }


        }

        public void InsertWareHouse(string[] strArray)
        {
            using (var context = DbContextCreator.Create())
            {
                var WareHouses = context.Set<ResourceWareHouse>();
                WareHouses.Add(new ResourceWareHouse
                {
                    ResourceWareHouseId = Convert.ToInt32(strArray[0]),
                    AreaSize = Convert.ToInt32(strArray[1]),
                    EmployeeId = Convert.ToInt32(strArray[2]),
                    PhoneNumber = strArray[3],
                });


                context.SaveChanges();
            }
        }

        public void Delete(string strWareHouseId)
        {
            using (var context = DbContextCreator.Create())
            {
                ResourceWareHouse wareHouse = context.ResourceWareHouses.Find(Convert.ToInt32(strWareHouseId));
                context.ResourceWareHouses.Remove(wareHouse);
                context.SaveChanges();
            }

        }
    } 
}

