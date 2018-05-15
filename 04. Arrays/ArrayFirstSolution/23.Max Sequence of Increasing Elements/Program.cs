using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 0;
            int maxSeq = 0;
            int startCurrentSeq = 0;
            int startMaxSeq = 0;
            for (int i = 1; i < input.Length; i++)
            {

                if (input[i] - input[i - 1] >= 1)
                {
                    len++;
                    startCurrentSeq = i - len;

                    if (len > maxSeq)
                    {
                        maxSeq = len;
                        startMaxSeq = startCurrentSeq;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int i = startMaxSeq; i <= maxSeq + startMaxSeq; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
