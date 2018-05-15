using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<leftPart>\d*)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]+)?$";
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Over!") break;
                var number = int.Parse(Console.ReadLine());

                var match = Regex.Match(line, pattern);

                if (!match.Success)
                {
                    continue;
                }

                var leftPart = match.Groups["leftPart"].Value;
                var message = match.Groups["message"].Value;
                var rightPart = match.Groups["rightPart"].Value;

                if(message.Length != number)
                {
                    continue;
                }

                var leftAndRight = leftPart+rightPart;

                var result = string.Empty;
                foreach (var symbol in leftAndRight)
                {
                    var indexNum = 0;
                    if(int.TryParse(symbol.ToString(), out indexNum))
                    {
                        if (indexNum >= 0 && indexNum < message.Length)
                        {
                            result += message[indexNum];
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                    else
                    {
                        result += " ";
                    }
                }

                Console.WriteLine($"{message} == {result}");
            }
        }
    }
}
