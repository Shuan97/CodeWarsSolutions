using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._6_kyu
{
     static class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];
            if (n < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    result[i] = signature[i];
                }
                return result;
            }
            result[0] = signature[0];
            result[1] = signature[1];
            result[2] = signature[2];
            for (int i = 0; i < n - 3; i++)
            {
                result[i + 3] = result[i] + result[i + 1] + result[i + 2];
            }
            return result;
        }
    }
}
