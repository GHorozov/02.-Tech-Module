using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.condensed_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] array = new int[numbers.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            int[] condensed = new int[array.Length - 1];

            while (array.Length > 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                    array[i] = condensed[i];
                }
                Array.Resize(ref condensed, condensed.Length - 1);
                Array.Resize(ref array, array.Length - 1);
            }

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
