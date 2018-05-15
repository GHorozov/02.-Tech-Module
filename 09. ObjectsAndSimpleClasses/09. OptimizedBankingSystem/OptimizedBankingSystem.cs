using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

    }
    class OptimizedBankingSystem
    {
        static void Main()
        {
            var resultList = new List<BankAccount>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                resultList.Add(ReadCurrentLine(line));

                line = Console.ReadLine();
            }

            var orderResultList = resultList.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList();

            foreach (var result in orderResultList)
            {
                Console.WriteLine("{0} -> {1} ({2})", result.Name, result.Balance, result.Bank);
            }
        }

        private static BankAccount ReadCurrentLine(string line)
        {
            var input = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bank = new BankAccount
            {
                Name = input[1].Trim(),
                Bank = input[0].Trim(),
                Balance = decimal.Parse(input[2].Trim())
            };

            return bank;
        }
    }
}
