using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", line.Distinct()));
        }
    }
}
