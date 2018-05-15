using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            GetClosestPodouble(x1, y1, x2, y2);
        }

        private static void GetClosestPodouble(double x1, double y1, double x2, double y2)
        {
            double distToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distToCenter1 < distToCenter2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
