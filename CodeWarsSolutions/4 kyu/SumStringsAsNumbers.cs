using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._4_kyu
{
    static class SumStringsAsNumbers
    {
        public static string SumStrings(string a, string b)
        {
            int size = Math.Max(a.Length, b.Length);
            a = Reverse(a);
            b = Reverse(b);
            int offset = 0;
            int count = 0;
            StringBuilder result = new StringBuilder();
            for (var i = 0; i <= size; i++)
            {
                var c = (a.Length > i) ? Convert.ToInt32(a[i].ToString()) : 0;
                var d = (b.Length > i) ? Convert.ToInt32(b[i].ToString()) : 0;
                var sum = c + d + offset;
                offset = sum < 10 ? 0 : 1;
                sum = sum < 10 ? sum : sum % 10;
                result.Append(sum);
            }
            Console.WriteLine("Reverted result:" + result);
            StringBuilder halo = new StringBuilder(Reverse(result.ToString()));

            for (int i = 0; i < halo.Length; i++)
            {
                if (String.Equals(halo[i], '0')) count++;
                else break;
            }
            halo.Remove(0, count);
            return halo.ToString();
        }

        public static string Reverse(string text)
        {
            if (text == null) return null;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
