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
            var distancePer1000WingFlaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());
            // 100 wingFlaps = 1 sec.

            var distance = (wingFlaps / 1000) * distancePer1000WingFlaps;
            var timeMainFlight = wingFlaps / 100;
            var stopTime = (wingFlaps / endurance) * 5;
            var time = timeMainFlight + stopTime;

            Console.WriteLine("{0:f2} m.",distance);
            Console.WriteLine("{0} s.", time);
        }
    }
}
