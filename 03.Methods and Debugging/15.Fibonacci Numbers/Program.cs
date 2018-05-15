using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
           
        }

        private static void Fib(int num)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= num; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine(a);
        }
    }
}
