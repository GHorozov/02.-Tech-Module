using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var ladyBugsFieldPositionIndex = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new int[size];

            foreach (var ladybugIndex in ladyBugsFieldPositionIndex)
            {
                if (ladybugIndex < 0 || ladybugIndex >= size)
                {
                    continue;
                }

                field[ladybugIndex] = 1;
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentIndexLadybug = int.Parse(commandArgs[0]);
                var direction = commandArgs[1];
                var flyIndex = int.Parse(commandArgs[2]);


                if (currentIndexLadybug < 0 || currentIndexLadybug >= size)
                {
                    continue;
                }

                if (field[currentIndexLadybug] == 0)
                {
                    continue;
                }
                var position = currentIndexLadybug;
                field[currentIndexLadybug] = 0;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyIndex;
                    }
                    else
                    {
                        position -= flyIndex;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }
                    if (field[position] == 1)
                    {
                        continue;
                    }

                    if (field[position] == 0)
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
