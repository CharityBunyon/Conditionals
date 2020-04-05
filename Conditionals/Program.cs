using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
           /* var fullName = "Charity Bunyon ";
            Console.WriteLine($"Trim {fullName.Trim()}");
            Console.WriteLine($"ToUpper {fullName.Trim().ToUpper()}");

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"Firstname: {firstName}");
            Console.WriteLine($"Lastname: {lastName}");

            var names = fullName.Split(' ');
            Console.WriteLine($"Firstname: {names[0]}");
            Console.WriteLine($"Lastname: {names[1]}");

            Console.WriteLine(fullName.Replace("Charity", "Chanel"));
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            Console.WriteLine(int.Parse(str));
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            var sentence = "Hey. Welcome to my really really really really, no but really its really really long.";
            var summary = StringUtlility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
*/
           var builder = new StringBuilder("Hello World");
           builder
               .Append('-', 10)
               .AppendLine()
               .Append("Header")
               .AppendLine()
               .Append('-', 10);

           builder.Replace('-', '+');

           builder.Remove(0, 10);

           builder.Insert(0, new string('-', 10));
           Console.WriteLine(builder);

           Console.WriteLine(builder[0]);



        }

    }
}
