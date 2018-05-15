using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main()
        {
            var names = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currentName = Console.ReadLine();

                names.Add(currentName);

            }

            Console.WriteLine(string.Join("\r\n", names));
        }
    }
}
