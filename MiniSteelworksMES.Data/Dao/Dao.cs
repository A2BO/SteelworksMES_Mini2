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
        
        public static SaleDao Sale { get; } = new SaleDao();
        public static ExpenseDao Expense { get; } = new ExpenseDao();
        public static ExpenseCategoryDao ExpenseLine { get; } = new ExpenseCategoryDao();
        public static GrowthRateDao GrowthRate { get; } = new GrowthRateDao();
        public static ProductDao Product { get; } = new ProductDao();
        public static ProductDetailDao ProductDetail { get; } = new ProductDetailDao();
        public static ProductWareHouseDao ProductWareHouse { get; } = new ProductWareHouseDao();
        public static TeamDao Team { get; } = new TeamDao();

    }
}
