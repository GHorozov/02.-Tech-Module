using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Batteries
    {
        static void Main()
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var stressTestTime = int.Parse(Console.ReadLine());
            var result = new List<double>();
            result = GetCapacityLeft(capacity, usagePerHour, stressTestTime);

            for (int i = 0; i < result.Count; i++)
            {
                var batteryLifeLeft = result[i];
                if (batteryLifeLeft > 0)
                {
                    var percentStatus = (batteryLifeLeft / capacity[i]) * 100;
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i+1, batteryLifeLeft, percentStatus);
                }
                else
                {
                    var lasted = Math.Ceiling(capacity[i] / usagePerHour[i]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, lasted);
                }
            }
           
        }

        private static List<double> GetCapacityLeft(double[] capacity, double[] usagePerHour, int stressTestTime)
        {
            var result = new List<double>();
            for (int i = 0; i < capacity.Length; i++)
            {
                var currentTest = usagePerHour[i] * stressTestTime;
                var currentCapacity = capacity[i];

                if (currentCapacity >= currentTest)
                {
                    var left = currentCapacity - currentTest;
                    result.Add(left);
                }
                else
                {
                    var left = 0;
                    result.Add(left);
                }
            }

            return result;
        }
    }
}
