using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }*/

            /*bool isGoldCustomer = true;
           //float price;
           *//* if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }*//*

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //If the condition is true then the price is the price after the ternary operator, but if not then the latter.
            Console.WriteLine(price);
*/
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion.");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's spring and a beautiful season.");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter and a beautiful season.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
