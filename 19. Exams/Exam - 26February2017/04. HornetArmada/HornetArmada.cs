using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var legionWithActivity = new Dictionary<string, long>();
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                var lineParts = line.Split(new[] { '=','-', '>',':',' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var lastActivity = long.Parse(lineParts[0]);
                var legionName = lineParts[1];
                var soldierType = lineParts[2];
                var soldierCount = long.Parse(lineParts[3]);

                if (!legionWithActivity.ContainsKey(legionName))
                {
                    legionWithActivity.Add(legionName, lastActivity);
                }

                if (!legionsWithSoldiers.ContainsKey(legionName))
                {
                    legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName].Add(soldierType, 0);
                }

                if (legionWithActivity[legionName] < lastActivity)
                {
                    legionWithActivity[legionName] = lastActivity;
                }

                legionsWithSoldiers[legionName][soldierType] += soldierCount;
            }

            var command = Console.ReadLine().Split('\\');
            
            if (command.Length > 1)
            {
                var activityCommand = long.Parse(command[0]);
                var soldierTypeCommand = command[1];

                foreach (var legionEntry in legionsWithSoldiers
                    .Where(l => l.Value.ContainsKey(soldierTypeCommand))
                    . OrderByDescending(l => l.Value[soldierTypeCommand]))
                {
                    if(legionWithActivity[legionEntry.Key] < activityCommand)
                    {
                        Console.WriteLine($"{legionEntry.Key} -> {legionsWithSoldiers[legionEntry.Key][soldierTypeCommand]}");
                    }
                }

            }
            else
            {
                var soldierTypeCommand = command[0];

                foreach (var legionEntry in legionWithActivity.OrderByDescending(l => l.Value))
                {
                    if(legionsWithSoldiers[legionEntry.Key].ContainsKey(soldierTypeCommand))
                    {
                        Console.WriteLine($"{legionEntry.Value} : {legionEntry.Key}");
                    }
                }
            }


        }
    }
}
