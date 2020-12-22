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

        public OriginModel(int id, int quantity/*, double longgitude_Member, double latitude_Member*/)
        {
            OriginId = id;
            Quantity = quantity;
            //Longgitude = longgitude_Member;
            //Latitude = latitude_Member;
        }

        public string OriginName { get; set; }

        public double Longgitude { get; set; }

        public double Latitude { get; set; }

        public int OriginId { get; set; }

        public int Quantity { get; set; }
    }
}
