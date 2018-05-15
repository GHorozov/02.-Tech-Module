using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }


        class Program
    {
        static void Main(string[] args)
        {
            var resultList = new List<Exercise>();
            var line = Console.ReadLine();
            while(line != "go go go")
            {
                var input = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var problemsInput = input[3].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var listProblems = new List<string>();
                for (int i = 0; i < problemsInput.Length; i++)
                {
                    if (problemsInput[i] != "go")
                    {
                        listProblems.Add(problemsInput[i]);
                    }
                    else
                    {
                        break;
                    }

                }
                var ExersiseCurrent = new Exercise
                {
                    Topic = input[0].Trim(' '),
                    CourseName = input[1].Trim(' '),
                    JudgeContestLink = input[2].Trim(' '),
                    Problems = listProblems
                };

                resultList.Add(ExersiseCurrent);
                line = Console.ReadLine();
            }


            //Print
            foreach (var item in resultList)
            {
                Console.WriteLine("Exercises: {0}", item.Topic);
                Console.WriteLine(@"Problems for exercises and homework for the ""{0}"" course @ SoftUni.", item.CourseName);
                Console.WriteLine("Check your solutions here: {0}", item.JudgeContestLink);
                for (int i = 0; i < item.Problems.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, item.Problems[i]);
                }
            }
                    
        }     
    }
}
