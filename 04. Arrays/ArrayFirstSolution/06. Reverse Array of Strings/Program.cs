﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] numbers = n.Split(' ');
            Array.Reverse(numbers);

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
