using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._3_kyu
{
    static class PrimeStreaming_PG_13_
    {
        public static IEnumerable<int> Stream()
        {
            //Sieve of Atkin

            var upperBoundary = 16000000;
            var sieve = new bool[upperBoundary];

            for (int x = 1; x * x < upperBoundary; x++)
            {
                for (int y = 1; y * y < upperBoundary; y++)
                {
                    int n = (4 * x * x) + (y * y);
                    if (n <= upperBoundary && (n % 12 == 1 || n % 12 == 5))

                        sieve[n] ^= true;

                    n = (3 * x * x) + (y * y);
                    if (n <= upperBoundary && n % 12 == 7)
                        sieve[n] ^= true;

                    n = (3 * x * x) - (y * y);
                    if (x > y && n <= upperBoundary && n % 12 == 11)
                        sieve[n] ^= true;
                }
            }

            for (int r = 5; r * r < upperBoundary; r++)
            {
                if (sieve[r])
                {
                    for (int i = r * r; i < upperBoundary;
                        i += r * r)
                        sieve[i] = false;
                }
            }

            var list = new HashSet<int>() { 2, 3 };
            for (int a = 5; a < upperBoundary; a++)
                if (sieve[a])
                    list.Add(a);

            return list;
        }
    }
}
