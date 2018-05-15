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

                if (currentTicket.Length == 20)
                {
                    CheckTicket(currentTicket, isValid);

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        private static void CheckTicket(string currentTicket, bool isValid)
        {
            var leftHalf = currentTicket.Substring(0, 10);
            var rightHalf = currentTicket.Substring(10);

            Regex firstSymbol = new Regex(@"[@]{6,}");
            Regex secondSymbol = new Regex(@"[#]{6,}");
            Regex thirdSymbol = new Regex(@"[$]{6,}");
            Regex fourthSymbol = new Regex(@"[\^]{6,}");
          
            var machesFirst = firstSymbol.IsMatch(leftHalf);
            var machesSecond = secondSymbol.IsMatch(leftHalf);
            var machesThird = thirdSymbol.IsMatch(leftHalf);
            var machesFourth = fourthSymbol.IsMatch(leftHalf);

            if (machesFirst == false && machesSecond == false && machesThird == false && machesFourth == false)
            {
                Console.WriteLine(@"ticket ""{0}"" - no match", currentTicket); return;
            }
            else
            {
                if (firstSymbol.IsMatch(leftHalf))
                {
                    ReturnResult(currentTicket, leftHalf, rightHalf, firstSymbol);
                    return;
                }
                else if (secondSymbol.IsMatch(leftHalf))
                {
                    ReturnResult(currentTicket, leftHalf, rightHalf, secondSymbol);
                    return;
                }
                else if (thirdSymbol.IsMatch(leftHalf))
                {
                    ReturnResult(currentTicket, leftHalf, rightHalf, thirdSymbol);
                    return;
                }
                else if (fourthSymbol.IsMatch(leftHalf))
                {
                    ReturnResult(currentTicket, leftHalf, rightHalf, fourthSymbol);
                    return;
                }
            }

        }

        private static void ReturnResult(string currentTicket, string leftHalf, string rightHalf, Regex currentSymbol)
        {
            var machesLeft = currentSymbol.Matches(leftHalf);
            var machesRight = currentSymbol.Matches(rightHalf);

            var countLeftSide = 0;
            var countRightSide = 0;
            var symbol = string.Empty;
            foreach (Match left in machesLeft)
            {
                countLeftSide = left.Value.Count();
                symbol = left.Value.Substring(0,1);
            }
            foreach (Match right in machesRight)
            {
                countRightSide = right.Value.Count();
            }


            if (countLeftSide == 10 && countRightSide == 10)
            {
                var bothSideMinMatch = Math.Min(countLeftSide, countRightSide);

                Console.WriteLine(@"ticket ""{0}"" - {1}{2} Jackpot!", currentTicket, bothSideMinMatch, symbol);
                return;
            }
            else if (countLeftSide >= 6 && countRightSide >= 6)
            {
                var bothSideMinMatch = Math.Min(countLeftSide, countRightSide);

                Console.WriteLine(@"ticket ""{0}"" - {1}{2}", currentTicket, bothSideMinMatch, symbol);
                return;
            }
            else
            {
                Console.WriteLine(@"ticket ""{0}"" - no match", currentTicket); return;
            }
        }
    
    }
}
