using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLContents
{
    class HTMLContents
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");

            var title = string.Empty;
            var bodyParts = new List<string>();

            foreach (var line in lines)
            {
                if (line == "exit") break;

                var lineParts = line.Split(' ');
                var tag = lineParts[0];
                var content = lineParts[1];

                if(tag == "title")
                {
                    title = content;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{content}</{tag}>");
                }
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if(title != string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            //Console.WriteLine(result.ToString().Trim());
            File.WriteAllText("index.html", result.ToString().Trim());
        }
    }
}
