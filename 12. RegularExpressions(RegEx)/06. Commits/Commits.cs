using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commits
{
    class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public decimal Additions  { get; set; }
        public decimal Deletions { get; set; }
    }
    class Commits
    {
        static void Main(string[] args)
        {
            var lines = Console.ReadLine();
            var gitHub = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();
            while (lines != "git push")
            {
                var isMatch = Regex.IsMatch(lines, @"https:\/\/github.com\/([A-Za-z0-9\-]+)\/([A-Za-z_\-]+)\/commit\/([ABCDEF0-9abcdef]{40}),(.+?),(\d+),(\d+)");
           
                if (isMatch)
                {
                    var match= Regex.Match(lines, @"https:\/\/github.com\/([A-Za-z0-9\-]+)\/([A-Za-z_\-]+)\/commit\/([ABCDEF0-9abcdef]{40}),(.+?),(\d+),(\d+)");
                    var userName = match.Groups[1].Value;
                    var repo = match.Groups[2].Value;
                    var hash = match.Groups[3].Value;
                    var message = match.Groups[4].Value;
                    var additions = match.Groups[5].Value;
                    var deletions = match.Groups[6].Value;

                    var newCommit = new Commit
                    {
                        Hash = hash,
                        Message= message,
                        Additions= decimal.Parse(additions),
                        Deletions = decimal.Parse(deletions)
                    };

                    if (!gitHub.ContainsKey(userName))
                    {
                        gitHub[userName] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!gitHub[userName].ContainsKey(repo))
                    {
                        gitHub[userName][repo] = new List<Commit>();
                    }

                    gitHub[userName][repo].Add(newCommit);
                }

                lines = Console.ReadLine();
            }

            foreach (var user in gitHub)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var repo in user.Value)
                {
                    Console.WriteLine($"    {repo.Key}:");
                    var totalAdditions = repo.Value.Select(x => x.Additions).Sum();
                    var totalDeletions = repo.Value.Select(x => x.Deletions).Sum();
                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine("      commit {0}: {1} ({2} additions, {3} deletions)", commit.Hash, commit.Message, commit.Additions, commit.Deletions);
                    }
                    Console.WriteLine("      Total: {0} additions, {1} deletions", totalAdditions, totalDeletions);
                }
            }
        }
    }
}
