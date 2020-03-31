using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Transactions;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] arg)
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
            /* var season = Season.Autumn;

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
             }*/

            //Write a program and ask the user to enter a number. The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
            //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
           // Console.WriteLine("Please enter a number between 1 & 10.");
          /* var userInput = int.Parse(Console.ReadLine());

           if (userInput > 0 && userInput <= 10)
           {
               Console.WriteLine("Valid");
           }
           else
           {
               Console.WriteLine("Invalid");
           }*/

            // Write a program which takes two numbers from the console and displays the maximum of the two.
            /*Console.WriteLine("Please enter enter your first number.");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number.");
            var secondNumber = int.Parse(Console.ReadLine());

            var theMaxValue = firstNumber > secondNumber ? firstNumber : secondNumber;
            {
                Console.WriteLine($"The max value is {theMaxValue}.");
            }*/

            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
           /* Console.WriteLine("Please enter the height of your image.");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of your image.");
            var width = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("This is landscape.");
            }
            else if (height < width)
            {
                Console.WriteLine("This is portrait.");
            }
            else
            {
                Console.WriteLine("Ooops!");
            }*/

            // Your job is to write a program for a speed camera.

            Console.WriteLine("Enter the speed limit.");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of a car");
            var speeedOfCar = int.Parse(Console.ReadLine());
            

            if (speeedOfCar < speedLimit)
            {
                Console.WriteLine("Okay");
            }
            else
            {
                const int kmPerDemerits = 5;

                var demeritPoints = (speeedOfCar - speedLimit) / kmPerDemerits;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"Demerit points: {demeritPoints}");
                }
            }
        }
    }
}
