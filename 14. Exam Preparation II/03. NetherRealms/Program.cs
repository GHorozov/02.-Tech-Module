using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new List<Demon>();
            foreach (var demon in demons)
            {
                var charSymbols = demon.Where(x => !char.IsDigit(x) && x != '+' && x != '-' && x != '*' && x != '/' && x != '.');

                var health = 0;
                foreach (var symbol in charSymbols)
                {
                    health += symbol;
                }

                var matches = Regex.Matches(demon, @"-?\d+\.?\d*");

                var damage = 0.0;
                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                var actions = demon.Where(x => x == '*' || x == '/');

                foreach (var action in actions)
                {
                    if (action == '*')
                    {
                        damage *= 2;
                    }
                    else if (action == '/')
                    {
                        damage /= 2;
                    }
                }

                var currentDemon = new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                };

                result.Add(currentDemon);
            }

            foreach (var demon in result.Select(x => x).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name.Trim()} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
        }
    }
}
