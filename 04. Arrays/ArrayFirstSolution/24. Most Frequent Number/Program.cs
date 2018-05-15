using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countCurrentNum = 1;
            int maxCount = 0;
            int repeatedValue = 0;
            for (int i = 0; i < input.Length; i++)
            {
                countCurrentNum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[i] == input[j])
                    {
                        countCurrentNum++;
                    }
                    if (countCurrentNum > maxCount)
                    {
                        maxCount = countCurrentNum;
                        repeatedValue = input[i];
                    }
                }
            }
            Console.WriteLine(repeatedValue);
        }
    }
}
