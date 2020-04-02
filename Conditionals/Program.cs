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
            //Learning array methods

            var numbers = new int[] {3, 7, 9, 2, 14, 6};

            //Length- checks the length of an array, but Count() is a LINQ extension that does the same on an IEnumerable
            Console.WriteLine($"Length of numbers array is " +numbers.Length);

            //IndexOf()- first param asks for the array name and then the value that you want to find the index of
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of this array is " + index);

            // Clear() - method that taking in the name of the array, the starting index of where you want objects to be cleared, and the length
            Array.Clear(numbers, 0, 2);

            Console.Write("Effect of Clear()");
            foreach (var num in numbers)
                Console.WriteLine(num); 

            // Copy()- takes 3 params- the array you want to copy, the array you want to copy it to, and the length of the area
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var num in another)
            {
                Console.WriteLine(num);
            }
            

            // Sort()- pass in the array to sort (has several versions) 
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //Reverse() - Reverses the order of elements in a list
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
