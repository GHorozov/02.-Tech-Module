using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class Program
    {
        static void Main()
        {
            var list = new List<int>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            var sum = list.Sum();
            var min = list.Min();
            var max = list.Max();
            var average = list.Average();

            Console.WriteLine($"Sum = {sum}\nMin = {min}\nMax = {max}\nAverage = {average}");
        }
    }
}
