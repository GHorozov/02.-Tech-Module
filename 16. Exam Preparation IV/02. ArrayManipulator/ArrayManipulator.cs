using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                var lineParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = lineParams[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(lineParams[1]);

                        array = Exchange(array, index);
                        break;

                    case "max":                     
                    case "min":
                        var minOrMax = command;
                        var evenOrOdd = lineParams[1];

                        MaxOrMinEvenOrOddIndex(array, minOrMax, evenOrOdd);
                        break;

                    case "first":                 
                    case "last":
                        var firstOrLast = command;
                        var count = int.Parse(lineParams[1]);
                        var evenOrOddState = lineParams[2];

                        FirstOrLastEvenOrOdd(array, firstOrLast, count, evenOrOddState);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void FirstOrLastEvenOrOdd(List<int> array, string firstOrLast, int count, string evenOrOddState)
        {
            var evenOrOdd = evenOrOddState == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(x => x % 2 == evenOrOdd).ToArray();

            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");return;
            }

            int[] resultElements ;
            if (firstOrLast == "first")
            {
                resultElements = evenOrOddElements.Take(count).ToArray();            
            }
            else
            {
                resultElements = evenOrOddElements.Reverse().Take(count).Reverse().ToArray();             
            }
            Console.WriteLine("[{0}]", string.Join(", ", resultElements));
        }

        private static void MaxOrMinEvenOrOddIndex(List<int> array, string minOrMax, string evenOrOdd)
        {
            var evenOrOddState = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(x => x % 2 == evenOrOddState);

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxOrMinElement = minOrMax == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();

            var indexOfElement = array.LastIndexOf(maxOrMinElement);

            Console.WriteLine(indexOfElement);
        }

        private static List<int> Exchange(List<int> array, int index)
        {
            var isValid = index >= 0 && index < array.Count;

            if (!isValid)
            {
                Console.WriteLine("Invalid index");
                return array;    
            }

            var leftPart = array.Take(index + 1);
            var rightPart = array.Skip(index + 1);
            var combineArray = rightPart.Concat(leftPart).ToList();

            return combineArray; 
        }
    }
}
