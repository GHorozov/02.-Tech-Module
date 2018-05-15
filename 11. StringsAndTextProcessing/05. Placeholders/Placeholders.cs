using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while(input != "end")
            {
                var inputLine = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var text = inputLine[0];
                var words = inputLine[1].Split(new[] {',', ' '},StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";
                    text = text.Replace(currentPlaceholder, words[i]);
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }
        }
    }
}
