using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._5_kyu
{
    static class NumberOfTrailingZerosOfN_
    {
        public static int TrailingZeros(int n)
        {
            int count = 0;
            for (int i = 5; n / i >= 1; i *= 5)
            {
                count += n / i;
            }
            return count;
        }
    }
}
