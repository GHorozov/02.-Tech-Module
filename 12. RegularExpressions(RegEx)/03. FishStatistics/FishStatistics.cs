using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var fishes = Regex.Matches(input, @"(>*)(?:<)(\(+)('|x|-)(?:>)");
            var count = 1;

            if(fishes.Count == 0)
            {
                Console.WriteLine("No fish found."); return;
            }
            foreach (Match fish in fishes)
            {
                var tail = fish.Groups[1].Length;
                var body = fish.Groups[2].Length;
                var eye = fish.Groups[3].Value;
                Console.WriteLine("Fish {0}: {1}", count, fish);
                
                //tail
                if(tail > 5)
                {
                    Console.WriteLine(" Tail type: Long ({0} cm)", (tail * 2));
                }
                else if (tail > 1)
                {
                    Console.WriteLine(" Tail type: Medium ({0} cm)", (tail * 2));
                }
                else if(tail == 1)
                {
                    Console.WriteLine(" Tail type: Short ({0} cm)", 2);
                }
                else
                {
                    Console.WriteLine(" Tail type: None");
                }

                // body
                if(body > 10)
                {
                    Console.WriteLine(" Body type: Long ({0} cm)", body * 2);
                }
                else if(body > 5)
                {
                    Console.WriteLine(" Body type: Medium ({0} cm)", body * 2);
                }
                else
                {
                    Console.WriteLine(" Body type: Short ({0} cm)", body * 2);
                }

                //eye
                if(eye.Equals("'"))
                {
                    Console.WriteLine(" Status: Awake");
                }
                else if (eye.Equals("-"))
                {
                    Console.WriteLine(" Status: Asleep");
                }
                else if (eye.Equals("x"))
                {
                    Console.WriteLine(" Status: Dead");
                }

                count++;
            }
        }
    }
}
