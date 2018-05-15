using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HappinessIndex
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var happyEmoticons = Regex.Matches(input, @"((\:\))|(\:D)|(\;\))|(:\*)|(:\])|(;\])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;))");
            var sadEmoticons = Regex.Matches(input, @"((:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(\]:)|(];))");

            var countHappy = happyEmoticons.Count;
            var countSad = sadEmoticons.Count;
            var hapinessIndex = ((double)(happyEmoticons.Count) / sadEmoticons.Count);
            hapinessIndex = Math.Round(hapinessIndex, 2);

            if(hapinessIndex >= 2)
            {
                Console.WriteLine("Happiness index: {0:f2} :D", hapinessIndex);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", countHappy, countSad);
            }
            else if(hapinessIndex > 1)
            {
                Console.WriteLine("Happiness index: {0:f2} :)", hapinessIndex);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", countHappy, countSad);
            }
            else if(hapinessIndex == 1)
            {
                Console.WriteLine("Happiness index: {0:f2} :|", hapinessIndex);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", countHappy, countSad);
            }
            else if(hapinessIndex < 1)
            {
                Console.WriteLine("Happiness index: {0:f2} :(", hapinessIndex);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", countHappy, countSad);
            }
            
        }
    }
}
