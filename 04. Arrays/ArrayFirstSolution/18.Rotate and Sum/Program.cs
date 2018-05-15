using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumResults = new int[input.Length];
            for (int i = 0; i < k; i++)
            {
                int lastElement = input[input.Length - 1];
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastElement;

                for (int z = 0; z < input.Length; z++)
                {
                    sumResults[z] += input[z];
                }
            }

            Console.WriteLine(string.Join(" ", sumResults));

        }
    }
}
