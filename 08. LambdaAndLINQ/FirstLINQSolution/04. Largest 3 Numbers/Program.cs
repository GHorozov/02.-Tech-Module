using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> largest3Numbers = Console.ReadLine()
                                            .Split(' ')
                                            .Select(int.Parse)
                                            .OrderByDescending(x => x)
                                            .Take(3)
                                            .ToList();
            Console.WriteLine(String.Join(" ", largest3Numbers));
        }
    }
}
