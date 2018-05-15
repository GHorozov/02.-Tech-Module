using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var searchWord = Console.ReadLine().ToLower();

            var count = 0;
            var i = 0;
            while((i = text.IndexOf(searchWord, i)) != -1)
            {
                i += searchWord.Length;
                count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
