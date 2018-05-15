using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower().Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?' }
                                                , StringSplitOptions.RemoveEmptyEntries);
            var words = text.Where(x => x.Count() < 5).OrderBy(c => c).Distinct().ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
