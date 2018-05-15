using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int sumEven = GetSumEvenNumbers(n);
            int sumOdd = GetSumOfOddDigit(n);
            int multiplyDigits = sumEven * sumOdd;
            Console.WriteLine(multiplyDigits);
        }

        private static int GetSumEvenNumbers(int num)
        {
            int sumEven = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if(lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                num /= 10;
            }
            return sumEven;
        }

        private static int GetSumOfOddDigit(int num)
        {
            int sumOdd = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 1)
                {
                    sumOdd += lastDigit;
                }
                num /= 10;
            }
            return sumOdd;
        }
    }
}
