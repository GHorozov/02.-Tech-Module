using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCapitalLetters
{
    class CountCapitalLetters
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');

            var result = default(char);
            var count = 0;
            foreach (var word in array)
            {
                var currentChar = char.TryParse(word, out result);
                if(word.Length<2 &&  currentChar == true && char.Parse(word) < 'a')
                {
                    count++;
                } 
            }

            Console.WriteLine(count);
        }
    }
}
