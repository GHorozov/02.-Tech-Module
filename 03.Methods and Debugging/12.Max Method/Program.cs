using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int result=GetMax(n1, n2,n3);
            Console.WriteLine(result);
        }

        private static int GetMax(int num1, int num2, int num3)
        {
            int[] array = new int[] { num1, num2, num3 };
            int result = array.Max();
            return result;
        }
    }
}
