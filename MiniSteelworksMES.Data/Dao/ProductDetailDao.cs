using MiniSteelworksMES.Data.Dao;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MiniSteelworksMES.Data.Dao
{
    public class ProductDetailDao : SingleKeyDao<ProductDetail, int>
    {
        protected override Expression<Func<ProductDetail, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<ProductDetail, bool>> IsKey(int key)
        {
            return x => x.ProductDetailId == key;
        }

       
        public List<ProductSalesQuantityModel2> GetModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {
                    var productNames = context.Products.ToDictionary(x => x.ProductId, x => x.Name);

                    var query = from p in context.ProductDetails
                                select new { Amounts = p.Sales.Sum(s => s.Amount),  ProductId = p.ProductId};

                    var query2 = from x in query
                                 group x by x.ProductId into g
                                 select g;

                    var models = new List<ProductSalesQuantityModel2>();
                    foreach(var group in query2)
                    {
                        ProductSalesQuantityModel2 model = new ProductSalesQuantityModel2();
                        model.ProductId = group.Key;
                        model.Amount = group.Sum(g => g.Amounts);
                        model.ProductName = productNames[group.Key];

                        models.Add(model);
                    }

                    return models;
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
