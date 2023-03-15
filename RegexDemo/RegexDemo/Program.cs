using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {//UC2:-As a User need to enter a valid Last Name
            Console.WriteLine("Enter LastName");
            string lastName=Console.ReadLine();

            if (Patterns.validateLastName(lastName))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}