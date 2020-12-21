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
    public class GrowthRateDao : SingleKeyDao<GrowthRate, int>
    {
        protected override Expression<Func<GrowthRate, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<GrowthRate, bool>> IsKey(int key)
        {
            return x => x.GrowthRateId == key;
        }

       
    }
}
