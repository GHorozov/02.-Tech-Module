using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rootNameFileNameSize = new Dictionary<string, Dictionary<string,long>>();
            var fileNameExtension = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                var rootName = inputLine[0];
                var fileExtSize = inputLine[inputLine.Length - 1].Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                var fileName = fileExtSize[0].Trim(' ');
                var extension = fileName.Split('.').Last();
                var size = long.Parse(fileExtSize[fileExtSize.Length - 1]);

                if (!rootNameFileNameSize.ContainsKey(rootName))
                {
                    rootNameFileNameSize[rootName] = new Dictionary<string, long>();
                }

                rootNameFileNameSize[rootName][fileName] = size;
                fileNameExtension[fileName] = extension;
            }

            var parameters = Console.ReadLine().Split(' ');
            var ext = parameters[0];
            var inRoot = parameters[2];


            var extractedFiles = new Dictionary<string, long>();

            if (rootNameFileNameSize.ContainsKey(inRoot))
            {
                foreach (var file in rootNameFileNameSize[inRoot])
                {
                    if(fileNameExtension[file.Key] == ext)
                    {
                        extractedFiles.Add(file.Key, file.Value);
                    }
                }
            }
            
            if(extractedFiles.Count > 0)
            {
                foreach (var file in extractedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
