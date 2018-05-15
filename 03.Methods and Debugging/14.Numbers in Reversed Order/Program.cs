using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            GetNumberinReverseOrder(n);
        }

        private static void GetNumberinReverseOrder(decimal num)
        {
            string strNumber = num.ToString("##.###");
            char[] stringToCharArray = strNumber.ToCharArray().Reverse().ToArray();
            foreach (var item in stringToCharArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
