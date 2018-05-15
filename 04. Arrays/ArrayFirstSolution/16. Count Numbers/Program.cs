using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }

            list.Sort();
            int position = 0;

            while (position < list.Count)
            {
                int num = list[position];
                int count = 1;

                while (position + count < list.Count && list[position + count] == num)
                {
                    count++; 
                }
                position = position + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
