using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public double Quantity { get; set; }

}
namespace SalesReport
{
    class SalesReport
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var currentSale = ReadSale();
                
                if(!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }
                result[currentSale.Town] += (decimal)currentSale.Quantity * currentSale.Price;
            }


            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        private static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');

            return new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = double.Parse(input[3])
            };
        }
    }
}
