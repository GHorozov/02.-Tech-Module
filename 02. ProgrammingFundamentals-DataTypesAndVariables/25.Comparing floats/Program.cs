using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Round(double.Parse(Console.ReadLine()), 6);
            double b = Math.Round(double.Parse(Console.ReadLine()), 6);

            double result = Math.Abs(a - b);
            if ( result <= 0.000001 )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }
}
