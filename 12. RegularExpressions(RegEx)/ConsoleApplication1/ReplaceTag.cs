using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while(text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*)<\/a>";
                var regex = new Regex(pattern);

                var replacement = "[URL href=$1]$2[/URL]";
                var result = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(result);

                text = Console.ReadLine();
            }

           
        }
    }
}
