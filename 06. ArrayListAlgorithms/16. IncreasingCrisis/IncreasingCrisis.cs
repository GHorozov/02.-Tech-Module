using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<decimal>();
            var pos = 0;
            for (int i = 0; i < n; i++)
            {
                pos = 0;
                var currentSequance = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

                if (list.Count == 0)
                {
                    list.AddRange(currentSequance);
                }
                else
                {
                    for (int j = list.Count-1; j >=0 ; j--)
                    {
                        if (currentSequance[0] >= list[j])
                        {
                            list.InsertRange(j+1, currentSequance);
                            pos = j+1;
                            break;
                        }     
                    }
                    //cut all behind added currentSequance
                    var seqCount = currentSequance.Length;
                    list.RemoveRange((seqCount + pos), list.Count - (seqCount + pos));

                    //remove all behind number smaller than previous
                    for (int z = 1; z < list.Count; z++)
                    {
                        if( list[z-1] > list[z])
                        {
                            list.RemoveRange(z, list.Count - z);
                            break;
                        }
                    }
                }    
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
