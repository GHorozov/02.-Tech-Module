using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] numbers = num.Split(' ');
            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[i] + array[j] == array[k])
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");
                            count++;
                            break;
                        }

                    }

                }

            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
