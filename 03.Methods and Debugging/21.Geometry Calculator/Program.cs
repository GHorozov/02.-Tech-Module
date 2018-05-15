using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle") PrintTriangleArea();
            else if (figure == "square") PrintSquareArea();
            else if (figure == "rectangle") PrintRectangleArea();
            else if (figure == "circle") PrintCircleArea();
        }

        private static void PrintTriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double area = (a * ha) / 2;
            Console.WriteLine("{0:f2}",area);
        }

        private static void PrintSquareArea()
        {
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine("{0:f2}", area);
        }

        private static void PrintRectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine("{0:f2}", area);
        }

        private static void PrintCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI*Math.Pow(r,2);
            Console.WriteLine("{0:f2}", area);
        }
    }
}
