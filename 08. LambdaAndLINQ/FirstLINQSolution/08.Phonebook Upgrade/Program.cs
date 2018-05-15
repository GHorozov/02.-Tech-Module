using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (!commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split();
                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    AddToPhonebook(phonebook, commandArgs);
                }
                else if (command.Equals("S"))
                {
                    PrintFound(phonebook, commandArgs);
                }
                else if (command.Equals("ListAll"))
                {
                    PrintOrderedPhonebook(phonebook);
                }

                commandLine = Console.ReadLine();
            }
        }

        private static void PrintOrderedPhonebook(Dictionary<string, string> phonebook)
        {
            foreach (var pair in phonebook.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        private static void PrintFound(Dictionary<string, string> phonebook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            if (phonebook.ContainsKey(contact))
            {
                Console.WriteLine($"{contact} -> {phonebook[contact]}");
            }
            else
            {
                Console.WriteLine($"Contact {contact} does not exist.");
            }
        }

        private static void AddToPhonebook(Dictionary<string, string> phonebook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            string phone = commandArgs[2];

            phonebook[contact] = phone;
        }
    }
}
