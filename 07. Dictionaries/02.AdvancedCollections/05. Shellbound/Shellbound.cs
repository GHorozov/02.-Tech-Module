using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main()
        {
            var shells = new Dictionary<string, HashSet<int>>();
            var line = Console.ReadLine();
            while(line != "Aggregate")
            {
                var currentLine = line.Split(' ');
                var shellName = currentLine[0];
                var shellSize = int.Parse(currentLine[1]);

                if(!shells.ContainsKey(shellName))
                {
                    shells[shellName] = new HashSet<int>();
                }

                shells[shellName].Add(shellSize);

                line = Console.ReadLine();
            }

            foreach (var shell in shells)
            {
                var average = shell.Value.Average();
                var sum = shell.Value.Sum();
                var giantShell = Math.Ceiling(sum - average);
                Console.WriteLine("{0} -> {1} ({2})", shell.Key, string.Join(", ", shell.Value), giantShell);
            }
        }
    }
}
