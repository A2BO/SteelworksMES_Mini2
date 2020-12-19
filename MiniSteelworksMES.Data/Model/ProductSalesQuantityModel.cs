using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class ProductSalesQuantityModel
    {
        public ProductSalesQuantityModel(int pid, int pdid, int amount)
        {
            ProductId = pid;
            ProductDetailId = pdid;
            Amount = amount;

        }
        public int ProductId { get; set; }

        public int ProductDetailId { get; set; }

        public int Amount { get; set; }
    }
    public class ProductSalesQuantityModel2
    {
        public string Type { get; set; } // 판매량
        public int Amount { get; set; } // amount

        public string Product { get; set; }

    }
}
