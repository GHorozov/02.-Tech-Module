using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            string specialNum = nums[0];
            int power = int.Parse(nums[1]);
            
            for (int i = 0; i < input.Count; i++)
            {
                int start = i - power;                
                int stop = i + power;
                if(start < 0)
                {
                    start = 0;
                }
                if(stop > input.Count)
                {
                    stop = input.Count-1;
                }
                if (input[i] == specialNum)
                {
                   while(start <= stop)
                    {
                        input.RemoveAt(start);
                        stop--;
                    }
                    i = -1;
                }
            }
            int sum = 0;
            foreach (var num in input)
            {
                sum += int.Parse(num);
            }
            Console.WriteLine(sum);

        }
    }
}
