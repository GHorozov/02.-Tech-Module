using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            for (int i = 0; i < list.Length-1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (list[j - 1] > list[j])
                    {
                        var temp = list[j-1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
