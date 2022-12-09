
using Xunit;

namespace CW.CW2.Friday
{
    public class FridayCW
    {
        public static void Question1()
        {
            var userInput = Console.ReadLine()!;
            var arrayStrs = Array.Empty<string>();
            var tmpStr = "";
            foreach (var currentChar in userInput)
            {
                if (currentChar == ' ')
                {
                    tmpStr += currentChar;
                    continue;
                }

                arrayStrs =
                    arrayStrs.Append(tmpStr).ToArray();
            }

            arrayStrs =
                    arrayStrs.Append(tmpStr).ToArray();
            Console.WriteLine(arrayStrs);
        }

        public static void Question2()
        {
            var userInput = Console.ReadLine()!;
        }
        public static void Question3()
        {

        }

        [Theory]
        [InlineData("Hhdwopzzno", "Jpazopzzxlappa")]
        public static void Question4(string userInput1 = null, string userInput2 = null)
        {
            userInput1 ??= Console.ReadLine()!;
            userInput2 ??= Console.ReadLine()!;
            var lastCommon = "";
            var currentCommon = "";
            bool isInHit = false;
            for (int i = 0; i < userInput1.Length; i++)
            {
                for (int j = 0; j < userInput2.Length; j++)
                {
                    if (userInput1[i] != userInput2[j] || isInHit)
                    {
                        isInHit = false;
                        // continue till you reach the first common letter
                        continue;
                    }

                    isInHit = true;
                    // we have reached to the first common char
                    // between these two (in this case, 'o').
                    var maxDiff = Math.Min(
                        userInput1.Length - i, userInput2.Length - j) - 1;
                    for (int currentDiff = 0; currentDiff < maxDiff; currentDiff++)
                    {
                        // string[1:3]
                        // string[1..3]
                        if (userInput1[i..(i + currentDiff)] == userInput2[j..(j+ currentDiff)])
                        {
                            currentCommon = userInput1[i..(i + currentDiff)];
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCommon.Length > lastCommon.Length)
                    {
                        lastCommon = currentCommon;
                    }
                    currentCommon = "";
                }

                currentCommon = "";
            }

            Console.WriteLine("Max common string is: " + lastCommon);
        }

        [Theory]
        [InlineData(2, 2, 2, 3)]
        public static void Question5(params int[] arrayInt)
        {
            arrayInt ??= GetIntArrayInput();

        }

        private static int[] GetIntArrayInput() =>
            Console.ReadLine()!.Split(
                new string[] { ",", " " },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(value => Convert.ToInt32(value)).ToArray();
    }
}



