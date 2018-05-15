using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<int> revNum = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                string number = input[i];
                string reversed = ReverseNumber(number);
                revNum.Add(int.Parse(reversed));
            }
            Console.WriteLine(revNum.Sum());
        }

        private static string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            string result = string.Join("", charArray);
            return result;
        }
    }
}
