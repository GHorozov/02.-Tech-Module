using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            int result = intArray.Max();
            Console.WriteLine(result);
        }
    }
}
