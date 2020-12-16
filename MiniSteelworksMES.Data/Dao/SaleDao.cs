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
    public class SaleDao : SingleKeyDao<Sale, int>
    {
        protected override Expression<Func<Sale, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Sale, bool>> IsKey(int key)
        {
            return x => x.SaleId == key;
        }

        public List<Sale> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Sales
                            select x;

                return query.ToList();
            }
        }
    }
}
