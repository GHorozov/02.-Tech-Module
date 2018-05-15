using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Sum(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
    class Products
    {
        static void Main()
        {

            string database = "database.txt";
            Dictionary<string, Dictionary<string, Product>> stock = new Dictionary<string, Dictionary<string, Product>>()
            {
                { "Food", new Dictionary<string, Product>() },
                { "Electronics", new Dictionary<string, Product>()},
                {"Domestics", new Dictionary<string, Product>()}
            };


            if (!File.Exists("database.txt"))
            {
                File.Create("database.txt").Close();
            }

            //Load database to dictionary.
            LoadDatabase(database, stock);

            //read Input file.
            var lines = File.ReadAllLines("Input.txt");
            foreach (var line in lines)
            {
                if (line == "exit") break;

                var lineParts = line.Split(' ');
                var firstWord = lineParts[0];


                if (firstWord == "analyze")
                {
                    AnalyzeStockProducts(database);
                }
                else if (firstWord == "sales")
                {
                    SalesForAllProducts(stock);
                }
                else if (firstWord == "stock")
                {
                    StockAllProducts(database, stock);
                }
                else
                {
                    var name = lineParts[0];
                    var type = lineParts[1];
                    var price = decimal.Parse(lineParts[2]);
                    var quantity = int.Parse(lineParts[3]);


                    if (stock[type].ContainsKey(name))
                    {
                        stock[type][name].Price = price;
                        stock[type][name].Quantity = quantity;
                    }
                    else
                    {
                        var currentProduct = new Product
                        {
                            Name = name,
                            Type = type,
                            Price = price,
                            Quantity = quantity
                        };

                        stock[type].Add(currentProduct.Name, currentProduct);
                    }
                }

            }
            //=========================================================================================
        }

        private static void LoadDatabase(string database, Dictionary<string, Dictionary<string, Product>> stock)
        {

            var databaseLines = File.ReadAllLines("database.txt");
            foreach (var line in databaseLines)
            {
                var currentLine = line.Split(' ');

                var type = currentLine[0];
                var name = currentLine[1];
                var price = decimal.Parse(currentLine[2]);
                var quantity = int.Parse(currentLine[3]);

                var newProduct = new Product
                {
                    Type = type,
                    Name = name,
                    Price = price,
                    Quantity = quantity
                };

                stock[type][newProduct.Name] = newProduct;
            }

        }

        private static void SalesForAllProducts(Dictionary<string, Dictionary<string, Product>> stock)
        {

            stock.Where(x => x.Value.Any())
                .ToDictionary(x => x.Key, x => x.Value.Sum(y => y.Value.Price * y.Value.Quantity))
                .OrderByDescending(x => x.Value)
                .ToList()
                .ForEach(x => Console.WriteLine("{0}: ${1}", x.Key, x.Value));

        }

        private static void AnalyzeStockProducts(string database)
        {
            var lines = File.ReadAllLines(database);
            if (lines.Length > 0)
            {
                foreach (var line in lines)
                {
                    var property = line.Split(' ');
                    Console.WriteLine($"{property[0]}, Product: {property[1]}\r\nPrice: {property[2]}, Amount Left: {property[3]}");
                }

            }
            else
            {
                Console.WriteLine("No products stocked");
                return;
            }

        }

        private static void StockAllProducts(string database, Dictionary<string, Dictionary<string, Product>> stock)
        {
            File.Delete(database);

            File.AppendAllLines(database, stock["Domestics"].Select(x => x.Value).Select(x => x.Type + " " + x.Name + " " + x.Price + " " + x.Quantity));
            File.AppendAllLines(database, stock["Electronics"].Select(x => x.Value).Select(x => x.Type + " " + x.Name + " " + x.Price + " " + x.Quantity));
            File.AppendAllLines(database, stock["Food"].Select(x => x.Value).Select(x => x.Type + " " + x.Name + " " + x.Price + " " + x.Quantity));
        }
    }
}
