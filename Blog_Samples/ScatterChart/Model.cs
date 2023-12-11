using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterChart
{
    public class Model
    {
        public string Year { get; set; }
        public double Population { get; set; }
        public double Population1 { get; set; }
        public double Population2 { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }

        public Model(string year, double aruba, double america, double population2)
        {
            Year = year;
            Population = aruba;
            Population1 = america;
            Population2 = population2;
        }

        public Model(string country, double population)
        {
            Country = country;
            Population = population;
        }

        public Model(string country, double population, string countryName)
        {
            Country = country;
            Population = population;
            CountryName = countryName;
        }

    }
}
