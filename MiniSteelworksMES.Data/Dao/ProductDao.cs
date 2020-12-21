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
    public class ProductDao : SingleKeyDao<Product, int>
    {
        protected override Expression<Func<Product, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Product, bool>> IsKey(int key)
        {
            return x => x.ProductId == key;
        }

     
    }
}
