using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main()
        {
            var names = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var command = input.Split(' ');
                var firstElement = command[0];
                var lastElement = command[command.Length - 1];

                var number = 0;
                if(int.TryParse(lastElement, out number))
                {
                    names[firstElement] = number;
                }
                else
                {
                    if (names.ContainsKey(lastElement))
                    {
                        var refValue = names[lastElement];
                        names[firstElement] = refValue;
                    }
                }

               input = Console.ReadLine();
            }

            foreach (var name in names)
            {
  
                Console.WriteLine($"{name.Key} === {name.Value}");
            }
        }
    }
}
