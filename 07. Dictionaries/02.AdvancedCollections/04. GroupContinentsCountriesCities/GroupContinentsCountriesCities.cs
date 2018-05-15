using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesCities
{
    class GroupContinentsCountriesCities
    {
        static void Main()
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine().Split(' ');
                var continent = currentLine[0];
                var country = currentLine[1];
                var city = currentLine[2];

                if(!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if(! data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }

                data[continent][country].Add(city);
            }

            foreach (var continent in data.Keys)
            {
                Console.WriteLine("{0}:", continent);

                foreach (var country in data[continent])
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }
    }
}
