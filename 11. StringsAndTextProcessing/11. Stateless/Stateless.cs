using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                var firstLine = Console.ReadLine();
                if (firstLine == "collapse") break;
                var secondLine = Console.ReadLine();
 
                while (true)
                {
                    var found = firstLine.IndexOf(secondLine);
                    if(found != -1)
                    {
                        firstLine = firstLine.Replace(secondLine, string.Empty);
                    }

                   
                    //remove first and last letter
                    if (secondLine.Length > 1)
                    {
                        secondLine = secondLine.Remove(0, 1);
                        secondLine = secondLine.Remove(secondLine.Length - 1);
                    }
                    else
                    {
                        secondLine = secondLine.Remove(0, 1);
                    }

                    //checks
                    if (firstLine.Length == 0) break;
                    if (secondLine.Length == 0) break;
                }

                //print
                if (firstLine.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(firstLine.Trim(' '));
                }
        }
    }
}
}
