using MiniSteelworksMES.Data.Dao;
using MiniSteelworksMES.Data;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class SaleDao : SingleKeyDao<Sale, int>
    {
        protected override Expression<Func<Sale, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Sale, bool>> IsKey(int key)
        {
            return x => x.SaleId == key;
        }

        public List<Sale> GetAll()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Sales
                            select x;

                return query.ToList();
            }
        }




        //public List<Sale> Search()
        //{
        //    using (MesEntities context = new MesEntities())
        //    {
        //        Dictionary<int, string> ProductCeategories = context.Products.ToDictionary(
        //            x => x.ProductId,
        //            x => x.Name);

        //        var query = from x in context.Sales
        //                    select x;

        //        var list = query.ToList();
        //        foreach (var x in list)
        //        {
        //            x.ProductCategory = ProductCeategories[x.ProductId];
        //        }

        //        return list;
        //    }
        //}
    }
}
