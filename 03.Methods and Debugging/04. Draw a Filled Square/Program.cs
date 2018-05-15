using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigureTopAndBottom(n);
            PrintFugureMiddle(n);
            PrintFigureTopAndBottom(n);
        }

        private static void PrintFigureTopAndBottom(int num)
        {
            Console.WriteLine(new string('-',2*num));
        }

        private static void PrintFugureMiddle(int num)
        {
           
            for (int i = 0; i < num-2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < num; j++)
                {
                    Console.Write("\\/");
                }
                
                Console.WriteLine("-");
            }
           
        }
    }
}
