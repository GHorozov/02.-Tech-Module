using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);

            Console.WriteLine(input);
        }
    }
}
