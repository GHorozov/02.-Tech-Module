using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceElements
{
    class EqualSequenceElements
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var first = array.First();
            var equalElements = array.Where(x => x == first).Count();

            if(equalElements == array.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
