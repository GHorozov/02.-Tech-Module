using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOddElements
{
    class RemoveOddElements
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            for (int i = input.Count-1; i >= 0; i--)
            {
                if(i % 2 == 0)
                {
                    input.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
