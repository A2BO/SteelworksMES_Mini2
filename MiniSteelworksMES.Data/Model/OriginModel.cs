using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class OriginModel
    {
        //private double? longgitude_Member;

        public OriginModel(int id, int quantity, string origin)
        {
            ResourceId = id;
            Quantity = quantity;
            //Longgitude = (double)longgitude_Member;
            //Latitude = (double)Latitude_Member;
            Origin = origin;

        }
        public int OriginCount { get; set; }

        public string Origin { get; set; }

        //public double Longgitude { get; set; }

        //public double Latitude { get; set; }

        public int ResourceId { get; set; }

        public int Quantity { get; set; }
    }
}
