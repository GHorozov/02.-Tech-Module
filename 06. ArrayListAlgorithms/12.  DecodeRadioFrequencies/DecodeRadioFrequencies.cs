using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');
            var listLeft = new List<char>();
            var listRight = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                var currentLine = array[i].Split('.');
                var leftNum = int.Parse(currentLine[0]);
                var rightNum = int.Parse(currentLine[1]);
                var leftChar = (char)leftNum;
                var rightChar = (char)rightNum;
                listLeft.Add(leftChar);
                listRight.Insert(0, rightChar);
            }

            listLeft.AddRange(listRight);
            var result = new List<char>();
            foreach (var item in listLeft)
            {
                if(item != '\0')
                {
                    result.Add(item);
                }
            }
            
            Console.WriteLine(string.Join("", result));
        }
    }
}
