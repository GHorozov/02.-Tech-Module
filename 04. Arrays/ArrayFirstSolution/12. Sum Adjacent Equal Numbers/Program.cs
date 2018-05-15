using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<double> numbers = new List<double>();
            List<string> list = input.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

            // II-na4in
            //var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            //for (int i = 1; i < input.Count; i++)
            //{
            //    if (input[i] == input[i - 1])
            //    {
            //        input[i] = input[i] + input[i - 1];
            //        input.Remove(input[i - 1]);
            //        i = 0;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", input));







        }
    }
}
