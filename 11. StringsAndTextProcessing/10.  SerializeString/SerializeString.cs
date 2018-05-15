using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var letters = input.ToCharArray();
            var uniqueLetters = new List<char>();
            foreach (var letter in letters.Distinct())
            {
                uniqueLetters.Add(letter);
            }
           
            for (int i = 0; i < uniqueLetters.Count; i++)
            {
                var list = new List<int>();
                var start = -1;
                while ((start = input.IndexOf(uniqueLetters[i], start+1)) != -1)
                {
                    list.Add(start);
                }

                Console.WriteLine("{0}:{1}", uniqueLetters[i], string.Join("/", list));
            }
          
        }
    }
}
