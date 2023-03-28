using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggPriceChart
{
    public class EggPriceModel
    {
        public DateTime Month { get; set; }
        public double AveragePrice { get; set; }

        public EggPriceModel(DateTime month, double averagePrice)
        {
            Month = month;
            AveragePrice = averagePrice;
        }
    }
}
