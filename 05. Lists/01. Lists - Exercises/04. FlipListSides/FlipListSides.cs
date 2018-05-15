using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if(number.Count > 3 && number.Count % 2 == 1)
            {
                for (int i = 1; i < number.Count/2 ; i++)
                {
                    var leftNum = number[i];
                    var rightNum = number[number.Count - (i + 1)];
                    var temp = rightNum;
                    number[number.Count - (i + 1)] = leftNum;
                    number[i] = temp;
                }
            }
            else if(number.Count > 2 && number.Count % 2 == 0)
            {
                for (int i = 1; i < number.Count / 2; i++)
                {
                    var leftNum = number[i];
                    var rightNum = number[number.Count - (i + 1)];
                    var temp = rightNum;
                    number[number.Count - (i + 1)] = leftNum;
                    number[i] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
