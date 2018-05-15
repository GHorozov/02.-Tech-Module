using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = input.Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in list)
            {
                if (GetWordType(word) == "lowerCase")
                {
                    lowerCase.Add(word);
                }
                else if (GetWordType(word) == "upperCase")
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }

        private static string GetWordType(string str)
        {
            string lowerCase = "lowerCase";
            string upperCase = "upperCase";
            string mixedCase = "mixedCase";

            string result = "";
            int sumLower = 0;
            int sumUpper = 0;
            foreach (var letter in str)
            {
                if(letter == '#')
                {
                    Char.ToLower(letter);
                }
               
                if (char.IsLower(letter))
                {
                    sumLower++;
                    result = lowerCase;
                }
                else if (char.IsUpper(letter))
                {
                    sumUpper++;
                    result = upperCase;
                }
                else
                {
                    result = mixedCase;
                    break;
                }
                if (sumLower + sumUpper >= 2 && sumUpper > 0 && sumLower > 0)
                {
                    result = mixedCase;
                    break;
                }
            }

            return result;
        }
    }
}
