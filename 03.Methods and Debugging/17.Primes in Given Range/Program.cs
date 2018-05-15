using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string primeNumbersList = String.Join(", ", FindPrimesInRange(n1, n2).ToArray());
            Console.WriteLine(primeNumbersList); 
        }

        private static List<int> FindPrimesInRange( int start, int end)
        {
            List<int> result = new List<int>();   
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
