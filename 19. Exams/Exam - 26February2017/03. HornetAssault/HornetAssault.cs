using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
           
            for (int i = 0; i < beehives.Length; i++)
            {

                if (hornets.Count() == 0)
                {
                    break;
                } 

                var currentBeehive = beehives[i];
                var hornetSumPower = (long)hornets.Sum();

                beehives[i] -= hornetSumPower;

                if(currentBeehive >= hornetSumPower)
                {
                    hornets.RemoveAt(0);
                }
               
            }

            var beehivesLeft = new List<long>();
            foreach (var beehive in beehives)
            {
                if(beehive > 0)
                {
                    beehivesLeft.Add(beehive);
                }
            }

            if(beehivesLeft.Any())
            {
                Console.WriteLine(string.Join(" ", beehivesLeft));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
