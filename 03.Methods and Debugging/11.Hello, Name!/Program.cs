using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
        }

        private static void GetName(string someName)
        {
            Console.WriteLine("Hello, {0}!", someName);         
        }

    }
}
