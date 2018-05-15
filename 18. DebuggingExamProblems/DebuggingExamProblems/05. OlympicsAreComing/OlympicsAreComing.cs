using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicsAreComing
{
    class OlympicsAreComing
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, int>>();

            while(inputLine != "report")
            {
                var inputParams = inputLine.Split(new[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
                var athlete = string.Join(" ", inputParams[0].Trim().Split(new[] { ' ', '\n','\t','\r' }, StringSplitOptions.RemoveEmptyEntries));
                var country = string.Join(" ", inputParams[1].Trim().Split(new[] {' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries));
                

                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, int>();
                }

                if (!result[country].ContainsKey(athlete))
                {
                    result[country][athlete] = 0;
                }

                result[country][athlete] += 1;

                inputLine = Console.ReadLine();
            }

            //Sort by number of wins by Decennding.
            foreach (var country in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} ({country.Value.Count} participants): {country.Value.Values.Sum()} wins");
            }
        }
    }
}
