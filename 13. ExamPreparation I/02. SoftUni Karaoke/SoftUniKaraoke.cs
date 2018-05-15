using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            var participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            var result = new Dictionary<string, List<string>>();
            var line = Console.ReadLine();
            while (line != "dawn")
            {
                var lineArgs = line.Split(new string[] { ", " }, StringSplitOptions.None);
                var name = lineArgs[0];
                var song = lineArgs[1];
                var award = lineArgs[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<string>();
                        result[name].Add(award);
                    }
                    else
                    {
                        if (!result[name].Contains(award))
                        {
                            result[name].Add(award);
                        }
                    }

                }

                line = Console.ReadLine();
            }

            if (result.Values.Count() == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var student in result.OrderByDescending(x => x.Value.Count()).ThenBy(p => p.Key))
            {
                Console.WriteLine("{0}: {1} awards", student.Key, student.Value.Count);

                foreach (var award in student.Value.OrderBy(x => x))
                {
                    Console.WriteLine("--{0}", award);
                }
            }
        }
    }
}
