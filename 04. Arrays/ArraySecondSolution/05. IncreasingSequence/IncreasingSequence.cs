using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length-1; i++)
            {
                if(! (array[i+1] > array[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
