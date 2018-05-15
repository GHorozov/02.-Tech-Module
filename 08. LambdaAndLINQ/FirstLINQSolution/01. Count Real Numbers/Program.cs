using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            //8 2.5 2.5 8 2.5
            foreach (var number in numbers)
            {
                double num = double.Parse(number);
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
