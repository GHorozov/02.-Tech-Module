using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNum = RealNumber();
            int[] intArr = new int[realNum.Length];
            for (int i = 0; i < realNum.Length; i++)
            {
                intArr[i] = (int)Math.Round(realNum[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(realNum[i]);
                Console.WriteLine(intArr[i]);
            }
        }

        private static double[] RealNumber()
        {
            string n = Console.ReadLine();
            string[] numbers = n.Split(' ');
            double[] realNum = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                realNum[i] = double.Parse(numbers[i]);
            }

            return realNum;
        }
    }
}
