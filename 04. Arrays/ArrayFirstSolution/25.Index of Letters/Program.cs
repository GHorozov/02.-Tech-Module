using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[26];          
            //write letters a-z to array
            //I-way
            for (int i = 0; i < 26; i++)
            {
                input[i]= char.ToLower(Convert.ToChar(i+65));
            }
            //II-way
            // char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string word = Console.ReadLine();
            for (int i = 0; i < word.Length ; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if(word[i] == input[j])
                    {
                        Console.WriteLine("{0} -> {1}", word[i], j); break;
                    }
                }
                
            }
        }
    }
}
