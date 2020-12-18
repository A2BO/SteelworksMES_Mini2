using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class SaleModel
    {
        public SaleModel(int id, int? saleid)
        {
            TeamId = id;
            Quantity = (int)saleid;
        }

        public int TeamId { get; set; }

        public int Quantity { get; set; }
    }

    public class TheModel
    {
        public string Type { get; set; } // 목표건수 / 달성건수

        public string Team { get; set; }

        public int Count { get; set; }
    }
}
