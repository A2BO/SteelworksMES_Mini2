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
                                from s in context.Sales.Where(x => x.Amount == p.ProductId).DefaultIfEmpty()
                                group p by p.ProductId into g

                                select g;

                    // 달성건수 추가
                    List<ProductSalesQuantityModel2> ProductSalesQuantityModels = new List<ProductSalesQuantityModel2>();
                    foreach (var g in query)
                    {
                        ProductSalesQuantityModel2 PSmodel = new ProductSalesQuantityModel2();
                        PSmodel.Type = "판매량";
                        PSmodel.Amount = g.Count();
                        PSmodel.Product = productdetails.Find(p => p.ProductDetailId == g.Key).Name;

                        ProductSalesQuantityModels.Add(PSmodel);
                    }

                    return ProductSalesQuantityModels;
                }
            }
        }
    }
}
