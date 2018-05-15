using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            if (input.Contains(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
