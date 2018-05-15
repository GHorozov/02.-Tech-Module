using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int start = Math.Max(0, i - k);
                int end = i - 1;
                for (int z = start; z <= end; z++)
                {
                    sum += array[z];
                }
                array[i] = sum;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
