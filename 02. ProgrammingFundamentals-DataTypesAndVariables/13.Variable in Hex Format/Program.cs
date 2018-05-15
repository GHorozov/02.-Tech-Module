using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _13.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();

            //First way:
            int numberInHex = 0;
            if (input.StartsWith("0x"))
            {
                numberInHex = Int32.Parse(input.Substring(2), NumberStyles.HexNumber);
            }

            //Second way:
            //int numberInHex = Convert.ToInt32(input, 16);

            Console.WriteLine(numberInHex);

        }
    }
}
