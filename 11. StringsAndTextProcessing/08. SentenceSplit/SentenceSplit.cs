using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            // I - way
            //var result = string.Join(", ", sentence.Split(new[] { delimiter }, StringSplitOptions.None));
            //Console.Write("[");
            //Console.Write(result);
            //Console.WriteLine("]");


            // II - way
            var delim = delimiter.Take(2).ToArray();
            var word = string.Join("",delim);
            var result = sentence.Replace(word, ", ");

            Console.WriteLine("[" + result + "]");
        }
    }
}
