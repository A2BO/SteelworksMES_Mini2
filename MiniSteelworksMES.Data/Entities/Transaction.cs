using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    partial class Transaction
    {
        public string TypeText
        {
            get
            {
                return Type == 1 ? "입고" : "출고";
            }
        }
    }
}
