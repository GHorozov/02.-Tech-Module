using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class ForumTopics
    {
        static void Main()
        {
            var data = new Dictionary<string, HashSet<string>>();
            var line = Console.ReadLine();
            while (line != "filter")
            {
                var currentLine = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = currentLine[0];
                var tags = line.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Skip(1).Select(x => x.ToString()).ToList();


                if (!data.ContainsKey(topic))
                {
                    data[topic] = new HashSet<string>();
                }

                foreach (var item in tags)
                {
                    data[topic].Add(item);
                }

                line = Console.ReadLine();
            }

            var tagsToCheck = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var IsNotContain = false;


            foreach (var topic in data)
            {
                IsNotContain = false;
                for (int i = 0; i < tagsToCheck.Length; i++)
                {
                    if (!topic.Value.Contains(tagsToCheck[i]))
                    {
                        IsNotContain = true; break;
                    }
                }
                if (IsNotContain == true)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0} | {1}", topic.Key, string.Join(", ", topic.Value.Select(x => string.Format("#{0}", x))));
                }
                
            }
        }
    }
}
