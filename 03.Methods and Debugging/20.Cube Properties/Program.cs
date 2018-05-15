using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            PrintAction(a, parameter);
        }

        private static double PrintFace(double side)
        {
            double face = Math.Sqrt(2) * side;
            return face;
        }

        private static double PrintSpace(double side)
        {
            double space = Math.Sqrt(3) * side;
            return space;
        }

        private static double PrintVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        private static double PrintArea(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            return area;
        }

        private static void PrintAction(double side, string parameter)
        {
            if (parameter == "face") Console.WriteLine("{0:f2}", PrintFace(side));
            else if (parameter == "space") Console.WriteLine("{0:f2}", PrintSpace(side));
            else if (parameter == "volume") Console.WriteLine("{0:f2}", PrintVolume(side));
            else if (parameter == "area") Console.WriteLine("{0:f2}", PrintArea(side));
        }
    }
}
