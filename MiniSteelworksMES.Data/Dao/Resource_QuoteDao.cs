using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class Resource_QuoteDao : SingleKeyDao<Resource_Quote, DateTime>
    {
        protected override Expression<Func<Resource_Quote, DateTime>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Resource_Quote, bool>> IsKey(DateTime key)
        {
            return x => x.date == key;
        }
        public List<Resource_Quote> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Resource_Quotes
                            select x;

                return query.ToList();
            }
        }
        public List<Resource_Quote> GetByDate(DateTime start, DateTime end)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Resource_Quotes
                            where x.date >= start && x.date <= end
                            select x;

                List<Resource_Quote> list = query.ToList();

                return query.ToList();
            }
        }
    }
}
