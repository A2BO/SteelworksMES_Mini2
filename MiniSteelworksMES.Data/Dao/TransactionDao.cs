using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class TransactionDao : TripleKeyDao<Transaction, int, DateTime, int>
    {
        private int rowsCountPerPage = 20;
        protected override Expression<Func<Transaction, bool>> IsKey(int key1, DateTime key2, int key3)
        {
            return x => x.ResourceId == key1 && x.Date == key2;
        }

        public List<Transaction> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Transactions
                            select x;

                return query.ToList();
            }
        }

        public List<Transaction> GetAllByPagingQuery(int showPage)
        {
            using (var context = new MesEntities())
            {
                int totalCount = (from x in context.Transactions
                             select x).Count();

                int nPageCount = 0;
                nPageCount = totalCount / rowsCountPerPage;
                if ( totalCount % rowsCountPerPage != 0)
                    nPageCount += 1;

                var query = (from x in context.Transactions
                            select x).OrderBy( x => x.Date).Skip((showPage-1) * rowsCountPerPage).Take(rowsCountPerPage);

                return query.ToList();
            }
        }

        public int GetPageCount(int skipCount)
        {
            using (var context = new MesEntities())
            {
                int totalCount = (from x in context.Transactions
                                  select x).Count();

                int nPageCount = 0;
                nPageCount = totalCount / skipCount;
                if (totalCount % skipCount != 0)
                    nPageCount += 1;

                return nPageCount;
            }
        }

        public List<Transaction> GetByDate(DateTime start, DateTime end)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Transactions
                            where x.Date >= start && x.Date <= end
                            select x;

                return query.ToList();
            }
        }

        public void UpdateTransaction(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);
            DateTime datetime = Convert.ToDateTime(list[2]);
            int type = (list[5] == "출고") ? 0 : 1;

            using (var context = new MesEntities())
            {
                var result = context.Transactions.SingleOrDefault(x => x.ResourceId == id
                   && x.Date == datetime
                   && x.Type == type);

                if (result != null)
                {
                    result.ResourceId = Convert.ToInt32(list[0]);
                    result.SellerName = list[1];
                    result.Date = Convert.ToDateTime(list[2]);
                    result.Origin = list[3];
                    result.EmployeeId = Convert.ToInt32(list[4]);
                    result.Type = (list[5] == "출고") ? 0 : 1;
                    result.WareHouseId = Convert.ToInt32(list[6]);
                }

                context.SaveChanges();
            }
        }

        public List<Transaction> GetByResourceId(int rscId)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Transactions
                            where x.ResourceId == rscId
                            select x;

                List<Transaction> list = query.ToList();

                return query.ToList();
            }
        }

        public List<Transaction> GetByResourceIdAndDate(int rscId, DateTime start, DateTime end)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Transactions
                            where x.Date >= start && x.Date <= end && x.ResourceId == rscId
                            select x;

                List<Transaction> list = query.ToList();

                return query.ToList();
            }
        }
    }
}
