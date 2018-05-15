using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main()
        {
            var sequanceN = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelsBackSize = int.Parse(Console.ReadLine());

            if (sequanceN.Count == camelsBackSize)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", sequanceN));
                return;
            }
            var seqSize = sequanceN.Count;
            var seqMid = seqSize / 2;
            var camelsBackMid = camelsBackSize / 2 + 1;
            var camilsLeftSide = camelsBackSize - camelsBackMid;
            var camilsRightSide = camilsLeftSide;

            var countLeftBuildings = 0;
            for (int i = seqMid - camilsLeftSide; i <= seqMid + camilsRightSide; i++)
            {
                countLeftBuildings++;
            }
            var rounds = (sequanceN.Count - countLeftBuildings) / 2;

            sequanceN.RemoveRange(0, rounds);
            sequanceN.RemoveRange((sequanceN.Count) - rounds, rounds);
            Console.WriteLine("{0} rounds\r\nremaining: {1}", rounds, string.Join(" ", sequanceN));
        }
    }
}
