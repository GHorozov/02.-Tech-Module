using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var border = string.Empty;
            var core = string.Empty;


            while (word != "end")
            {
                var currentWord = word;
                var count = 1;
                var list = new List<string>();
                while (true)
                {
                    if (count == (currentWord.Length / 2) + 1) break;
                    var firstPart = currentWord.Substring(0, count);
                    var secondPart = currentWord.Substring(currentWord.Length - count);


                    if (firstPart == secondPart)
                    {
                        var corePart = currentWord.Remove(0, firstPart.Length);
                        core = corePart.Remove((currentWord.Length) - (secondPart.Length * 2));

                        if (core == string.Empty) break;
                        border = firstPart;
                        var result = core + border + core;
                        list.Add(result);
                    }

                    count++;
                }

                if (list.Count > 0 && core != string.Empty)
                {
                    Console.WriteLine(list[list.Count - 1]);
                }

                core = string.Empty;
                border = string.Empty;
                word = Console.ReadLine();
            }
        }
    }
}
