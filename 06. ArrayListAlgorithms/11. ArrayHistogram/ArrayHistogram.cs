using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');

            var words = new Dictionary<string, int>();
            words = GetWordCount(array, words);
            PrintResult(words);

        }

        private static void PrintResult(Dictionary<string, int> words)
        {
            var valuesSum = words.Values.Sum();
            foreach (var word in words.OrderByDescending(x => x.Value))
            {
                var currentPercent = (word.Value / (double)valuesSum) * 100;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", word.Key, word.Value, currentPercent);
            }
        }

        private static Dictionary<string, int> GetWordCount(string[] array, Dictionary<string, int> words)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (words.ContainsKey(array[i]))
                {
                    continue;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        var word = array[i];
                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, 1);
                        }
                        else
                        {
                            words[word]++;
                        }
                    }
                }
            }

            return words;
        }
    }
}
