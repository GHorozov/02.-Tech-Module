using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] numbers1 = input1.Split(' ');
            string[] numbers2 = input2.Split(' ');
            int[] arr1 = new int[numbers1.Length];
            int[] arr2 = new int[numbers2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(numbers1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(numbers2[i]);
            }

            int len1 = numbers1.Length;
            int len2 = numbers2.Length;

            int[] arr3 = new int[Math.Max(len1, len2)];
            for (int i = 0; i < Math.Max(len1, len2); i++)
            {
                arr3[i] = arr1[i % len1] + arr2[i % len2];
            }

            foreach (var element in arr3)
            {
                Console.Write(element + " ");
            }
        }
    }
}
