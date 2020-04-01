using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] arg)
        {
            /*   for (var i = 0; i <= 10; i++)
               {
                   if (i % 2 == 0)
                   {
                       Console.WriteLine(i);
                   }
               }

               for (var i = 10; i >= 1; i--)
               {
                   if (i % 2 == 0)
                   {
                       Console.WriteLine(i);
                   }
               }*/


            /*   var numbers = new int[] {1, 2, 3, 4};
               foreach (var number in numbers)
               {
                   Console.WriteLine(number);   
               }*/


            /* while (true)
             {
                 Console.Write("Type your name: ");
                 var input = Console.ReadLine();

                 if (string.IsNullOrWhiteSpace(input))
                     break;

                 Console.WriteLine($"@Echo: {input}");
             }*/

            /* while (true)
             {
                 Console.Write("Type your name: ");
                 var input = Console.ReadLine();

                 if (!String.IsNullOrWhiteSpace(input))
                 {
                     Console.WriteLine($"@Echo: {input}");
                     continue;
                } break;
             }*/

            /*var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            
                buffer[i] = ((char)('a' + random.Next(0, 26)));

            var password = new string(buffer);

            Console.WriteLine(password);*/

            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            /*  var count = 0;
              for (var i = 1; i <= 100; i++)
              {
                  if (i % 3 == 0)
                  {
                      Console.WriteLine(i);
                  }
              }*/


            // Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.
            /*  var sum = 0;
               while (true)
               {
                   Console.WriteLine("Enter a number or 'ok to exit: ");
                   var input = Console.ReadLine();

                   if (input.ToLower() == "ok")
                       break;
                   sum += int.Parse(input);
               }
               Console.WriteLine($"The sum of all the numbers are {sum}.");*/

            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            /* var fact = 1;
             Console.WriteLine("Enter a number.");
             var factorialNumber = int.Parse(Console.ReadLine());

             for (var i = 1; i <= factorialNumber; i++)
             {
                 fact *= i;
             }
             Console.WriteLine($"The factorial of {factorialNumber} is {fact}.");
             Console.ReadLine();*/

            /*var number = new Random().Next(1, 10);

           // Console.WriteLine($"Secret is {number}.");
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Enter a number to guess the random number. ");
                var input = int.Parse(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");*/


            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8

            Console.WriteLine("Enter a series of numbers separated by commas.");
            var userInput = Console.ReadLine();
            var numbers = userInput.Split(",");

            var max = int.Parse(numbers[0]);
            foreach (var num in numbers)
            {
                var number = int.Parse(num);
                if (number > max)
                    max = number;
            }
            Console.WriteLine($"The max number is {max}.");
        }
    }
}
