using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterExtensions
{
    class FilterExtensions
    {
        static void Main()
        {
            var input = Console.ReadLine();

            string[] fileNames = Directory.GetFiles("input");


            foreach (var file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);

                if(fileInfo.Extension == input)
                {
                    Console.WriteLine(fileInfo.Name);
                }
            }
        }
    }
}
