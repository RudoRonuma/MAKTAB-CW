
using Xunit;
using System.Collections;

namespace CW.CW2.Thursday
{
    public class ThursdayCW
    {
        [Fact]
        public static void Question1()
        {
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            var num3 = Convert.ToInt32(Console.ReadLine());
            var num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("please give the operator: ");
            var theOperation = Console.ReadLine();
            var myCalculator = new MyCalculator();
            switch (theOperation)
            {
                case "+":
                    //Console.WriteLine(myCalculator.Sum(num1, num2, num3, num4));
                    Console.WriteLine(num1 + num2 + num3 + num4);
                    break;
                case "-":
                    Console.WriteLine(myCalculator.Minus(num1, num2, num3, num4));
                    break;
                case "*":
                    Console.WriteLine(myCalculator.Multiply(num1, num2, num3, num4));
                    break;
                case "/":
                    Console.WriteLine(myCalculator.Division(num1, num2, num3, num4));
                    break;
            }

            var allOperators = new string[] 
            {
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
            };
            var allNums = new int[] { num1, num2, num3, num4 };

            allOperators = SortOperators(allOperators);
            //Array.Sort(allOperators, new OperatorComparer());

            // [10, 30, 40, 50]
            // 

            // (10 * 30) = 300
            // (300 + 40) = 340
            // 340 - 50

            var currentNumIndex = 1;
            var finalResult = (double)allNums[0];
            //var finalResult = 0;
            foreach (var currentOperator in allOperators)
            {
                switch (currentOperator)
                {
                    case "*":
                        finalResult *= allNums[currentNumIndex];
                        break;
                    case "/":
                        finalResult /= allNums[currentNumIndex];
                        break;
                    case "-":
                        finalResult -= allNums[currentNumIndex];
                        break;
                    case "+":
                        finalResult += allNums[currentNumIndex];
                        break;
                }

                currentNumIndex++;
            }

            Console.WriteLine(finalResult);


            // part C
            var wholeCount = Convert.ToInt32(Console.ReadLine());
        }

        public static string[] SortOperators(string[] allOperators)
        {
            var sortedOperators = new string[allOperators.Length];
            int currentIndex = 0;
            for (int i = 0; i < allOperators.Length; i++)
            {
                switch (allOperators[i])
                {
                    case "*":
                    case "/":
                        sortedOperators[currentIndex] = allOperators[i];
                        currentIndex++;
                        break;
                }
            }

            for (int i = 0; i < allOperators.Length; i++)
            {
                switch (allOperators[i])
                {
                    case "+":
                    case "-":
                        sortedOperators[currentIndex] = allOperators[i];
                        currentIndex++;
                        break;
                }
            }

            return sortedOperators;
        }

        [Fact]
        public static void TestComparer()
        {
            var allOperators = new string[]
            {
                "*",
                "-",
                "/"
            };

            allOperators = SortOperators(allOperators);
            //Array.Sort(allOperators, new OperatorComparer());
            Console.WriteLine(allOperators);
        }

        internal class OperatorComparer: IComparer
        {
            /// <summary>
            /// - If less than 0, x is less than y.
            ///     - If 0, x equals y.
            ///     - If greater than 0, x is greater than y.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int Compare(object x, object y)
            {

                if (x is string xStr && (xStr == "*" || xStr == "/"))
                //if ((x == "*" || x == "/"))
                {
                    return -1;
                }

                return 1;
            }
        }

        [Fact]
        public static void CalculateWholeTest()
        {
            var myCalculator = new MyCalculator();
            myCalculator.CalculateWhole("3 * 12 + (-8) - 1");
        }

        [Theory]
        [InlineData("D5f8fs1dds213")]
        public static void Question2(string userInput)
        {
            //var userInput = Console.ReadLine();
            int[] numArrays = new int[] { };
            foreach (var currentChar in userInput)
            {
                if (char.IsNumber(currentChar))
                {
                    numArrays =
                        numArrays.Append(Convert.ToInt32(currentChar.ToString())).ToArray();
                }
            }

            for (int i = 0; i < numArrays.Length; i++)
            {
                for (int j = 0; j < numArrays[i]; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            //Console.WriteLine();
        }

        [Fact]
        public static void Question3()
        {
            while (true)
            {
                if (!DoQuestion3())
                {
                    break;
                }
            }
        }

        [Fact]
        public static void Question3_OLD()
        {
            string userInput = "";
            while (true)
            {
                var inputKey = Console.ReadKey();
                switch (inputKey.Key)
                {
                    case ConsoleKey.C:
                        DoQuestion3();
                        return;
                    default:
                        if (!char.IsNumber(inputKey.KeyChar))
                        {
                            userInput += "0";
                        }
                        else
                        {
                            userInput += inputKey.KeyChar.ToString();
                        }
                        break;
                }
            }
            
        }

        private static bool DoQuestion3()
        {
            var userInput = Console.ReadLine();
            var finalResult = "";
            foreach (var currentChar in userInput)
            {
                if (!char.IsNumber(currentChar))
                {
                    finalResult += "0";
                }
                else
                {
                    finalResult += currentChar.ToString();
                }
            }

            Console.WriteLine(finalResult);

            var inputKey = Console.ReadKey().Key;
            return inputKey != ConsoleKey.C;
        }

        [Fact]
        public static void Question4()
        {

        }

        [Fact]
        public static void Question5()
        {

        }

        [Fact]
        public static void Question6()
        {

        }
    }
}