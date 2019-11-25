using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._6_kyu
{
    static class PersistentBugger
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            int i = 0;
            while (n >= 10)
            {
                string s = n.ToString();
                char[] charArray = s.ToCharArray(0, s.Length);
                n = Mult(charArray);
                i++;
            }
            return i;
        }

        public static long Mult(params char[] digits)
        {
            int result = 1;
            foreach (var d in digits) result *= Convert.ToInt32(d.ToString());
            return result;
        }
    }
}
