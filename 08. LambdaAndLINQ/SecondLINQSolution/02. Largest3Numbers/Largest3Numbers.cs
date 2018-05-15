using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();
            var largest3OfThem = list.Take(3);

            Console.WriteLine(string.Join(" ", largest3OfThem));

        }
    }
}
