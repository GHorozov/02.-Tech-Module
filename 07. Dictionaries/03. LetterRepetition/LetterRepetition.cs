using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var counts = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!counts.ContainsKey(letter))
                {
                    counts[letter]=0;
                }
               
                counts[letter]++;
                
            }

            foreach (var pairs in counts)
            {
                Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
            }
        }
    }
}
