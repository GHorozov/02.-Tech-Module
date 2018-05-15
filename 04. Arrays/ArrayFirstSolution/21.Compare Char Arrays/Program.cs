using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string[] result = { string.Join("", arr1), string.Join("", arr2) };
            Array.Sort(result);
            Console.WriteLine(string.Join("\n",result));

        }
    }
}
