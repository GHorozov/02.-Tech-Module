using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main()
        {
            var dictionaty = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();
            while (line != "lambada")
            {
                var lineArgs = line.Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = lineArgs[0];

                if (key != "dance")
                {
                    var splitInnerKeyValue = lineArgs[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    var innerKey = splitInnerKeyValue[0];
                    var innerValue = splitInnerKeyValue[1];

                    if (!dictionaty.ContainsKey(key))
                    {
                        dictionaty[key] = new Dictionary<string, string>();
                    }
                    if (!dictionaty[key].ContainsKey(innerKey))
                    {
                        dictionaty[key][innerKey] = string.Empty;
                    }

                    dictionaty[key][innerKey] = innerValue;
                }
                else
                {
                    //Access to inner Dictionary and modify value to Double inner key.
                    dictionaty = dictionaty.ToDictionary(x => x.Key, x => x.Value.ToDictionary(y => y.Key, y => y.Key + "." + y.Value));
                }

                line = Console.ReadLine();
            }

            foreach (var name in dictionaty)
            {
                foreach (var innerName in name.Value)
                {
                    Console.WriteLine("{0} => {0}.{1}", name.Key, innerName.Key, innerName.Value);
                }
            }
        }
    }
}
