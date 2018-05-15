using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var moneyIvanchoHas = double.Parse(Console.ReadLine());
            var guestsNumber = int.Parse(Console.ReadLine());
            var bananasPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var guestPortionsRem = guestsNumber % 6;
            var guestPortions = guestsNumber / 6;
            if(guestPortionsRem > 0)
            {
                guestPortions += 1;
            }
            var cost = guestPortions * (2 * bananasPrice) + guestPortions * (4 * eggPrice) + guestPortions * (0.2 * berriesPrice);
           
            if(moneyIvanchoHas >= cost)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", cost);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", Math.Abs(moneyIvanchoHas-cost));
            }
        }
    }
}
