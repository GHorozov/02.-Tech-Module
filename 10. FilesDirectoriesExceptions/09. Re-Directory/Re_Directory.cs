using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Directory
{
    class Re_Directory
    {
        static void Main()
        {
            var inputContent = Directory.GetFiles("input");
            var dirAndFiles = new Dictionary<string, string>();

            foreach (var file in inputContent)
            {
                FileInfo currentFile = new FileInfo(file);

                currentFile.Name.Split('.');
                var ext = currentFile.Extension.Trim('.');
                dirAndFiles.Add(currentFile.Name, ext);
            }

            Directory.CreateDirectory($"output");
            foreach (var file in dirAndFiles)
            {
                if(!Directory.Exists($"output\\{file.Key}"))
                {
                    Directory.CreateDirectory($"output\\{file.Value}s");
                }

                File.Move($"input\\{file.Key}", $"output\\{file.Value}s\\{file.Key}");
            }
            
        }
    }
}
