using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            foreach (var number in list)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
