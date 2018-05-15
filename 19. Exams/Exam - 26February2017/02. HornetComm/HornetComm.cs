using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var broadcast = new List<string>();
            var messages = new List<string>();

            var massagePatern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            var broadcastPatern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";

            var messageRegex = new Regex(massagePatern);
            var broadcastRegex = new Regex(broadcastPatern);

            var line = Console.ReadLine();
            while(line != "Hornet is Green")
            {
             
                if (messageRegex.IsMatch(line)) // massage
                {
                    var match = messageRegex.Match(line); // search for first match in text

                    var code = string.Join("",match.Groups[1].Value.Reverse());
                    var frequency = match.Groups[2].Value;

                    var result = code + " -> " + frequency;

                    messages.Add(result);
                }
                else if(broadcastRegex.IsMatch(line)) //broadcast
                {
                    var match = broadcastRegex.Match(line);

                    var message = match.Groups[1].Value;
                    var beforeChangeQuery = match.Groups[2].Value;
                    var frequency = ChangeLetters(beforeChangeQuery);

                    var result = frequency + " -> " + message;

                    broadcast.Add(result);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if(broadcast.Count() > 0)
            {
                foreach (var pair in broadcast)
                {
                    Console.WriteLine(pair);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count() > 0)
            {
                foreach (var pair in messages)
                {
                    Console.WriteLine(pair);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static string ChangeLetters(string beforeChangeQuery)
        {
            var frequency = "";

            foreach (var currentChar in beforeChangeQuery)
            {
                if (currentChar >= 65 && currentChar <= 90)
                {
                    frequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    frequency += (char)(currentChar - 32);
                }
                else
                {
                    frequency += currentChar;
                }
            }

            return frequency;
        }
    }
}
