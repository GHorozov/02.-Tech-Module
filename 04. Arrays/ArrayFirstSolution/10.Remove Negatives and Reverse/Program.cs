using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrayInput = input.Split(' ');
            List<int> numbers = new List<int>();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                numbers.Add(int.Parse(arrayInput[i]));
            }
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    result.Add(numbers[i]);
                }
            }

            if (result.Any())
            {
                result.Reverse();
                foreach (var element in result)
                {

                    Console.Write(element + " ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
