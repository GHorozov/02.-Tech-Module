using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumExtraction
{
    class EqualSumExtraction
    {
        static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            var firstListSum = firstList.Sum();
            var secondListSum = secondList.Sum();
            var diff = Math.Abs(firstListSum - secondListSum);
            if (firstListSum == secondListSum)
            {
                Console.WriteLine("Yes. Sum: {0}", firstListSum);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", diff);
            }
        }
    }
}
