using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main()
        {
            var characters = Console.ReadLine().Split(' ');
            var charSumTotal = 0;
            var currCharSum = 0;
            var charCount = 0;
            for (int i = 0; i < characters.Length; i++)
            {
               
                var currentChars = characters[i].ToCharArray();
                charCount += currentChars.Length;
                for (int j = 0; j < currentChars.Length; j++)
                {
                    var charNumber = (int)(currentChars[j]);
                    currCharSum += charNumber;
                }
                charSumTotal += currCharSum;
                currCharSum = 0;
            }

            var averageChar =  (double)charSumTotal / charCount;
            var charSymbol = (char)(averageChar);
            var list = new List<string>();
            for (int i = 0; i < characters.Length; i++)
            {
                list.Add(characters[i]);
                if(i < characters.Length-1)
                {
                    list.Add(charSymbol.ToString().ToUpper());
                }
                
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}
