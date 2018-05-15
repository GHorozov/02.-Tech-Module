using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElement
{
    class CountOfGivenElement
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());
            var result = array.Where(x => x == number).Count();
            Console.WriteLine(result);
        }
    }
}
