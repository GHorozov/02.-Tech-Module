using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var word in counts)
            {
                if(word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
