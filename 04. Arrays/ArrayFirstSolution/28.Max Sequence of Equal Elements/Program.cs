using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();  
            int count = 0;
            int maxCount = 0;
            int longestValue = 0;
            for (int i = 0; i < input.Count; i++)
            {
                int j = 0;
                count = 0;
                while(j < input.Count)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                    if(count > maxCount)
                    {
                        maxCount = count;
                        longestValue = input[j];
                    }
                    j++;
                }
            }
            while(maxCount >= 1)
            {
                result.Add(longestValue);
                maxCount--;
            }

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
