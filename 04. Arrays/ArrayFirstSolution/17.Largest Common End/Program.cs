using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(' ');
            string[] inputTwo = Console.ReadLine().Split(' ');
            List<string> result = new List<string>();
            int countShort = 0;
            int countLong = 0;
            int shorterSequance = Math.Min(inputOne.Length, inputTwo.Length);
            int longestSequance = Math.Max(inputOne.Length, inputTwo.Length);

            for (int i = 0; i < shorterSequance; i++)
            {
                if (inputOne[i] == inputTwo[i])
                {
                    result.Add(inputOne[i]);
                    countShort++;
                }
            }
            Array.Reverse(inputOne);
            Array.Reverse(inputTwo);
            for (int i = 0; i < longestSequance; i++)
            {
                if (shorterSequance <= 0) break;

                if (inputOne[i] == inputTwo[i])
                {
                    result.Add(inputOne[i]);
                    countLong++;
                }
                shorterSequance--;
            }
          
            if (countShort > countLong)
            {
                Console.WriteLine(countShort);
            }
            else
            {
                Console.WriteLine(countLong);
            }

        }
    }
}
