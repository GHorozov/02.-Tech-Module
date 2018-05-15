using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string sentanse = Console.ReadLine().ToLower();
            string[] word = sentanse.Split(separators);
            string[] result = word.Where(w => w != "")
                                .Where(w => w.Length < 5)
                                .OrderBy(w => w)
                                .Distinct()
                                .ToArray();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
