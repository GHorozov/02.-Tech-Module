using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNumberOnPow(a,b));
        }

        private static double GetNumberOnPow(double baseNumber, int power)
        {
            double result = Math.Pow(baseNumber, power);
            return result;
        }
    }
}
