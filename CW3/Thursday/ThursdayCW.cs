using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CW.CW3.Thursday
{
    public class ThursdayCW
    {
        [Theory]
        [InlineData(10)]
        public static void Question1A(int n = 0)
        {
            var utilityObject = new Utility();
            var intArray = utilityObject.GetFibSeries(n);
            Console.WriteLine(string.Join(", ", intArray));
        }

        [Theory]
        [InlineData(5)]
        public static void Question1B(int n = 0)
        {
            var utilityObject = new Utility();
            Console.WriteLine(utilityObject.GetFactorial(n));
        }

        [Theory]
        [InlineData(null, null)]
        public static void Question1C(int[,] matrixA = null, int[,] matrixB = null)
        {
            var utilityObject = new Utility();
            var result = utilityObject.MultiplyMatrices(matrixA, matrixB);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("done");
        }

        [Theory]
        [InlineData("Fibonacci")]
        [InlineData("Factoriel")]
        [InlineData("Matrix")]
        public static void Question2(string userInput = null)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Give me the math operation: ");
                userInput = Console.ReadLine();
            }

            switch (GetMathematicEnum(userInput))
            {
                case MathematicEnum.Fibonacci:
                    Question1A();
                    return;
                case MathematicEnum.Factoriel:
                    Question1B();
                    return;
                case MathematicEnum.Matrix:
                    Question1C();
                    return;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
        }

        private static MathematicEnum? GetMathematicEnum(string value) =>
            Enum.Parse(typeof(MathematicEnum), value) as MathematicEnum?;
    }
}
