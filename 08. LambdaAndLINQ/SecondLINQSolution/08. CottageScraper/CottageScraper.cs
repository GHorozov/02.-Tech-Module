using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class CottageScraper
    {
        static void Main()
        {
            var woods = new Dictionary<string, List<int>>();
            var line = Console.ReadLine();
            while(line != "chop chop")
            {
                var lineArgs = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var woodType = lineArgs[0];
                var woodheight = int.Parse(lineArgs[1]);

                if(!woods.ContainsKey(woodType))
                {
                    woods[woodType] = new List<int>();
                }

                woods[woodType].Add(woodheight);
                line = Console.ReadLine();
            }
            var treeType = Console.ReadLine();
            var minLenghtThree = int.Parse(Console.ReadLine());

            var woodForCottage = new Dictionary<string, List<int>>();
            var listAllowedLenght = woods[treeType].Where(x => x >= minLenghtThree).ToList();
            if (woods.ContainsKey(treeType))
            {
                woodForCottage[treeType] = listAllowedLenght;
            }

            var price = Math.Round((woods.SelectMany(x => x.Value).Average()), 2);
            var usedLogPrice =Math.Round((woodForCottage.SelectMany(x => x.Value).Sum()) * price, 2);

            var unusedTreesFromChosedTree = woods[treeType].Where(x => x < minLenghtThree).Select(x => x).Sum();
            var unusedFromWoods = 0;
            foreach (var trees in woods)
            {
                if(trees.Key == treeType)
                {
                    continue;
                }
                var currentTreeSum = trees.Value.Select(x => x).Sum();
                unusedFromWoods += currentTreeSum;
            }

            var unusedLogPrice = Math.Round(((unusedFromWoods + unusedTreesFromChosedTree) * price * 0.25 ), 2);
            var subtotal = usedLogPrice + unusedLogPrice;

            Console.WriteLine("Price per meter: ${0:f2}", price);
            Console.WriteLine("Used logs price: ${0:f2}", usedLogPrice);
            Console.WriteLine("Unused logs price: ${0:f2}", unusedLogPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", subtotal); 
        }
    }
}
