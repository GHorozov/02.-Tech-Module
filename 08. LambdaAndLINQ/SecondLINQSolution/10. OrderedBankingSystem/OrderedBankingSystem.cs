using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, decimal>>();
            var line = Console.ReadLine();
            while(line != "end")
            {
                var lineArgs = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = lineArgs[0];
                var account = lineArgs[1];
                var balance = decimal.Parse(lineArgs[2]);

                if(!dictionary.ContainsKey(bank))
                {
                    dictionary[bank] = new Dictionary<string, decimal>();
                }

                if(!dictionary[bank].ContainsKey(account))
                {
                    dictionary[bank][account] = 0m;
                }

                dictionary[bank][account] += balance;

                line = Console.ReadLine();
            }

            foreach (var bank in dictionary.OrderByDescending(x => x.Value.Sum(b => b.Value))
                                           .ThenByDescending(x => x.Value.Max(b => b.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(b => b.Value))
                {
                    var bankName = bank.Key;
                    var accountName = account.Key;
                    var balance = account.Value;

                    Console.WriteLine("{0} -> {1} ({2})",accountName, balance, bankName);
                }
                
            }
        }
    }
}
