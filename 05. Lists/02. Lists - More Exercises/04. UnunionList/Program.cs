using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            var addedList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var currentSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < currentSeq.Count; j++)
                {
                    if (primalList.Contains(currentSeq[j]))
                    {
                        primalList.RemoveAll(x => x == currentSeq[j]);
                    }
                    else
                    {
                        primalList.Add(currentSeq[j]);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList.Distinct()));
        }
    }
}
