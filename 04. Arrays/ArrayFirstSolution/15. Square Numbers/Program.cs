using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
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
           
            List<int> squares = new List<int>(); 
            foreach (var num in list)
            {
                if(Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }

            squares.Sort((a,b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
