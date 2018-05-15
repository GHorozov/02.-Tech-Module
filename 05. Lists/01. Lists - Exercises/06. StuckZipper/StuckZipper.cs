using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main()
        {
            var listOne = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var listTwo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            var cleanListOne = new List<int>();
            cleanListOne.AddRange(RemoveDoubleDigitNumbers(listOne));
            var cleanListTwo = new List<int>();
            cleanListTwo.AddRange(RemoveDoubleDigitNumbers(listTwo));

            int minListCount = Math.Min(cleanListOne.Count, cleanListTwo.Count);
            var maxListCount = Math.Max(cleanListOne.Count, cleanListTwo.Count);
            var result = new List<int>();

            if (cleanListOne.Count == 0)
            {
                result = cleanListTwo;
            }
            else if (cleanListTwo.Count == 0)
            {
                result = cleanListOne;
            }
            else
            {
                if (cleanListOne.Count == cleanListTwo.Count)
                {
                    for (int i = 0; i < minListCount; i++)
                    {
                        result.Add(cleanListTwo[i]);
                        result.Add(cleanListOne[i]);
                    }
                }
                else if (cleanListOne.Count > cleanListTwo.Count)
                {
                    for (int i = 0; i < minListCount; i++)
                    {
                        result.Add(cleanListTwo[i]);
                        result.Add(cleanListOne[i]);
                    }
                    result.Add(cleanListOne[cleanListOne.Count - 1]);
                }
                else if (cleanListOne.Count < cleanListTwo.Count)
                {
                    for (int i = 0; i < minListCount; i++)
                    {
                        result.Add(cleanListTwo[i]);
                        result.Add(cleanListOne[i]);
                    }
                    result.Add(cleanListTwo[cleanListTwo.Count - 1]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> RemoveDoubleDigitNumbers(List<int> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                var currentDigit = list[i].ToString().ToCharArray();
                if (currentDigit.Length <= 3)
                {
                    if (currentDigit[0] == '-' && currentDigit.Length > 2)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                    else if(currentDigit[0] != '-' && currentDigit.Length > 1)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
                else if (currentDigit.Length > 3)
                {
                    if (currentDigit[0] == '-' && currentDigit.Length > 4)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                    else if (currentDigit[0] != '-' && currentDigit.Length > 3)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
            }

            return list;
        }
    }
}
