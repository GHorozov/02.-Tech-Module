using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var command = inputLine.Split(' ');

                switch (command[0])
                {
                    case "reverse":
                        var start = int.Parse(command[2]);
                        var count = int.Parse(command[4]);

                        if (idValid(list, start, count))
                        {
                            if (command[0] == "reverse")
                            {
                                ReverseArray(list, start, count);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        var startSort = int.Parse(command[2]);
                        var countSort = int.Parse(command[4]);

                        if (idValid(list, startSort, countSort))
                        {
                            if (command[0] == "sort")
                            {
                                SortPertOFArray(list, startSort, countSort);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        var rotate = int.Parse(command[1]);

                        if (rotate >= 0)
                        {
                            if (command[0] == "rollLeft")
                            {
                                RollLeftArray(list, rotate);
                            }                      
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }                       
                        break;

                    case "rollRight":
                        var rotateRight = int.Parse(command[1]);

                        if (rotateRight >= 0)
                        {
                            if (command[0] == "rollRight")
                            {
                                RollRightArray(list, rotateRight);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }

        private static bool idValid(List<string> list, int start, int count)
        {
            var result = start >= 0 &&
                start < list.Count &&
                count >= 0 &&
                (start + count) <= list.Count;

            return result;
        }

        private static void RollRightArray(List<string> list, int rotate)
        {
            // I -way

            //var rotations = rotate % list.Count;

            //for (int i = 0; i < rotations; i++)
            //{
            //    var lastElement = list[list.Count - 1];

            //    for (int j = list.Count - 1; j > 0; j--)
            //    {
            //        list[j] = list[j - 1];
            //    }

            //    list[0] = lastElement;
            //}

            // II - way

            var rotations = rotate % list.Count;
            while (true)
            {
                if (rotations <= 0) break;

                var lastElement = list[list.Count - 1];

                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastElement);
                rotations--;
            }
        }

        private static void RollLeftArray(List<string> list, int rotate)
        {
            // I - way

            var rotations = rotate % list.Count;

            for (int i = 0; i < rotations; i++)
            {
                var firstElement = list[0];

                for (int j = 0; j < list.Count-1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count - 1] = firstElement;
            }


            // II - way

            //var rotations = rotate % list.Count;
            //while (true)
            //{
            //    if (rotations <= 0) break;

            //    var firstElement = list.First();

            //    list.Remove(firstElement);
            //    list.Add(firstElement);
            //    rotations--;
            //}
        }

        private static void SortPertOFArray(List<string> list, int start, int count)
        {
            list.Sort(start, count, null);
        }

        private static void ReverseArray(List<string> list, int start, int count)
        {
            list.Reverse(start, count);
        }
    }
}
