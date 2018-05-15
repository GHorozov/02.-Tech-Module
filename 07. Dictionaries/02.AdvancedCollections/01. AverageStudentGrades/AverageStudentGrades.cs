using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main()
        {
            var students = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine().Split(' ');
                var name = currentLine[0];
                var grade = double.Parse(currentLine[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);
            }


            foreach (var student in students)
            {
                var studentName = student.Key;
                var studentGrades = student.Value.Select(x => string.Format("{0:f2}", x));
                var averageGrade = student.Value.Average();

                Console.WriteLine("{0} -> {1} (avg: {2:f2})", studentName, string.Join(" ", studentGrades), averageGrade);
            }
        }
    }
}
