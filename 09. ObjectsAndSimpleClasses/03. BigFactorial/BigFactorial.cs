using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
