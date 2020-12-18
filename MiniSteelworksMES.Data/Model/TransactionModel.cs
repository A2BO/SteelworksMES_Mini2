using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class TransactionModel
    {
        public TransactionModel(int id, int? quantity)
        {
            ResourceId = id;
            Quantity = (int)quantity;
        }

        public int ResourceId { get; set; }

        public int Quantity { get; set; }
    }
}
