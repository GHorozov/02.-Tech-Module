using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                isPrime[i] = true;
            }

            isPrime[0]=false;
            isPrime[1]=false;
            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = 2; j*i <=n ; j++)
                    {
                        isPrime[j * i] = false;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
