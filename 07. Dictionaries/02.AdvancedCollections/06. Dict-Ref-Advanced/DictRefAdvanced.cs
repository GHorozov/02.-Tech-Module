using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main()
        {
            var result = new Dictionary<string, List<int>>();
            var line = Console.ReadLine();
            while(line != "end")
            {
                var currentLine = line.Split(new char[] { ',', ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var name = currentLine[0];
                

                var number = 0;
                if (int.TryParse(currentLine[1], out number))
                {
                    //take all numbers
                    var values = currentLine.Skip(1).Select(int.Parse).ToList();

                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();
                    }

                    result[name].AddRange(values);
                }
                else
                {
                    if (result.ContainsKey(currentLine[1]))
                    {
                        var secondKeyValue = result[currentLine[1]];
                        if (!result.ContainsKey(name))
                        {
                            result[name] = new List<int>();
                        }

                        result[name].AddRange(secondKeyValue);
                    }
                   
                   
                }
              
                line = Console.ReadLine();
            }

            foreach (var name in result)
            {
                Console.WriteLine("{0} === {1}", name.Key, string.Join(", ", name.Value));
            }
        }
    }
}
