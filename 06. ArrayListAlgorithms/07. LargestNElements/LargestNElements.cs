using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class LargestNElements
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Length-1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if(list[j-1] < list[j])
                    {
                        var temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                    j--;
                }
            }

            var result = new List<int>();
            var count = 0;
            foreach (var num in list)
            {
                result.Add(num);
                count++;
                if (count == n) break;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
