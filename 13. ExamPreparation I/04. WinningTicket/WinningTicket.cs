using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            var ticket = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var winningSymbols = new char[4] { '@', '#', '$', '^' };
            var isValid = false;
            for (int i = 0; i < ticket.Length; i++)
            {
                var currentTicket = ticket[i].TrimStart(' ').TrimEnd(' ');
                isValid = false;
                foreach (var symbol in winningSymbols)
                {
                    if (currentTicket.Contains(symbol))
                    {
                        isValid = true; break;
                    }
                }

                if(currentTicket.Length == 20)
                {
                    CheckTicket(currentTicket, isValid);

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        public static void CheckTicket(string currentTicket, bool isValid)
        {
            var leftHalf = currentTicket.Substring(0, 10);
            var rightHalf = currentTicket.Substring(10);

            Regex firstSymbol = new Regex(@"@");
            Regex secondSymbol = new Regex(@"#");
            Regex thirdSymbol = new Regex(@"\$");
            Regex fourthSymbol = new Regex(@"\^");

            var machesFirst = firstSymbol.Matches(leftHalf);
            var machesSecond = secondSymbol.Matches(leftHalf);
            var machesThird = thirdSymbol.Matches(leftHalf);
            var machesFourth = fourthSymbol.Matches(leftHalf);

            var one = machesFirst.Count;
            var two = machesSecond.Count;
            var three = machesThird.Count;
            var four = machesFourth.Count;

            var countArray = new int[] { one, two, three, four };
            var maxCountSymbol = countArray.Max();

            if (isValid == false || maxCountSymbol == 0)
            {
                Console.WriteLine(@"ticket ""{0}"" - no match", currentTicket); return;
            }
            else if (firstSymbol.IsMatch(leftHalf) && one == maxCountSymbol)
            {
                ReturnResult(currentTicket, leftHalf, rightHalf, firstSymbol, machesFirst, isValid);
                return;
            }
            else if (secondSymbol.IsMatch(leftHalf) && two == maxCountSymbol)
            {
                ReturnResult(currentTicket, leftHalf, rightHalf, secondSymbol, machesSecond, isValid);
                return;
            }
            else if (thirdSymbol.IsMatch(leftHalf) && three == maxCountSymbol)
            {
                ReturnResult(currentTicket, leftHalf, rightHalf, thirdSymbol, machesThird, isValid);
                return;
            }
            else if (fourthSymbol.IsMatch(leftHalf) && four == maxCountSymbol)
            {
                ReturnResult(currentTicket, leftHalf, rightHalf, fourthSymbol, machesFourth, isValid);
                return;
            }
           
        }

        private static void ReturnResult(string currentTicket, string leftHalf, string rightHalf, Regex currentSymbol, MatchCollection currentMatches, bool isValid)
        {
            var machesLeft = currentSymbol.Matches(leftHalf);
            var machesRight = currentSymbol.Matches(rightHalf);

        
            if(machesLeft.Count == 10 && machesRight.Count == 10)
            {
                var bothSideMinMatch = Math.Min(machesLeft.Count, machesRight.Count);

                Console.WriteLine(@"ticket ""{0}"" - {1}{2} Jackpot!", currentTicket, bothSideMinMatch, string.Join("", currentMatches[0]));
                return;
            }
            else if (machesLeft.Count >= 6 && machesRight.Count >= 6)
            {
                var bothSideMinMatch = Math.Min(machesLeft.Count, machesRight.Count);

                Console.WriteLine(@"ticket ""{0}"" - {1}{2}", currentTicket, bothSideMinMatch, string.Join("", currentMatches[0]));
                return;
            }
            else
            {
                Console.WriteLine(@"ticket ""{0}"" - no match", currentTicket); return;
            }
        }
    }
}
