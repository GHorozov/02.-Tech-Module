using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            int k = input.Length / 4;

            int[] left = input.Take(k).Reverse().ToArray();
            int[] right = input.Reverse().Take(k).ToArray();
            int[] row1 = left.Concat(right).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            int[] sum = row1.Select((x, index) => x + row2[index]).ToArray();
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
