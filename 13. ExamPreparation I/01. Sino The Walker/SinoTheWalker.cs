using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            string leaveTime = Console.ReadLine();
            double numberOfSteps = double.Parse(Console.ReadLine()) % 86400;
            double timeForEachStep = double.Parse(Console.ReadLine()) % 86400;

            double arriveTimeInSeconds = numberOfSteps * timeForEachStep;

            DateTime leaveTimeHMS = DateTime.ParseExact(leaveTime, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime arriveTimeAtHome = leaveTimeHMS.AddSeconds(arriveTimeInSeconds);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", arriveTimeAtHome);
        }
    }
}
