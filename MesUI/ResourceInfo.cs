using MiniSteelworksMES.Data;
using MiniSteelworksMES.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesUI
{
    public class ResourceInfo
    {
        private static List<Resource> rscList = null;

        public static List<Resource> getInstance()
        {
            if(rscList == null)
                rscList = Dao.Resource.GetResourceInfo();
            return rscList;
        }
    }
}
