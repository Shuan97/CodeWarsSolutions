using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._6_kyu
{
    static class FindTheOddInt
    {
        public static int FindIt(int[] seq)
        {
            foreach (var a in seq)
            {
                int count = 0;
                foreach (var b in seq)
                {
                    if (a == b)
                        count++;
                }
                if (count % 2 != 0)
                {
                    return a;
                }
            }
            return -1;
        }
    }
}
