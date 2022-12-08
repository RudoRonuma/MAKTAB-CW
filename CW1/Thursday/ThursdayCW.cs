using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CW.CW1.Thursday
{
    public class ThursdayCW
    {
        [Fact]
        public static void Question1()
        {
            var strValue1 = Console.ReadLine();
            var strValue2 = Console.ReadLine();

            Console.WriteLine(strValue1 == strValue2);
        }

        [Fact]
        public static void Question2()
        {
            float floatInput1 = Convert.ToSingle(Console.ReadLine());
            float floatInput2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(floatInput1 * floatInput1);
            Console.WriteLine(floatInput2 * floatInput2 * floatInput2);
        }

        [Fact]
        public static void Question3()
        {
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            var num3 = Convert.ToInt32(Console.ReadLine());
            var num4 = Convert.ToInt32(Console.ReadLine());
            var num5 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine(average);
            Console.WriteLine(average % 2 == 0);
        }

        [Fact]
        public static void Question3WithTryParse()
        {
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                num1 = 10;
            }
            _ = int.TryParse(Console.ReadLine(), out int num2);
            _ = int.TryParse(Console.ReadLine(), out int num3);
            _ = int.TryParse(Console.ReadLine(), out int num4);
            _ = int.TryParse(Console.ReadLine(), out int num5);



            int average = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine(average);
            Console.WriteLine(average % 2 == 0);
        }

        [Fact]
        public static void Question4()
        {
            var monthNum = Convert.ToInt32(Console.ReadLine());
            var currentDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((monthNum * 30) + currentDay);
        }

        [Fact]
        public static void Question5()
        {
            bool booleanValue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(!booleanValue);
        }


        [Fact]
        public static void Question6()
        {
            Console.WriteLine("Enter first num:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num (should be smaller than first num):");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 < num1)
            {
                Console.WriteLine(num1 % num2 == 0);
                return;
            }

            Console.Beep();
        }
    }
}
