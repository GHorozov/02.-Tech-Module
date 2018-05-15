using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');
            var arrayReversed = array.Reverse().ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if(!(array[i] == arrayReversed[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");

        }
    }
}
