using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class FilterBase
    {
        static void Main()
        {
            var position = new Dictionary<string, string>();
            var salary = new Dictionary<string, double>();
            var age = new Dictionary<string, int>();

            var line = Console.ReadLine();
            while(line != "filter base")
            {
                var currentLine = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var name = currentLine[0];
                var secondInput = currentLine[1];

                var number = 0;
                var doubleNumber = 0.0;

                if(int.TryParse(secondInput, out number))
                {
                    if (!age.ContainsKey(name))
                    {
                        age[name] = 0;
                    }

                    age[name] += number;
                }
                else if(double.TryParse(secondInput, out doubleNumber))
                {
                    if (!salary.ContainsKey(name))
                    {
                        salary[name] = 0;
                    }

                    salary[name] += doubleNumber;
                }
                else
                {
                    if (!position.ContainsKey(secondInput))
                    {
                        position[name] = string.Empty;
                    }

                    position[name] = secondInput;
                }

                line = Console.ReadLine();
            }

            //Print result
            var command = Console.ReadLine();
            if(command == "Position")
            {
                foreach (var pair in position)
                {
                    var name = pair.Key;
                    var positionName = pair.Value;
                    Console.WriteLine("Name: {0}\nPosition: {1}", name, positionName.Trim());
                    Console.WriteLine("====================");
                }
            }
            else if(command == "Salary")
            {
                foreach (var pair in salary)
                {
                    var name = pair.Key;
                    var salarySum = pair.Value;
                    Console.WriteLine("Name: {0}\nSalary: {1:f2}", name, salarySum);
                    Console.WriteLine("====================");
                }
            }
            else if(command == "Age")
            {
                foreach (var pair in age)
                {
                    var name = pair.Key;
                    var personAge = pair.Value;
                    Console.WriteLine("Name: {0}\nAge: {1}", name, personAge);
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
