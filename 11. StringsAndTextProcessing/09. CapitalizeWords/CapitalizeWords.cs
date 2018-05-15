using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();

            while (input != "end")
            {
                var list = new List<string>();
                var inputParams = input.Split(new char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\',
                                                         '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#',
                                                         '\"', '!' }, StringSplitOptions.RemoveEmptyEntries);

                
                for (int i = 0; i < inputParams.Length; i++)
                {
                    var currentWord = inputParams[i];
                    var wordToCharArray = currentWord.ToCharArray();
                    var firstLetter = wordToCharArray[0].ToString().ToUpper();
                    var restOfTheWord = wordToCharArray.Skip(1);
                    var rest = string.Join("", restOfTheWord).ToLower();

                    var wholeWord = firstLetter + rest;

                    list.Add(wholeWord);
                }
               
                Console.WriteLine(string.Join(", ", list));
                input = Console.ReadLine();
            }

            
        }
    }
}
