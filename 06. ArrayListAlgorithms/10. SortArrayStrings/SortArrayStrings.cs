using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayStrings
{
    class SortArrayStrings
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');

            for (int i = 1; i < array.Length; i++)
            {
                var value = array[i];
                var j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
