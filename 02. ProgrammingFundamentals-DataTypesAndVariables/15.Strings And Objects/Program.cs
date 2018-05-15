using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str2 = "World";
            object obj = str + " " + str2;
            string str3 = (string)obj;
            Console.WriteLine(str3);
        }
    }
}
