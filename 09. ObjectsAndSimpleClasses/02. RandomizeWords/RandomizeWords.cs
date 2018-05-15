using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            var random = new Random();
            var words = Console.ReadLine().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomizeNumber = random.Next(i, words.Length);

                var temp = words[randomizeNumber];
                words[randomizeNumber] = currentWord;
                words[i] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
