using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CriticalBreakpoint
{
    class CriticalBreakpoint
    {
        static void Main(string[] args)
        {
            var inputPoints = Console.ReadLine();
            var lines = new List<string>();
            var allRations = new List<BigInteger>();
            while (inputPoints != "Break it.")
            {
                var point = inputPoints.Split(' ').Select(int.Parse).ToArray();

                var currentLine= "["+ point[0] + ", " + point[1] + ", " + point[2]+ ", "+ point[3]+"]";
                lines.Add(currentLine);

                var currentCriticalPoint = BigInteger.Abs(((long)point[point.Length - 1] + (long)point[point.Length - 2]) - ((long)point[0] + (long)point[1]));

                allRations.Add(currentCriticalPoint);
                inputPoints = Console.ReadLine();
            }

            BigInteger actualCriticalPoint = 0;
            var isNotEqualtoCpAndIsNotEqualToZero = 0;
            for (int i = 0; i < allRations.Count; i++)
            {
                if (allRations[i] != 0)
                {
                    actualCriticalPoint = allRations[i];
                    i++;
                    while (true)
                    {
                        if (i >= allRations.Count) break;

                        if (!(allRations[i] == actualCriticalPoint) && !(allRations[i] == 0))
                        {
                            isNotEqualtoCpAndIsNotEqualToZero++;
                        }
                        i++;
                    }
                }
                if (actualCriticalPoint != 0) break;
            }

            if (isNotEqualtoCpAndIsNotEqualToZero == 0)
            {
                var totalRatio = BigInteger.Pow(actualCriticalPoint, allRations.Count);

                BigInteger formulaResult = 0;
                BigInteger.DivRem(totalRatio, allRations.Count, out formulaResult);
                    
                foreach (var line in lines)
                {
                    Console.WriteLine("Line: {0}", line);
                }
                
                Console.WriteLine("Critical Breakpoint: {0}", formulaResult);
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }

        }
    }
}
