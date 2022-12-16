using CW.CW3.Thursday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CW3.Friday
{
    public class FridayCW
    {
        public static void Question1()
        {
            do
            {
                ThursdayCW.Question2();
                Console.WriteLine("Do you want to proceed?");
            } while (Console.ReadLine() != "n");
        }

        public static void Question2()
        {
            var userDateTime1 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);
            var userDateTime2 = DateTime.Parse(Console.ReadLine());

            var substract = (userDateTime1 > userDateTime2) ? 
                userDateTime1 - userDateTime2 :
                userDateTime2 - userDateTime1;
            Console.WriteLine(substract);
            Console.WriteLine(substract.Ticks);
        }

        public static void Question3()
        {
            var product1 = new Product()
            {
                Price = 100,
                Weight = 100,
            };

            var product2 = new Product()
            {
                Price = 100,
                Weight = 100,
            };

            Console.WriteLine(product1 == product2);
        }

        public static void Question4()
        {

        }
    }
}
