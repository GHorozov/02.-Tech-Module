using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[8] { "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (n >= 0 && n <= 7)
            {
                Console.WriteLine(dayOfWeek[n]);
            }
            else 
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
