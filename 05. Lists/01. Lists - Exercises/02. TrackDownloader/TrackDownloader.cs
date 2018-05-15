using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            var blackListedWords = Console.ReadLine().Split(' ').ToList();
            var filenames = Console.ReadLine();
            var cleanList = new List<string>();
            
            while (!filenames.Equals("end"))
            {
                var countBlacklisted = 0;
                for (int i = 0; i < blackListedWords.Count; i++)
                {
                    if(filenames.Contains(blackListedWords[i]))
                    {
                        countBlacklisted++;
                    }                 
                }
                if(countBlacklisted == 0)
                {
                    cleanList.Add(filenames);
                }

                filenames = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\r\n", cleanList.OrderBy(x => x)));
        }
    }
}
