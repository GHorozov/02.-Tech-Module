using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxSequance = int.MinValue;
            int maxSequanceValue = int.MinValue;
            int lenght = 0;
            int oldMaxSequance = 0;
            for (int i = 0; i < input.Length; i++)
            {
                lenght = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] != input[j] )
                    {
                        lenght = 0;
                    }
                    if (input[i] == input[j])
                    {
                        lenght++;
                    }
                    if (lenght > maxSequance)
                    {
                        maxSequance = lenght;
                        maxSequanceValue = input[i];
                    }
                }
                if(maxSequance > oldMaxSequance)
                {
                    i = (maxSequance - 1)+ i;
                    oldMaxSequance = maxSequance;
                }
                
            }
            for (int i = 0; i < maxSequance; i++)
            {
                Console.Write(maxSequanceValue + " ");
            }
            Console.WriteLine();
        }
    }
}
