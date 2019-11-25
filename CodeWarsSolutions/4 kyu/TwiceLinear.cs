using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._4_kyu
{
    static class TwiceLinear
    {
        public static int DblLinear(int n)
        {
            var sequence = new SortedSet<int>() { 1 };
            for (var i = 1; true; i++)
            {
                var current = sequence.First();
                sequence.Remove(current);
                if (i == n) return sequence.First();
                sequence.Add(current * 2 + 1);
                sequence.Add(current * 3 + 1);
            }
        }
    }
}
