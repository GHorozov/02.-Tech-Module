using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesContinentCountry
{
    class CitiesContinentCountry
    {
        static void Main()
        {
            var continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine().Split(' ');
                var continent = currentLine[0];
                var country = currentLine[1];
                var city = currentLine[2];

                if(!continentCountryCity.ContainsKey(continent))
                {
                    continentCountryCity[continent]= new Dictionary<string, List<string>>();
                }

                if(!continentCountryCity[continent].ContainsKey(country))
                {
                    continentCountryCity[continent][country] = new List<string>();
                }

                continentCountryCity[continent][country].Add(city);
            }

            foreach (var continent in continentCountryCity.Keys)
            {
                Console.WriteLine("{0}:", continent);

                foreach (var country in continentCountryCity[continent])
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }
    }
}
