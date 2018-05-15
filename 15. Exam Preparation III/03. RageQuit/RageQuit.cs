using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var chuncks = Regex.Matches(input, @"(\D+)(\d+)");

            var result = new StringBuilder();
            foreach (Match chunk in chuncks)
            {
                var times = int.Parse(chunk.Groups[2].Value);
                var stringStr = chunk.Groups[1].Value;

                for (int i = 0; i < times; i++)
                {
                    result.Append(stringStr.ToUpper());
                }
            }

            var uniqueSymbolsCount = result.ToString().Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}", uniqueSymbolsCount);
            Console.WriteLine(result.ToString());
        }
    }
}
