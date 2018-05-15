using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var daysLenght = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            var trackLenght = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var donatedMoneyPerKilometer = double.Parse(Console.ReadLine());

            var capacity = trackCapacity * daysLenght;
            if (capacity < numberOfRunners)
            {
                numberOfRunners = capacity;
            }

            var singleRunnerKilometers = (lapsPerRunner * (double)trackLenght) / 1000;
            var totalKilometers = numberOfRunners * singleRunnerKilometers;
            var totalDonatedMoney = totalKilometers * donatedMoneyPerKilometer;


            Console.WriteLine("Money raised: {0:f2}", totalDonatedMoney);
        }
    }
}
