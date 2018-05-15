using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(input, 2);
            string hex = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
