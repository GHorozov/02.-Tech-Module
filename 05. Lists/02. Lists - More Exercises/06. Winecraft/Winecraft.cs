using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Winecraft
    {
        static void Main(string[] args)
        {
            var grapes = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var grapesGrowth = int.Parse(Console.ReadLine());

           
            while (grapes.Count > grapesGrowth)
            {
                for (int currentTurn = 0; currentTurn < grapesGrowth; currentTurn++)
                {
                    IncrementAllGrapes(grapes);

                    for (int i = 0; i < grapes.Count; i++)
                    {
                        ProccesAllGrapes(grapes, i);
                    }
                }

                RemoveSmallThenGrapeGroth(grapes, grapesGrowth);

            }


            Console.WriteLine(string.Join(" ", grapes));
        }

        private static void RemoveSmallThenGrapeGroth(List<int> grapes, int grapesGrowth)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= grapesGrowth)
                {
                    grapes.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void ProccesAllGrapes(List<int> grapes, int i)
        {
            var isFirst = (i == 0);
            var isLast = (i == grapes.Count - 1);

            if (!isFirst && !isLast)
            {
                var prevIndex = i - 1;
                var nextIndex = i + 1;

                var isGreaterThanPrev = grapes[i] > grapes[prevIndex];
                var isGreaterThanNext = grapes[i] > grapes[nextIndex];
                var isGreaterGrape = isGreaterThanPrev && isGreaterThanNext;
                if (isGreaterGrape)
                {
                    grapes[i]--;

                    if(grapes[prevIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[prevIndex] = Math.Max(grapes[prevIndex] -2, 0);
                    }
                    if (grapes[nextIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                    }
                }

            }
        }

        private static void IncrementAllGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                grapes[i]++;
            }
        }
    }
}
