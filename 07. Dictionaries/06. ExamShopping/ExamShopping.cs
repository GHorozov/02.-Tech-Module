using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class ExamShopping
    {
        static void Main()
        {
            var stock = new Dictionary<string, int>();
            var line = Console.ReadLine();
            
            //add to stock part
            while (line != "shopping time")
            {
                var currentLine = line.Split(' ');
                var name = currentLine[1];
                var quantity = int.Parse(currentLine[2]);

                if (!stock.ContainsKey(name))
                {
                    stock[name] = 0;
                }
               
                stock[name] += quantity;
                
                line = Console.ReadLine();
            }

            //buy part
            line = Console.ReadLine();
            while (line != "exam time")
            {
                var currentLine = line.Split(' ');
                var name = currentLine[1];
                var quantity = int.Parse(currentLine[2]);

                if (!stock.ContainsKey(name))
                {
                    Console.WriteLine($"{name} doesn't exist");
                }
                else
                {
                    if (stock[name] == 0)
                    {
                        Console.WriteLine($"{name} out of stock");
                    }
                    else
                    {
                        stock[name] -= quantity;

                        if (stock[name] <= 0)
                        {
                            stock[name] = 0;
                        }
                    }  
                }

                line = Console.ReadLine();
            }               
       
            //write result
            foreach (var pair in stock)
            {
                var stockName = pair.Key;
                var stockQuantity = pair.Value;
                if (stockQuantity > 0)
                {
                    Console.WriteLine($"{stockName} -> {stockQuantity}");
                }
            }
        }
    }
}
