using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._4_kyu
{
    static class SquareIntoSquaresProtectTrees_
    {
        public static string Decompose(long n)
        {
            long temp = 0;
            var list = new List<long> { n };
            while (list.Count() > 0)
            {
                long current = list.Last();
                list.RemoveAt(list.Count - 1);
                temp += (long)Math.Pow(current, 2);
                for (long i = current - 1; i > 0; i--)
                {
                    if (temp - Math.Pow(i, 2) >= 0)
                    {
                        temp -= (long)Math.Pow(i, 2);
                        list.Add(i);
                        if (temp == 0)
                        {
                            list.Reverse();
                            return string.Join(" ", list);
                        }
                    }
                }
            }
            return null;
        }
    }
}
