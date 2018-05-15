using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerNumbersCount
{
    class LargerNumbersCount
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var number = double.Parse(Console.ReadLine());
            var result = array.Where(x => x > number).Count();

            Console.WriteLine(result);
        }
    }
}
