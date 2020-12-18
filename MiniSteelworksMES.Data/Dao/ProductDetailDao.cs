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
    public class ProductDetailDao : SingleKeyDao<ProductDetail, int>
    {
        protected override Expression<Func<ProductDetail, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<ProductDetail, bool>> IsKey(int key)
        {
            return x => x.ProductDetailId == key;
        }

        public List<ProductDetail> GetAll()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.ProductDetails
                            select x;

                return query.ToList();
            }
        }
    }
}
