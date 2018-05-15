using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var lineArgs = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var key = lineArgs[0];

                if (key != "flatten")
                {
                    var innerKey = lineArgs[1];
                    var innerValue = lineArgs[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var Key = lineArgs[1];
                    //Replace dictionary[key] with new dictionary with changed key and value.This is posible because .ToDictionaty actually makes new dictionary.
                    dictionary[Key] = dictionary[Key].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                line = Console.ReadLine();
            }

            //order dictionary by keys lenght and makes new dictionary orderedDictionary.
            var orderedDictionary = dictionary.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine("{0}", entry.Key);

                var orderedInnerDictionary = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues= entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var orderCouter = 0;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    orderCouter++;
                    Console.WriteLine("{0}. {1} - {2}",orderCouter, innerEntry.Key, innerEntry.Value);
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    orderCouter++;
                    Console.WriteLine("{0}. {1}",orderCouter, flattenedEntry.Key);
                }
            }
        }
    }
}
