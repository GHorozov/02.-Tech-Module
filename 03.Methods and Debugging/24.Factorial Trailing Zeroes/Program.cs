using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _24.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = ReturnFactorial(n);
            BigInteger counter = GetTrailingZeroes(factorial);
            //Console.WriteLine("{0}! = {1} -> {2} trailing zeroes",n,factorial,counter);
            Console.WriteLine(counter);

        }

        private static BigInteger ReturnFactorial(int num)
        {
            BigInteger fact = 1;
            for (int i = 1; i < num; i++)
            {
                fact *= (i + 1);
            }

            return fact;
        }

        private static BigInteger GetTrailingZeroes(BigInteger fact)
        {
            BigInteger lastDigit;
            int count = 0;
            while(fact > 0)
            {
                lastDigit = fact % 10;
                count += 1;
                if (lastDigit > 0)
                {
                    count = count - 1;
                    break;
                }
                fact = fact / 10;
            }
            return count;
        }
    }
}
