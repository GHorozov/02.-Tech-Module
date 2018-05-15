using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string action = commands[0];
                if (action == "print") break;
                if (action == "add")
                {
                    Add(input, commands);
                }
                else if (action == "addMany")
                {
                    AddMany(input, commands);
                }
                else if (action == "contains")
                {
                    IsContain(input, commands);
                }
                else if (action == "remove")
                {
                    Remove(input, commands);
                }
                else if (action == "shift")
                {
                    Shift(input, commands);
                }
                else if (action == "sumPairs")
                {
                    input = SumPairs(input);
                }
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");

        }

        private static void Add(List<int> input, string[] commands)
        {
            int index = int.Parse(commands[1]);
            int element = int.Parse(commands[2]);
            input.Insert(index, element);
        }

        private static void AddMany(List<int> input, string[] commands)
        {
            int index = int.Parse(commands[1]);

            for (int i = commands.Length - 1; i >= 2; i--)
            {
                int element = int.Parse(commands[i]);
                input.Insert(index, element);
            }
        }

        private static void IsContain(List<int> input, string[] commands)
        {
            int checkNumber = int.Parse(commands[1]);
            int count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (checkNumber == input[i])
                {
                    Console.WriteLine(i);
                    count++;
                    break;
                }

            }
            if (count <= 0)
            {
                Console.WriteLine("-1");
            }
        }

        private static void Remove(List<int> input, string[] commands)
        {
            int index = int.Parse(commands[1]);
            input.RemoveAt(index);
        }

        private static void Shift(List<int> input, string[] commands)
        {

            int numberOfPositions = int.Parse(commands[1]);
            while (numberOfPositions > 0)
            {
                int first = input[0];
                input.RemoveAt(0);
                input.Add(first);
                numberOfPositions--;
            }
        }

        private static List<int> SumPairs(List<int> input)
        {
            List<int> list = new List<int>();

            while (input.Count >= 2)
            {
                list.Add(input[0] + input[1]);
                input.RemoveAt(0);
                input.RemoveAt(0);
            }
            if (input.Count == 1)
            {
                list.Add(input[0]);
            }

            input = list;
            return input;

        }
    }
}
