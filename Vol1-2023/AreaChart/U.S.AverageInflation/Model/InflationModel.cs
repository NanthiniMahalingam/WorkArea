using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.AverageInflation
{
    public class InflationModel
    {
        public DateTime Year { get; set; }
        public double AveragePercentage { get; set; }

        public InflationModel(DateTime year, double percentage) 
        {
            Year = year;
            AveragePercentage = percentage;
        }

    }
}
