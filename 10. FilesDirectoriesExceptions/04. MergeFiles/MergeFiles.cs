using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            var first = File.ReadAllText("first.txt");
            var second = File.ReadAllText("second.txt");

            File.WriteAllText("result.txt", first + Environment.NewLine + second);

        }
    }
}
