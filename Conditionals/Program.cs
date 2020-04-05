using System;
using System.Collections.Generic;
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
            var names = new List<string>() { "Mark", "Luke", "John" };
            names.Add("Charity");
            names.AddRange(new string[3] {"Kate", "Sam", "Aries"});

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.IndexOf("John"));

            Console.WriteLine(names.LastIndexOf("John"));

            Console.WriteLine(names.Count);

            for (var i = 0; i < names.Count; i++)
            {
                if (names[i] == "Charity")
                {
                    names.Remove(names[1]);
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Clear();
            Console.WriteLine(names.Count);


            // Exercises

            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern.

            var firstnames = new List<string>();
            while (true)
            {
                Console.Write("Type a name or hit Enter to quit: ");
                var response = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(response))
                    break;
                firstnames.Add(response);
            }


            var addLikes = true;
          
            Console.WriteLine("Enter 'y' to like Charity's post or 'no' to not like her post.");
            var likedOrNot = Console.ReadLine();
            if (likedOrNot.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hopefully, I make better content for you next time.");
                likedOrNot = Console.ReadLine();
            }

            while (addLikes)
            {
                if (likedOrNot.Equals("y", StringComparison.OrdinalIgnoreCase ) && firstnames.Count <= 0)
                {
                    Console.WriteLine("No one liked your post.");
                    likedOrNot= Console.ReadLine();
                    break;
                }else if (likedOrNot.Equals("y", StringComparison.OrdinalIgnoreCase) && firstnames.Count == 1)
                {
                    Console.WriteLine($"{firstnames[0]} likes Charity's post.");
                    break;
                }else if (likedOrNot.Equals("y", StringComparison.OrdinalIgnoreCase) && firstnames.Count == 2)
                {
                    Console.WriteLine($"{firstnames[0]} & {firstnames[1]} likes Charity's post.");
                    break;
                }
                else if (likedOrNot.Equals("y", StringComparison.OrdinalIgnoreCase) && firstnames.Count > 2)
                {
                    Console.WriteLine($"{firstnames[0]} & {firstnames[1]} & {firstnames.Count - 2} likes Charity's post.");
                    break;

                }
            }
        }
    }
}
