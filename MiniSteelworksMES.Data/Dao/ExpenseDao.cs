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
    public class ExpenseDao : SingleKeyDao<Expense, int>
    {
        protected override Expression<Func<Expense, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Expense, bool>> IsKey(int key)
        {
            return x => x.ExpenseId == key;
        }

        public List<Expense> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Expenses
                            select x;

                return query.ToList();
            }
        }
    }
}
