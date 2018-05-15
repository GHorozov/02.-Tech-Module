using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            var pyramids = new List<string>();

            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];
            //take all lines
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            // Go through all lines
            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i];
                
                // Go through all characters
                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentCharacter = currentLine[j];
                    var count = 1;
                    var currentPyramid = string.Empty;

                    // Go through all lines again
                    for (int k = i; k < lines.Length; k++)
                    {
                        var currentLayer = new string(currentCharacter, count);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid+= currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        count += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
