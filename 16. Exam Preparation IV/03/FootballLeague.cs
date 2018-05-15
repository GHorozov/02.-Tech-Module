using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class Score
    {
        public decimal Points { get; set; }
        public decimal Goals { get; set; }
    }
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine()); // escape key before using it.

            var pattern = $@"^.*(?:{key})(?<teamA>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<teamB>[a-zA-Z]*)(?:{key}).* (?<scoreA>\d+)\:(?<scoreB>\d+).*$";

            var teamScore = new Dictionary<string, Score>();

            var inputLine = Console.ReadLine();       
            while(inputLine != "final")
            {
                var match = Regex.Match(inputLine, pattern);

                if (!match.Success)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var teamA = new string(match.Groups["teamA"].Value.ToUpper().Reverse().ToArray());
                var teamB = new string(match.Groups["teamB"].Value.ToUpper().Reverse().ToArray());
                var scoreA = int.Parse(match.Groups["scoreA"].Value);
                var scoreB = int.Parse(match.Groups["scoreB"].Value);


                if (!teamScore.ContainsKey(teamA))
                {
                    teamScore[teamA] = new Score();
                }
                if (!teamScore.ContainsKey(teamB))
                {
                    teamScore[teamB] = new Score();
                }


                if(scoreA > scoreB)
                {
                    teamScore[teamA].Points += 3;
                }
                else if(scoreA == scoreB)
                {
                    teamScore[teamA].Points++;
                    teamScore[teamB].Points++;
                }
                else
                {
                    teamScore[teamB].Points += 3;
                }

                teamScore[teamA].Goals += scoreA;
                teamScore[teamB].Goals += scoreB;

                inputLine = Console.ReadLine();
            }

            var place = 1;
            Console.WriteLine("League standings:");
            foreach (var team in teamScore.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}. {1} {2}", place++, team.Key, team.Value.Points);
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamScore.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value.Goals);
            }
        }
    }
}
