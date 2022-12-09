using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CW.CW2.Friday
{
    public class BinarySearching
    {
        /// <summary>
        /// Finds and returns the index of the target number inside of
        /// the given array using binary search algorithm; retusn -1
        /// if the target number is not found.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="targetNum"></param>
        /// <returns></returns>
        public static int FindNumber(int[] intArray, int targetNum)
        {
            int minNum = 0;
            int maxNum = intArray.Length - 1;
            int currentIndex;

            while (minNum <= maxNum)
            {
                currentIndex = (minNum + maxNum) / 2;
                if (targetNum == intArray[currentIndex])
                {
                    return currentIndex + 1;
                }

                else if (targetNum < intArray[currentIndex])
                {
                    maxNum = currentIndex - 1;
                }
                else
                {
                    minNum = currentIndex + 1;
                }
            }

            return -1;
        }

        [Theory]
        [InlineData(1, "1", "2")]
        public static void StartGettingInputs(int targetNum = 0, params string[] userInputs)
        {
            bool fromTest = false;
            while (true)
            {
                if (userInputs == null || userInputs.Length == 0)
                {
                    Console.WriteLine("Write all numbers: ");
                    userInputs = Console.ReadLine()!.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                }
                int[] allNumbers = userInputs.Select((value) => Convert.ToInt32(value)).ToArray();
                if (targetNum == 0)
                {
                    Console.WriteLine("Give the number to find: ");
                    targetNum = Convert.ToInt32(Console.ReadLine());
                }
                var theIndex  = FindNumber(allNumbers, targetNum);
                Console.WriteLine($"The index of the target num is {theIndex}");

                if (fromTest)
                {
                    return;
                }

                Console.WriteLine("Press y to try again.");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
        }
    }
}
