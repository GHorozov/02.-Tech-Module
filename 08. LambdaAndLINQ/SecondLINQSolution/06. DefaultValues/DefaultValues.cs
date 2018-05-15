using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class DefaultValues
    {
        static void Main()
        {
            var data = new Dictionary<string, string>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var lineArgs = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var keyName = lineArgs[0];
                var valueName = lineArgs[1];

                data[keyName] = valueName;

                line = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();
            var notReplaced = data.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);
            var replaced = data.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => defaultValue);


            foreach (var pair in notReplaced)
            {
                Console.WriteLine("{0} <-> {1}", pair.Key, pair.Value);
            }

            foreach (var item in replaced)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }
        }
    }
}
