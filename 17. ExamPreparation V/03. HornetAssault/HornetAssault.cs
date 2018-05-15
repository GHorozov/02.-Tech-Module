using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornetsPower = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var sumPower = hornetsPower.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (!hornetsPower.Any()) break;

                var currentBeehive = beehives[i];
                if (currentBeehive >= sumPower)
                {
                    beehives[i] = currentBeehive - sumPower;
                    if (beehives[i] < 0)
                    {
                        beehives[i] = 0;
                    }             
                       hornetsPower.RemoveAt(0);                 
                }
                else
                {
                    beehives[i] = 0;
                }
                sumPower = hornetsPower.Sum();
            }


            var result = beehives.Where(x => x > 0).Any() ? string.Join(" ", beehives.Where(x => x != 0)) : string.Join(" ", hornetsPower);
            Console.WriteLine(result);
        }
    }
}
