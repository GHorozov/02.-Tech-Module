using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                if (i >= 0)
                {
                    if (i == 0)
                    {
                        leftSum = 0;
                    }
                    else
                    {
                        int incr = i;
                        while (i >= 1)
                        {
                            leftSum += input[incr - 1];
                            incr--;
                            if (incr <= 0) break;
                        }
                    }

                }
                if (i <= input.Length)
                {
                    if (i == input.Length)
                    {
                        rightSum = 0;
                    }
                    else
                    {
                        int incr = i;
                        while (i < input.Length - 1)
                        {
                            rightSum += input[incr + 1];
                            incr++;
                            if (incr == input.Length - 1) break;
                        }
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i); break;
                }
            }

            if (leftSum == 0 && rightSum == 0)
            {

            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }

        }
    }
}
