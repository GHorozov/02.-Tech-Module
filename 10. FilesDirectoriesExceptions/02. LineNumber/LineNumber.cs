using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumber
{
    class LineNumber
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("text.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", i + 1 + "." + text[i] + Environment.NewLine);
            }
        }
    }
}
