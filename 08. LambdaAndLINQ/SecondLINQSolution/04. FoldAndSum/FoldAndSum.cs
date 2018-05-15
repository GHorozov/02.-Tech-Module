using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = inputList.Length / 4;
            var rowOneLeft = inputList.Take(k).Reverse().ToArray();
            var rowTwoRight = inputList.Reverse().Take(k).ToArray();

            var upperRow = rowOneLeft.Concat(rowTwoRight).ToArray();
            var downRow = inputList.Skip(k).Take(k*2).ToArray();

            var sum = new int[upperRow.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = upperRow[i] + downRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
