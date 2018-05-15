using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var firstPart = string.Empty;
                if (input[i].Length % 2 == 1)
                {
                     firstPart = input[i].Substring(0, (input[i].Length / 2)+1);
                }
                else
                {
                    firstPart = input[i].Substring(0, (input[i].Length / 2));
                }
                var secondPart = input[i].Substring((input[i].Length / 2));
                var second = Reverse(secondPart);

                if (firstPart.Equals(second))
                {
                    result.Add(currentWord);
                }
            }

            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
