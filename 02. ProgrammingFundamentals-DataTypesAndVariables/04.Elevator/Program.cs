using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / p);
            Console.WriteLine(courses);
        }
    }
}
