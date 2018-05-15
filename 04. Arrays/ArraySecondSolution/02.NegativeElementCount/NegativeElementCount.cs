using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeElementCount
{
    class NegativeElementCount
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var result = array.Where(x => (x < 0)).Count();

            Console.WriteLine(result);
        }
    }
}
