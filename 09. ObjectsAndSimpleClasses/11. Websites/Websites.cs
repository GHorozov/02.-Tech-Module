using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
    class Websites
    {
        static void Main()
        {
            var listResult = new List<Website>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var lineArgs = line.Split(new char[] { '|', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (lineArgs.Length > 1)
                {
                    var websiteHost = lineArgs[0];
                    var websiteDomain = lineArgs[1];

                    if (lineArgs.Length == 2)
                    {
                        var currentLine = new Website
                        {
                            Host = websiteHost,
                            Domain = websiteDomain
                        };

                        listResult.Add(currentLine);
                    }
                    else
                    {
                        var querry = lineArgs.Skip(2).Select(x => x).ToList();

                        var currentLine = new Website
                        {
                            Host = websiteHost,
                            Domain = websiteDomain,
                            Queries = querry
                        };

                        listResult.Add(currentLine);
                    }
                }
                else
                {
                    continue;
                }

                line = Console.ReadLine();
            }

            foreach (var item in listResult)
            {
                if (item.Queries != null)
                {
                    Console.Write("https://www.{0}.{1}", item.Host, item.Domain);
                    Console.Write("/query?=");
                    var count = 0;

                    for (int i = 0; i < item.Queries.Count(); i++)
                    {
                        count++;

                        Console.Write("[{0}]", item.Queries[i]);
                        if (count != item.Queries.Count())
                        {
                            Console.Write("&");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("https://www.{0}.{1}", item.Host, item.Domain);
                }
            }
        }
    }
}
