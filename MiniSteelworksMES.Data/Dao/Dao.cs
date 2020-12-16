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
        
        //public static SaleDao Sale { get; } = new Sale();
        //public static ExpenseDao expense { get; } = new Expense();
        //public static ExpenseLineDao expenseLine { get; } = new ExpenseLine();
        //public static GrowthRateDao GrowthRate { get; } = new GrowthRate();
        //public static ProductDao product { get; } = new Product();
        //public static ProductDetailDao ProductDetail { get; } = new ProductDetail();
        public static ProductWareHouseDao ProductWareHouse { get; } = new ProductWareHouseDao();
        //public static TeamDao team { get; } = new Team();

    }
}
