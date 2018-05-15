using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = CalculatePerimeter(width,height);
            double area = CalculateArea(width, height);
            double diagonal = CalculateDiagonale(width, height);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }

        private static double CalculateDiagonale(double num1, double num2)
        {
            double c = Math.Sqrt((Math.Pow(num1, 2)) + (Math.Pow(num2, 2)));
            return c;
        }

        private static double CalculateArea(double num1, double num2)
        {
            double area = num1 * num2;
            return area;
        }

        private static double CalculatePerimeter(double num1, double num2)
        {
            double perimeter = 2 * num1 + 2 * num2;
            return perimeter;
        }
    }
}
