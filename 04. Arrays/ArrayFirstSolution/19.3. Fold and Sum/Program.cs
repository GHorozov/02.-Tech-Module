using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 2;
            int[] left = new int[(input.Length - k) / 2];
            int[] right = new int[(input.Length - k) / 2];
            //take left side
            int decr = k / 2 - 1;
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = input[decr];
                decr--;
            }
            //take right side
            decr = input.Length - 1;
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = input[decr];
               decr--;
            }
            // add left + right side
            int rise = k/2;
            int[] leftRightElement = new int[k];
            for (int i = 0; i < k/2; i++)
            {
                leftRightElement[i] = left[i];
            }
            for (int i = 0; i < k/2; i++)
            {
                leftRightElement[rise] = right[i];
                rise++;
            }
            //take middle numbers
            int[] middle = new int[k];
            int inc = 0;
            for (int i = k/2 ; i < input.Length - (k / 2); i++)
            {
                middle[inc] = input[i];
                inc++;
            }
            //sum all
            int[] sum = new int[k];
            for (int i = 0; i < k; i++)
            {
                sum[i] = leftRightElement[i] + middle[i];
            }

            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
