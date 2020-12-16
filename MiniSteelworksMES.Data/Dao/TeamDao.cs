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
    public class TeamDao : SingleKeyDao<Team, int>
    {
        protected override Expression<Func<Team, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Team, bool>> IsKey(int key)
        {
            return x => x.TeamId == key;
        }

        public List<Team> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Teams
                            select x;

                return query.ToList();
            }
        }
    }
}
