using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var orders = int.Parse(Console.ReadLine());
            var totalPrice = 0m;
            for (int i = 0; i < orders; i++)
            {
                var pricePerCapsul = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = int.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                //DaysInMonth * copsuleCount both are int = overflow. Cast with long is nessesery to abvoid that.
                var currentPrice= ((daysInMonth * (long)capsuleCount) * pricePerCapsul);

                Console.WriteLine("The price for the coffee is: ${0:f2}", currentPrice);

                totalPrice += currentPrice;
            }

            Console.WriteLine("Total: ${0:f2}", totalPrice);
        }
    }
}
