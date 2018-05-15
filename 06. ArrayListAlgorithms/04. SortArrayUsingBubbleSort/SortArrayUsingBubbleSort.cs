using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length-1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
