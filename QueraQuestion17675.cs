using System;

namespace CW1
{
    /// <summary>
    /// Solves the question <c>17675</c> in quera.
    /// For more info visit: https://quera.org/problemset/17675/
    /// </summary>
    public class QueraQuestion17675
    {
        static int previousFib = 0;
        static int lastFib = 1;
        public static void QueraMain(string[] args)
        {
            var theNumber = Convert.ToInt32(Console.ReadLine());
            var totalStr = "";
            for (int i = 1; i <= theNumber; i++)
            {
                totalStr += IsFib(i) ? "+" : "-";
            }

            Console.WriteLine(totalStr);
        }

        private static bool IsFib(int theNum)
        {
            if (theNum == lastFib)
                return true;

            var f0 = previousFib;
            var f1 = lastFib;
            int f2;

            for (int i = f1; i <= theNum; i++) 
            {
                f2 = f1 + f0;
                f0 = f1;
                f1 = f2;

                if (theNum == f1)
                    return true;

                previousFib = lastFib;
                lastFib = f2;

                if (f1 > theNum)
                    break;
            }

            return false;
        }
    }
}
