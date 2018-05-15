using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    class JSONStringify
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new List<Student>();

            while(input != "stringify")
            {
                var inputArgs = input.Split(new[] { ' ',':', '-', '>',','}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                var age = inputArgs[1];
                var grades = inputArgs.Skip(2).Select(int.Parse).ToList();

               result.Add( ReadAndAddStudents(name,age,grades));

                input = Console.ReadLine();
            }


            //Print result

            //  I - way
            //string output = string.Empty;

            //output += "[";
            //for (int i = 0; i < result.Count; i++)
            //{
            //    output += "{";
            //    output += $"name:\"{result[i].Name}\",";
            //    output += $"age:{result[i].Age},";
            //    output += $"grades:[{string.Join(", ", result[i].Grades)}]";
            //    output += "}";

            //    if(i < result.Count - 1)
            //    {
            //        output += ",";
            //    }
            //}
            //output += "]";

            //Console.WriteLine(output);


            // II - way
            //var resultString = new StringBuilder(100);

            //resultString.Append("[");
            //for (int i = 0; i < result.Count; i++)
            //{
            //    resultString.Append("{");
            //    resultString.Append($"name:\"{result[i].Name}\",");
            //    resultString.Append($"age:{result[i].Age},");
            //    resultString.Append($"grades:[{string.Join(", ", result[i].Grades)}]");
            //    resultString.Append("}");
            //    if (i < result.Count - 1)
            //    {
            //        resultString.Append(",");
            //    }
            //}
            //resultString.Append("]");

            //Console.WriteLine(resultString);


            // III - way
            Console.WriteLine("["+ string.Join(",", result.Select(x => $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ", x.Grades)}]}}")) +"]");
        }

        private static Student ReadAndAddStudents(string name, string age, List<int> grades)
        {
            var currentStudent = new Student
            {
                Name = name,
                Age = int.Parse(age),
                Grades = grades
            };
            return currentStudent;
        }
    }
}
