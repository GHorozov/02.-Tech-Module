using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public string Print()
    {
        return $"({X}, {Y})";
    }
}

namespace ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first+1 ; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var currentDistance = Distance(firstPoint, secondPoint);

                    if(currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine("{0:f3}",minDistance);
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
        private static Point ReadPoint()
        {
            var pointInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var point = new Point
            {
                X = pointInput[0],
                Y = pointInput[1]
            };

            return point;
        }
    }
}
