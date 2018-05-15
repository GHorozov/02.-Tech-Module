using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input = input1+input2+input3;

            string result = new string(input.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
