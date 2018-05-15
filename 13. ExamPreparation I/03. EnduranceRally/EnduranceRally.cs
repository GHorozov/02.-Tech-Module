using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            var drivers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var trackZones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var checkPoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var reachedZone = 0;
            for (int i = 0; i < drivers.Length; i++)
            {
                var driverName = drivers[i];
                var firstLetter = char.Parse(driverName.Substring(0,1));
                var driverFuel = (double)(firstLetter);

                for (int j = 0; j < trackZones.Length; j++)
                {
                    var currentZone = trackZones[j];

                    if (checkPoints.Contains(j))
                    {
                        driverFuel += currentZone;
                    }
                    else
                    {
                        driverFuel -= currentZone;
                    }

                    if (driverFuel <= 0)
                    {
                        reachedZone = j;
                        break;
                    }
                }

                if (driverFuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driverName, driverFuel);
                }
                else
                {
                    Console.WriteLine("{0} - reached {1}", driverName, reachedZone);
                }
            }
        }
    }
}
