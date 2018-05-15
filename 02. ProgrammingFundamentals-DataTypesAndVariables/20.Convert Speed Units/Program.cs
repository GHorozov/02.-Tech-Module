using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            //first way
            //float allHours = hours + (minutes / 60.0f) + (seconds / 3600.0f);
            //float speedKilometersperHour = (distance / 1000.0f) / allHours;
            //float speedMeterPerSecond = ((float)(speedKilometersperHour) / 3.6f);
            //float speedMilesPerHour = (distance / 1609f) / allHours;

            //second way
            float metersInKilometers = distance / 1000.0f;
            float metersInMiles = distance / 1609.0f;
            float allSeconds = (((hours * 60f)*60f) + (minutes*60f)) +seconds;
            float allHours = allSeconds / 3600;

            float speedMeterPerSecond = distance / allSeconds;
            float speedKilometersperHour = metersInKilometers / allHours;
            float speedMilesPerHour = metersInMiles / allHours;

            Console.WriteLine("{0}\n{1}\n{2}", speedMeterPerSecond, speedKilometersperHour, speedMilesPerHour);
        }
    }
}
