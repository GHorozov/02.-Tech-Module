using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var inputPattern = Console.ReadLine();

            Regex regex = new Regex(Regex.Escape(inputPattern));

            var matches = regex.Matches(inputString);

            while (true)
            {

                if(matches.Count >= 2 && inputPattern.Length > 0)
                {
                    int startIndex = inputString.IndexOf(inputPattern);
                    int lastIndex = inputString.LastIndexOf(inputPattern);

                    inputString = inputString.Remove(lastIndex, inputPattern.Length);
                    inputString = inputString.Remove(startIndex, inputPattern.Length);

                    inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake."); break;
                }

                regex = new Regex(Regex.Escape(inputPattern));
                matches = regex.Matches(inputString);
            }

            Console.WriteLine(inputString);
        }
    }
}
