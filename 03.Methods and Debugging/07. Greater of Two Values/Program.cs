using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = Console.ReadLine();

            if(myStr == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetBiggestInteger(a, b);
                Console.WriteLine(result);
            }
            else if(myStr == "char")
            {
                char myChar = char.Parse(Console.ReadLine());
                char myChar2 = char.Parse(Console.ReadLine());
                char result = GetBiggestChar(myChar,myChar2);
                Console.WriteLine(result);
            }
            else
            {
                string strOne = Console.ReadLine();
                string strTwo = Console.ReadLine();
                string result = GetBiggestString(strOne, strTwo);
                Console.WriteLine(result);
            }
        }

        private static int GetBiggestInteger(int num1,int num2)
        {
            int result = Math.Max(num1, num2);
            return result;
        }

        private static char GetBiggestChar(char ch, char ch2)
        {
            char[] charArray = new char[] { ch, ch2 };
            char result = charArray.Max();
            return result;
        }

        private static string GetBiggestString(string str1, string str2)
        {
            string[] myStrArray = new string[] { str1, str2 };
            string result = myStrArray.Max();
            return result;
        }
    }
}
