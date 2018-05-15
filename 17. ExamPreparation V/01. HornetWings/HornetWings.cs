using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceinMeter = double.Parse(Console.ReadLine()); //per 1000 m.
            var endurance = int.Parse(Console.ReadLine()); // how many wing flaps before stop for rest.
            //rest for 1 second == 100 wing flaps. 5 sec. == 500 wing flaps.

            var distanceFinal = (wingFlaps / 1000) * distanceinMeter;

            var allFlapsTime= wingFlaps / 100;
            var allStopsForBreakTime = (wingFlaps / endurance) * 5;
            var timeFinal = allFlapsTime + allStopsForBreakTime;

            Console.WriteLine($"{distanceFinal:F2} m.");
            Console.WriteLine($"{timeFinal} s.");
        }
    }
}
