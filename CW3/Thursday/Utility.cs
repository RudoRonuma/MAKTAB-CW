using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CW3.Thursday
{
    public class Utility
    {
        public int[] GetFibSeries(int n = 0)
        {
            if (n == 0)
            {
                Console.Write("Give n (for fib series): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            
            var result = new int[n];
            int f0 = 0, f1 = 1, f2;
            result[0] = f0;
            for (int i = 1; i < n; i++)
            {
                f2 = f1 + f0;
                f0 = f1;
                f1 = f2;

                result[i] = f0;
            }

            return result;
        }

        public int GetFactorial(int n = 0)
        {
            if (n == 0)
            {
                Console.Write("Give n (for factorial): ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            return Factorial(n);
        }
        private int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }



        public int[,] MultiplyMatrices(int[,] matrixA = null, int[,] matrixB = null)
        {
            if (matrixA == null || matrixA.Length == 0)
            {
                Console.WriteLine("Give the first matrix's length (example: 2x3): ");
                var dimensions = Console.ReadLine()
                    .Split('x')
                    .Select(int.Parse)
                    .ToArray();
                matrixA = ReadMatrix(dimensions[0], dimensions[1]);
            }

            if (matrixB == null || matrixB.Length == 0)
            {
                Console.WriteLine("Give the second matrix's length (example: 2x3): ");
                var dimensions = Console.ReadLine()
                    .Split('x')
                    .Select(int.Parse)
                    .ToArray();
                matrixB = ReadMatrix(dimensions[0], dimensions[1]);
            }

            int rowA = matrixA.GetLength(0);
            int columnA = matrixA.GetLength(1);
            int rowB = matrixB.GetLength(0);
            int columnB = matrixB.GetLength(1);

            if (columnA != rowB)
            {
                // If they don't have same length, they cannot be mulitplied.
                // For example:
                // (4, 2, 5)
                // AND
                // ( 3 )
                // ( 6 )
                // ( 8 )
                return null;
            }


            int tmp;
            int[,] resultMatrix = new int[rowA, columnB];
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < columnB; j++)
                {
                    // reset the tmp each time
                    tmp = 0;
                    for (int k = 0; k < columnA; k++)
                    {
                        tmp += matrixA[i, k] * matrixB[k, j];
                    }

                    resultMatrix[i, j] = tmp;
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Reads a matrix of len of (x, y) from console.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int[,] ReadMatrix(int x, int y)
        {
            var matrix = new int[x, y];

            for (var i = 0; i < x; i++)
            {
                string[] numList;
                numList = Console.ReadLine()!
                    .Split(new string[] { ",", " "}, StringSplitOptions.RemoveEmptyEntries);
                for (var j = 0; j < y; j++)
                {
                    matrix[i, j] = Convert.ToInt32(numList[j]);
                }
            }

            return matrix;
        }
    }
}
