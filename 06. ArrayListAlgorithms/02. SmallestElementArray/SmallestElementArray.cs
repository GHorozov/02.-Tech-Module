using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementArray
{
    class SmallestElementArray
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var smallestNum = int.MaxValue; 
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] < smallestNum)
                {
                    smallestNum = list[i];
                }
            }

            Console.WriteLine(smallestNum);
        }
    }
}
