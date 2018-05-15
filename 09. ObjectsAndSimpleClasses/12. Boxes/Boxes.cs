using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

    }
    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            return ((2 * width) + (2 * height));
        }

        public static int CalculateArea(int widht, int height)
        {
            return (widht * height);
        }
    }
    class Boxes
    {
        static void Main()
        {
            var boxesList = new List<Box>();
            var line = Console.ReadLine();
            while(line != "end")
            {
                var input = line.Split(new char[] { ':', '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentBox = new Box();
                currentBox.UpperLeft = ReadPoint(input[0], input[1]);
                currentBox.UpperRight = ReadPoint(input[2], input[3]);
                currentBox.BottomLeft = ReadPoint(input[4], input[5]);
                currentBox.BottomRight = ReadPoint(input[6], input[7]);

                boxesList.Add(currentBox);
           
                line = Console.ReadLine();
            }

            //Print result
            foreach (var box in boxesList)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);

                Console.WriteLine("Box: {0}, {1}", width, height);
                Console.WriteLine("Perimeter: {0}", Box.CalculatePerimeter( (int)width, (int)height));
                Console.WriteLine("Area: {0}", Box.CalculateArea((int)width, (int)height));
            }

        }

        private static Point ReadPoint(string firstpoint, string secondpoint)
        {
            var point = new Point
            {
                X = int.Parse(firstpoint),
                Y = int.Parse(secondpoint)
            };

            return point;
        }
    }
}
