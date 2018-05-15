using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(int number)
        {
            if(Math.Sign(number) == 1)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if(Math.Sign(number) == -1)
            {
                Console.WriteLine("The number {0} is negative.",number);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }

        }
    }
}
