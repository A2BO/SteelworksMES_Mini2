using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class TransactionModel
    {
        public TransactionModel(int id, int quantity)
        {
            ResourceId = id;
            Quantity = quantity;
        }

        public int ResourceId { get; set; }
        public string SellerName { get; set; }
        public System.DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public int Type { get; set; }
        public int ResourceWareHouseId { get; set; }
        public int Quantity { get; set; }
        public int OriginId { get; set; }


        
    }

    public class TransactionModel2
    {
        public string Type { get; set; }

        public int Quantity { get; set; }

        public string Resource { get; set; }
    }
}
