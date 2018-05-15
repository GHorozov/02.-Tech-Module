using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main()
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var players = Console.ReadLine().Split(' ');
            var currentPosition = 0;
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    currentPosition = i; break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                var currentPlayer = players[i].Split(',');
                var power = int.Parse(currentPlayer[0]);
                var direction = currentPlayer[1];             

                if (direction == "Right")
                {
                    while (power > 0)
                    {
                        currentPosition++;
                        power--;
                        if (currentPosition > cylinder.Length - 1)
                            currentPosition = 0;
                    }

                }
                else if (direction == "Left")
                {
                    while (power > 0)
                    {
                        currentPosition--;
                        power--;
                        if (currentPosition < 0)
                            currentPosition = cylinder.Length - 1;
                    }
                }

                if (currentPosition == 2)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    return;
                }
                currentPosition++;
                //Add two checks if current position is outside bounds of array.
                if (currentPosition < 0)
                    currentPosition = cylinder.Length - 1;
                if (currentPosition > cylinder.Length - 1)
                    currentPosition = 0;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}
