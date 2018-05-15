using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            string text = File.ReadAllText("text.txt");
            var splitText = text.ToLower().Split(new char[] { ' ', '-', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var wordCount = 0;
                for (int j = 0; j < splitText.Length; j++)
                {
                    if (currentWord == splitText[j])
                    {
                        wordCount++;
                    }
                }
                result[currentWord] = wordCount;
            }

            var orderedResult = result.OrderByDescending(x => x.Value).Select(x => $"{x.Key} - {x.Value}").ToArray();
            File.AppendAllText("output.txt", string.Join("\r\n", orderedResult));
        }
    }
}
