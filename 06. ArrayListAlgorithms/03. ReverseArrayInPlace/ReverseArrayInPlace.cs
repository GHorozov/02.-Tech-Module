using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < list.Length/2; i++)
            {
                var leftElement = list[i];
                var rightElement = list[list.Length - (i+1)];
                var temp = leftElement;
                list[i] = rightElement;
                list[list.Length - (i+1)] = temp;
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
