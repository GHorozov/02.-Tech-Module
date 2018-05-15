using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var banWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            var result = string.Empty;
            for (int i = 0; i < banWords.Length; i++)
            {
                text = text.Replace(banWords[i], new string('*', banWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
