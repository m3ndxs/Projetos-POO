using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityComparison.Entities
{
    public class CityInfo
    {
        string cityName;
        string countryName;
        int population2010;

        public CityInfo(string cityName, string countryName, int population2010)
        {
            this.cityName = cityName;
            this.countryName = countryName;
            this.population2010 = population2010;
        }

        public string City { get { return this.cityName; } }
        public string Country { get { return this.countryName; } }
        public int Population { get { return this.population2010; } }

        //Compare to name
        public static int CompareByName(CityInfo city1, CityInfo city2)
        {
            return String.Compare(city1.City, city2.City);
        }

    }
}
