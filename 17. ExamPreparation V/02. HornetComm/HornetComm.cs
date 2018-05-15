using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var messages = new List<string>();
            var broadCasts = new List<string>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Hornet is Green") break;

                var patternMessage = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
                var patternBroadCast = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";
                var isValidMessage = Regex.Match(line, patternMessage);
                var isValidBroadCast = Regex.Match(line, patternBroadCast);

                if (!isValidMessage.Success && !isValidBroadCast.Success)
                {
                    continue;
                }

                if (isValidMessage.Success)
                {
                    var recepientCode = new string(isValidMessage.Groups[1].Value.Reverse().ToArray());
                    var currentMessage = isValidMessage.Groups[2].Value;

                    messages.Add($"{recepientCode} -> {currentMessage}");
                }
                else if (isValidBroadCast.Success)
                {
                    var currentMessage = isValidBroadCast.Groups[1].Value;
                    var frequency = isValidBroadCast.Groups[2].Value;

                    var proccessFrequency = ProccessLetters(frequency);

                    broadCasts.Add($"{proccessFrequency} -> {currentMessage}");
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadCasts.Any())
            {
                Console.WriteLine(string.Join("\n", broadCasts));
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                Console.WriteLine(string.Join("\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static string ProccessLetters(string frequency)
        {
            var result = string.Empty;
            for (int i = 0; i < frequency.Length; i++)
            {
                var symbol = (int)(frequency[i]);
                if (symbol >= 97 && symbol <= 122)
                {
                    result += frequency[i].ToString().ToUpper();
                }
                else if(symbol <= 90 && symbol >= 65)
                {
                    result += frequency[i].ToString().ToLower();
                }
                else
                {
                    result += frequency[i];
                }
            }

            return result;
        }
    }
}
