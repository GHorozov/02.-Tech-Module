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
            var legionTypeCount = new Dictionary<string, Dictionary<string, long>>();
            var legionActivity = new Dictionary<string, long>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = long.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var soldierCount = long.Parse(line[3]);

                if (!legionTypeCount.ContainsKey(legionName))
                {
                    legionTypeCount[legionName] = new Dictionary<string, long>();
                }
                if (!legionTypeCount[legionName].ContainsKey(soldierType))
                {
                    legionTypeCount[legionName][soldierType] = 0;
                }

                legionTypeCount[legionName][soldierType] += soldierCount;

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }
            }

            var input = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            if (input.Length == 1)
            {
                var inputSoldierType = input[0];

                foreach (var legion in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionTypeCount[legion.Key].ContainsKey(inputSoldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                var inputActivity = long.Parse(input[0]);
                var inputSoldierType = input[1];

                foreach (var legion in legionTypeCount
                    .Where(x => x.Value.ContainsKey(inputSoldierType))
                    .OrderByDescending(x => x.Value[inputSoldierType]))
                {
                    if (legionActivity[legion.Key] < inputActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionTypeCount[legion.Key][inputSoldierType]}");
                    }
                }
            }
        }
    }
}
