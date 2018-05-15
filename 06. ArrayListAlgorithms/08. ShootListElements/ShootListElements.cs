using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class ShootListElements
    {
        static void Main()
        {
            var command = Console.ReadLine();

            var list = new List<int>();
            var lastShot = 0;
            while (!command.Equals("stop"))
            {         
                //checks whether command is integer
                var num = 0;
                var isInteger = int.TryParse(command, out num);

                if (isInteger == true)
                {
                    list.Insert(0, int.Parse(command));
                }
                else if (command == "bang")
                {                   
                    if (list.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastShot); return;
                    }
                    if (list.Count == 1)
                    {
                        lastShot = list[0];
                        list.Remove(list[0]);
                        Console.WriteLine("shot {0}", lastShot);
                        command = Console.ReadLine();
                        continue;
                    }
                    var listSum = list.Sum();
                    var listCount = list.Count;
                    var average = (double)listSum / (double)listCount;
                    var firstSmallerElement = list.Where(x => x < average).First();
                    list.Remove(firstSmallerElement);
                    Console.WriteLine("shot {0}", firstSmallerElement);
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            if (list.Count == 0)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastShot);
            }
            else if (list.Count > 0)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", list));
            }

        }
    }
}
