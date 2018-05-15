using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<![0-9])(?:([2-9]|10)|(A|K|Q|J))+(S|H|D|C)"; // Look behind and doesn't match element started with 0-9 then match all 2-9 or 10 or J or Q or K or A with one of the colors.
            //var pattern2 = @"(?<![0-9])(([2-9AKQJ]|10))+[SHDC]";
            //var pattern3 = @"(?<![0-9])(([2-9]|10)|(A|K|Q|J))+(S|H|D|C)";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            Console.WriteLine(string.Join(", ", matches.Cast<Match>().Select(x => x.Value).ToArray()));
        }
    }
}
