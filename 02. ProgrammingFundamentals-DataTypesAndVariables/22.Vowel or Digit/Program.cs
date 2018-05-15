using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'o' || input == 'u' || input == 'i' || input == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if(char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
