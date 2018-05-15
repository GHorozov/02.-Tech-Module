using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main()
        {
            var coordinates = Console.ReadLine().Split(' ');
            var command = Console.ReadLine().Split(' ');

            var targetX = int.Parse(coordinates[0]);
            var targetY = int.Parse(coordinates[1]);

            var x = 0.0;
            var y = 0.0;

            for (int i = 0; i < command.Length; i += 2)
            {
                if (command[i] == "up")
                {
                    y += double.Parse(command[i + 1]);
                }
                else if (command[i] == "down")
                {
                    y -= double.Parse(command[i + 1]);
                }
                else if (command[i] == "left")
                {
                    x -= double.Parse(command[i + 1]);
                }
                else if (command[i] == "right")
                {
                    x += double.Parse(command[i + 1]);
                }

                if (y == targetY && x == targetX)
                {
                    Console.WriteLine("firing at [{0}, {1}]\r\ngot 'em!", x, y);
                    return;
                }
            }

            Console.WriteLine("firing at [{0}, {1}]\r\nbetter luck next time...", x, y);
        }
    }
}
