using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                for (int j = 1; j <= i; j++)
                {                  
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            
            for (int i = (end-1); i >= 1; i--)
            {
                for (int j = 1 ; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
