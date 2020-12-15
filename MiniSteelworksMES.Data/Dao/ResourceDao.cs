using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class ResourceDao : SingleKeyDao<Resource, int>
    {
        protected override Expression<Func<Resource, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Resource, bool>> IsKey(int key)
        {
            return x => x.ResourceId == key;
        }

        public List<Resource> GetResourceInfo()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Resources
                            select x;

                return query.ToList();
            }
        }

        public List<Resource> GetByPK(string Resource)
        {
            Resource.Trim();

            if (Resource == "")
                return null;

            int id = Convert.ToInt32(Resource);

            using (var context = new MesEntities())
            {
                var query = from x in context.Resources
                            where x.Category == id
                            select x;

                return query.ToList();
            }
        }
    }
}
