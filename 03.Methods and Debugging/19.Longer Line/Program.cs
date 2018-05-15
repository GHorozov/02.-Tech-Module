using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double pointX1 = double.Parse(Console.ReadLine());
            double pointY1 = double.Parse(Console.ReadLine());
            double pointX2 = double.Parse(Console.ReadLine());
            double pointY2 = double.Parse(Console.ReadLine());
            double pointX3 = double.Parse(Console.ReadLine());
            double pointY3 = double.Parse(Console.ReadLine());
            double pointX4 = double.Parse(Console.ReadLine());
            double pointY4 = double.Parse(Console.ReadLine());

            PrintLongerLineClosestPointsFirst(pointX1, pointY1, pointX2, pointY2, pointX3, pointY3, pointX4, pointY4);
        }

        //calculate lines lenght one by one
        private static double GetLineLenght(double x1,double y1, double x2, double y2)
        {
            double lineLenght = Math.Sqrt(((x1 - x2) *(x1 - x2)) + ((y1 - y2) *(y1 - y2)));    
            return lineLenght;
        }

        private static double GetDistanceToCenter(double x,double y)
        {
            double distance = Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
            return distance;
        }

        private static void GetClosestPointToCenter(double x1, double y1, double x2, double y2)
        {           
            if (GetDistanceToCenter(x1, y1) > GetDistanceToCenter(x2, y2))
            {              
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }           
        }

        private static void PrintLongerLineClosestPointsFirst(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if(GetLineLenght(x1,y1,x2,y2) >= GetLineLenght(x3, y3, x4, y4))
            {
                GetClosestPointToCenter(x1, y1, x2, y2);
            }
            else if(GetLineLenght(x1, y1, x2, y2) < GetLineLenght(x3, y3, x4, y4))
            {
                GetClosestPointToCenter(x3, y3, x4, y4);
            }
        }
    }
}
