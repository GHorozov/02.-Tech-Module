using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();        
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while(!commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split();
                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    string contact = commandArgs[1];
                    string phone = commandArgs[2];

                    phonebook[contact] = phone;
                }
                else if(command.Equals("S"))
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

                commandLine = Console.ReadLine();
            }
        }
    }
}
