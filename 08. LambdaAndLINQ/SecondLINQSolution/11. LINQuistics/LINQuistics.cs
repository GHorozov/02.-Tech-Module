using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQuistics
{
    class LINQuistics
    {
        static void Main()
        {
            var collections = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine().Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "exit")
            {
                if (input.Count > 1)
                {
                    var currentColectionKey = input[0];
                    var currentMethods = input.GetRange(1, input.Count - 1);

                    if (!collections.ContainsKey(currentColectionKey))
                    {
                        collections[currentColectionKey] = new HashSet<string>();
                    }

                    foreach (var method in currentMethods)
                    {
                        collections[currentColectionKey].Add(method);
                    }
                }
                else
                {
                    var n = 0;
                    if(int.TryParse(input[0], out n))
                    {
                        //First orderByDescending collection by count of methods, take first(biggest count), select all methods in this collection and make them to list. 
                        var collectionMethods = collections
                            .OrderByDescending(x => x.Value.Count)
                            .Take(1)
                            .SelectMany(x => x.Value)
                            .ToList();
                        
                        //Go through each method in list with methods order them by lenght(from shorter to longest) and take first n methods. 
                        foreach (var method in collectionMethods.OrderBy(x => x.Length).Take(n))
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                    else
                    {
                        var currentCollection = input[0];

                        if (collections.ContainsKey(currentCollection))
                        {
                            //Order methods byDescending by their lenght and then orderByDescending by count of unique symbols in their names.
                            foreach (var method in collections[currentCollection].OrderByDescending(x => x.Length).ThenByDescending(x => x.Distinct().Count()))
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var methodSelection = Console.ReadLine().Split().ToList();

            if( methodSelection[1] == "all")
            {
                var methodToContain = methodSelection[0];
                //OrderByDescending collection by methods count(biggest count first), then again by descending by methods with shortest lenght first.  
                foreach (var collection in collections.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    if (collection.Value.Contains(methodToContain))
                    {
                        Console.WriteLine(collection.Key);
                        foreach (var method in collection.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
            }
            else
            {
                var methodToContain = methodSelection[0];

                //The same as above.
                foreach (var collection in collections.OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    if (collection.Value.Contains(methodToContain))
                    {
                        Console.WriteLine(collection.Key);
                    }
                }
            }
        }
    }
}
