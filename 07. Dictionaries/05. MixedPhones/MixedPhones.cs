using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, long>();
            var line = Console.ReadLine();

            while(line != "Over")
            {
                var lineArgs = line.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var first = lineArgs[0];
                var second = lineArgs[lineArgs.Length - 1];

                var number = 0L;
                if(long.TryParse(first, out number))
                {
                    phonebook[second] = number;
                }
                else
                {
                    var phone = long.Parse(second);
                    phonebook[first] = phone;
                }

                line = Console.ReadLine();
            }

            foreach (var pair in phonebook)
            {
                var name = pair.Key;
                var phoneNumber = pair.Value;
                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
