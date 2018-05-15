using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] numbers = n.Split(' ');
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }

            GetMiddleElement(arr);
        }

        private static void GetMiddleElement(int[] numbers)
        {
            int middle = numbers.Length/2;
            
            if (numbers.Length <= 1)
            {
                Console.WriteLine($"{numbers[0]}");
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{numbers[middle-1]} {numbers[middle]}");
            }
            else if (numbers.Length % 2 == 1)
            {
                Console.WriteLine($"{numbers[middle - 1]} {numbers[middle]} {numbers[middle+1]}");
            }
        }
    }
}
