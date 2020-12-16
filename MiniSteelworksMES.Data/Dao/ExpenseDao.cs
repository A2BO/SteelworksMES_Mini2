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

        public List<Expense> Search()
        {
            using (MesEntities context = new MesEntities())
            {
                var query = from x in context.Expenses
                            select new
                            {
                                Expense = x,
                                CategoryName = x.ExpenseLine.Name
                            };

                var list = query.ToList();
                foreach(var item in list)
                {
                    item.Expense.CategoryName = item.CategoryName;
                }

                return list.Select(x => x.Expense).ToList();
            }
        }

        //public List<Expense> Search2()
        //{
        //    using (MesEntities context = new MesEntities())
        //    {
        //        var lines = context.ExpenseLines.ToList();

        //        var query = from x in context.Expenses
        //                    select x;

        //        var list = query.ToList();
        //        foreach (var x in list)
        //        {
        //            ExpenseLine line = lines.Find(l => l.ExpenseLineId == x.ExpenseLineId);
        //            x.CategoryName = line.Name;
        //        }

        //        return list;
        //    }
        //}

        //public List<Expense> Search3()
        //{
        //    using (MesEntities context = new MesEntities())
        //    {
        //        Dictionary<int, string> categoryNames = context.ExpenseLines.ToDictionary(
        //            x => x.ExpenseLineId,
        //            x => x.Name);

        //        var query = from x in context.Expenses
        //                    select x;

        //        var list = query.ToList();
        //        foreach (var x in list)
        //        {
        //            x.CategoryName = categoryNames[x.ExpenseLineId];
        //        }

        //        return list;
        //    }
        //}

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
