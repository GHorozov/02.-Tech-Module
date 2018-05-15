using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            IsPrime(n);
        }
        private static void IsPrime(long num)
        {
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if( num % i == 0)
                {
                    isPrime = false;
                    break;
                }             
            }
            Console.WriteLine(isPrime);
        }
    }
}
