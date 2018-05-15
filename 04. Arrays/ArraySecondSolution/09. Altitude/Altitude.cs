using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main()
        {
            var command = Console.ReadLine().Split(' ');
            var altitude = double.Parse(command[0]);

            for (int i = 1; i < command.Length; i += 2)
            {
                if (command[i] == "up")
                {
                    altitude += Math.Abs(double.Parse(command[i + 1]));
                }
                else if(command[i] == "down")
                {
                    altitude -= Math.Abs(double.Parse(command[i + 1]));
                }
               
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }
    }
}
