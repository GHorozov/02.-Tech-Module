using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] readTextLines = File.ReadAllLines("text.txt");

            for (int i = 1; i < readTextLines.Length; i+= 2)
            {
                File.AppendAllText("output.txt", readTextLines[i] + Environment.NewLine);
            }
        }
    }
}
