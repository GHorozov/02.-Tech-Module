using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();
            List<double> numbers = new List<double>();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
