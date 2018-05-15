using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RoliTheCoder
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var result = new List<Event>();
            var eventByid = new Dictionary<int, Event>();

            while (true)
            {
                var currentLine = Console.ReadLine();

                if (currentLine == "Time for Code") break;

                var lineParts = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var id = 0;

                if (!int.TryParse(lineParts[0], out id))
                {
                    continue;
                }

                var eventName = string.Empty;
                if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();

                if (lineParts.Length > 2)
                {
                    participants = lineParts.Skip(2).ToList();
                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventByid.ContainsKey(id))
                {
                    if (eventByid[id].Name == eventName)
                    {
                        foreach (var participant in participants)
                        {
                            if (!eventByid[id].Participants.Contains(participant))
                            {
                                eventByid[id].Participants.Add(participant);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = id,
                        Name = eventName,
                        Participants = participants
                    };

                    result.Add(newEvent);

                    eventByid.Add(id, newEvent);
                }


            }

            var sortedEvents = result
                .OrderByDescending(p => p.Participants.Count)
                .ThenBy(n => n.Name);


            foreach (var ev in sortedEvents)
            {
                var distinctParticipants = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
                foreach (var participant in distinctParticipants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
