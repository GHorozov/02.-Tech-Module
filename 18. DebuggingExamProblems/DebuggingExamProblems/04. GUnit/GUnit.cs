using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUnit
{
    class GUnit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            Regex validation =new Regex(@"^([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+)$");

            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            while (inputLine != "It's testing time!")
            {            
                if (validation.IsMatch(inputLine))
                {
                    Match match = validation.Match(inputLine);
                    
                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var testName = match.Groups[3].Value;


                    if (!dictionary.ContainsKey(className))
                    {
                        dictionary[className] = new Dictionary<string, List<string>>();
                    }
                    if (!dictionary[className].ContainsKey(methodName))
                    {
                        dictionary[className][methodName] = new List<string>();
                    }

                    if (!dictionary[className][methodName].Contains(testName))
                    {
                        dictionary[className][methodName].Add(testName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            //Sort dictionary by descending and order them by sum of count in every list of strings, then order methods by method count  and  finally  order clasees alfabetically.
            var sortedClasses= dictionary
                .OrderByDescending(c => c.Value.Values.Sum(y => y.Count))
                .ThenBy(c => c.Value.Count)
                .ThenBy(c => c.Key, StringComparer.Ordinal)
                .ToDictionary(c => c.Key, c => c.Value);

            foreach (var eachClass in sortedClasses)       
            {
                Console.WriteLine($"{eachClass.Key}:");

                //Sort methods by descending  by count of each method then all methods alfabetically.
                var sortedMethods= eachClass.Value
                    .OrderByDescending(m => m.Value.Count)
                    .ThenBy(m => m.Key, StringComparer.Ordinal)
                    .ToDictionary(m => m.Key, m => m.Value);

                foreach (var method in sortedMethods)
                {
                    Console.WriteLine($"##{method.Key}");

                    //Sort tess by lenght of their names and then alfabetically.
                    var sortedTests = method.Value
                        .OrderBy(t => t.Length)
                        .ThenBy(t => t, StringComparer.Ordinal)
                        .ToList();

                    //StringComparer.Ordinal help for correct sort.
                    foreach (var test in sortedTests)
                    {
                        Console.WriteLine($"####{test}");
                    }
                }
            }
        }
    }
}
