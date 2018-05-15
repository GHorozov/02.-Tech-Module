using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    class Insertion
    {
        static void Main()
        {
            var listLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                var firstDigit = int.Parse(command[0].ToString());
                var convertedNum = int.Parse(command);

                listLine.Insert(firstDigit, convertedNum);
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listLine));
        }
    }
}
