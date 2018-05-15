using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint= ReadPoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine("{0:f3}", result);
        }

        public static double Distance(Point firstPoint ,Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
        public static Point ReadPoint()
        {
            var pointInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var points = new Point
            {
                X = pointInput[0],
                Y = pointInput[1]
            };

            return points;
        }
    }
}
