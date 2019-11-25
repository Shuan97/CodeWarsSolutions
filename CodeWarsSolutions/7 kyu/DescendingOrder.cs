using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._7_kyu
{
    static class DescendingOrder
    {
        public static int DescendingOrderFunc(int num)
        {
            return Convert.ToInt32(String.Concat(num.ToString().OrderByDescending(c => c)));
        }
    }
}
