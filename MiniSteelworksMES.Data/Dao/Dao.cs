using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class Dao
    {
        public static TransactionDao Transaction { get; } = new TransactionDao();
        public static Resource_QuoteDao Resource_Quote { get; } = new Resource_QuoteDao();
        public static EmployeeDao Employee { get; } = new EmployeeDao();
        public static ResourceDao Resource { get; } = new ResourceDao();
        public static ResourceWareHouseDao ResourceWareHouse { get; } = new ResourceWareHouseDao();
        public static OrderDao Order { get; } = new OrderDao();
        
        public static SaleDao sale { get; } = new SaleDao();
        public static ExpenseDao expense { get; } = new ExpenseDao();
        public static ExpenseLineDao expenseLine { get; } = new ExpenseLineDao();
        public static GrowthRateDao growthRate { get; } = new GrowthRateDao();
        public static ProductDao product { get; } = new ProductDao();
        public static ProductDetailDao productDetail { get; } = new ProductDetailDao();
        public static ProductWareHouseDao ProductWareHouse { get; } = new ProductWareHouseDao();
        public static TeamDao team { get; } = new TeamDao();

    }
}
