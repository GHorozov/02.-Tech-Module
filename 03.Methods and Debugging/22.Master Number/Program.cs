using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(IsPalindrome(i)==true && SumOfDigits(i)==true && ContainsEvenDigit(i)==true)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool IsPalindrome(int num)
        {         
            string holder = num.ToString();
            bool isPalindrome = false;
            int equalPairs = 0;

            for (int i = 0; i < holder.Length/2; i++)
            {
                if(holder[i] == holder[holder.Length - 1 - i])
                {
                    equalPairs += 1;
                }
            }

            if (equalPairs == holder.Length / 2)
            {
                isPalindrome = true;
            }          

            return isPalindrome;
        }

        private static bool SumOfDigits(int num)
        {        
            bool isDevisible = false;
            int sumOfDigits = 0;
            while (num > 0)
            {
                sumOfDigits += num % 10;
                num = num / 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                isDevisible = true;
            }

            return isDevisible;
        }

        private static bool ContainsEvenDigit(int num)
        {
            bool isEven = false;
            int lastDigit;
            while (num > 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    isEven = true;
                    break;
                }
                num = num / 10;
            }

            return isEven;         
        }
    }
}
