using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("Test");

            var sumSize = 0l;
            foreach (var file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                sumSize += fileInfo.Length;
            }

            Console.WriteLine("{0} MB", (sumSize /1024 /1024));
        }
    }
}
