using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions._3_kyu;
using CodeWarsSolutions._4_kyu;
using CodeWarsSolutions._5_kyu;
using CodeWarsSolutions._6_kyu;
using CodeWarsSolutions._7_kyu;
using CodeWarsSolutions._8_kyu;

namespace CodeWarsSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Result(PrimeStreaming_PG_13_.Stream());
            //Result(TwiceLinear.DblLinear(123451));
            //Result(SquareIntoSquaresProtectTrees_.Decompose(123456));
            //Result(Tic_Tac_ToeChecker.IsSolved(new int[,]{{0,0,1},{0,1,2},{2,1,0}}));
            //Result(NumberOfTrailingZerosOfN_.TrailingZeros(999));
            //Result(SumStringsAsNumbers.SumStrings("14523456534262562562", "145664653656454534756"));
            //Result(FindTheOddInt.FindIt(new int[]{4,6,4,4,6}));
            //Result(GetCharacterFromASCIIValue.GetChar(65));
            //Result(CalculateBMI.Bmi(75.5d, 1.8d));
            //Result(DescendingOrder.DescendingOrderFunc(43626876));
            //Result(DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog"));
            //Result(PersistentBugger.Persistence(999));
            //Result(TribonacciSequence.Tribonacci(new double[] { 1, 1, 1 }, 5));
            //Result(FindTheSmallestIntegerInTheArray.FindSmallestInt(new int[] { 1, 2, 4, 7, 3, 5 }));

            // ------------
            Console.ReadKey();
        }


        public static void Result(int i)
        {
            Console.WriteLine($"Result: {i}");
        }

        public static void Result(double[] d)
        {
            Console.Write($"Result: ");
            foreach (var d1 in d)
            {
                Console.Write($"{d1.ToString()}, ");
            }

            Console.WriteLine();
        }

        public static void Result(bool b)
        {
            Console.WriteLine($"Result: {b.ToString()}");
        }

        public static void Result(string s)
        {
            Console.WriteLine($"Result: {s}");
        }

        public static void Result(IEnumerable<int> i)
        {
            Console.WriteLine($"Result: ");
            foreach (var i1 in i)
            {
                Console.Write($"{i1.ToString()}, ");
            }

            Console.WriteLine();
        }
    }
}
