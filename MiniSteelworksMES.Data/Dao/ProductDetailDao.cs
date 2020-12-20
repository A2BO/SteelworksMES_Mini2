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
        public List<ProductSalesQuantityModel2> GetModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {
                    List<ProductDetail> productdetails = context.ProductDetails.ToList();

                    var query = from p in context.ProductDetails
                                join s in context.Sales on p.ProductDetailId equals s.ProductDetailId
                                select new { ProductId = p.ProductId, ProductDetailId = p.ProductDetailId, Amount = s.Amount};


                    var query1 = query.GroupBy(x => x.ProductId, x => x.Amount, 
                        (key, info) => new ProductSalesQuantityModel2 { ProductId = key, Amount = info.Sum() });

                    return query1.ToList();
                }
            }

            
        }
        //public class temp
        //{
        //    public int ProductId;
        //    public int Amount;
        //}
    }
}
