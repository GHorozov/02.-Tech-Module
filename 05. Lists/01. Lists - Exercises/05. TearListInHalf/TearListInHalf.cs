using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var rightHalf = new List<int>();
            var leftHalf = new List<int>();
            var result = new List<int>();
            rightHalf.AddRange(input.Where((x, index) => index  >= (input.Count / 2)));
            leftHalf.AddRange(input.Where((x, index) => index < (input.Count / 2)));

            for (int i = 0; i < rightHalf.Count; i++)
            {
                var currentNum = rightHalf[i];
                var leftDigit = currentNum / 10;
                var rightDigit = currentNum % 10;
                var currentLeftHaltListNum = leftHalf[i];
                result.Add(leftDigit);
                result.Add(currentLeftHaltListNum);
                result.Add(rightDigit);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
