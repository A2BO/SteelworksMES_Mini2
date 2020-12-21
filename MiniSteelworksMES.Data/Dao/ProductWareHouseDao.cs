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
    public class ProductWareHouseDao : SingleKeyDao<ProductWareHouse, int>
    {
        protected override Expression<Func<ProductWareHouse, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<ProductWareHouse, bool>> IsKey(int key)
        {
            return x => x.ProductWareHouseId == key;
        }

      



        public void UpdateWareHouse(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);

            using (var context = DbContextCreator.Create())
            {
                var result = context.ProductWareHouses.SingleOrDefault(x => x.ProductWareHouseId == id);

                if (result != null)
                {
                    result.ProductWareHouseId = id;
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
                var WareHouses = context.Set<ProductWareHouse>();
                WareHouses.Add(new ProductWareHouse
                {
                    ProductWareHouseId = Convert.ToInt32(strArray[0]),
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
                ProductWareHouse wareHouse = context.ProductWareHouses.Find(Convert.ToInt32(strWareHouseId));
                context.ProductWareHouses.Remove(wareHouse);
                context.SaveChanges();
            }

        }
    }
}

