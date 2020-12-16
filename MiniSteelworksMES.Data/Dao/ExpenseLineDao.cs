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
    public class ExpenseLineDao : SingleKeyDao<ExpenseLine, int>
    {
        protected override Expression<Func<ExpenseLine, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<ExpenseLine, bool>> IsKey(int key)
        {
            return x => x.ExpenseLineId == key;
        }

        public List<ExpenseLine> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.ExpenseLines
                            select x;

                return query.ToList();
            }
        }
    }
}
