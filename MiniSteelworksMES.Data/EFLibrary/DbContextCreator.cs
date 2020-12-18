using MiniSteelworksMES.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/Mes.csdl|res://*/Mes.ssdl|res://*/Mes.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=MES01;persist security info=True;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";
        
        public static MesEntities Create()
        {
            MesEntities context = new MesEntities(ConnectionString);

            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}
namespace MiniSteelworksMES.Data
{
    public partial class MesEntities
    {
       

        public MesEntities(string connectionString) : base(connectionString)
        {
        }

    }
}