using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool special = IsSpecial(i);
                Console.WriteLine("{0} -> {1}",i,special);
            }

          
        }

        private static bool IsSpecial(int num)
        {
            int sumOfDigits = CalcSumOfDigits(num);
            bool special = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
            return special;
        }

        private static int CalcSumOfDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += (num % 10);
                num = num / 10;
            }
            return sum;
        }
    }
}
