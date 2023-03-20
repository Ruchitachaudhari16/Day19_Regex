using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {//UC2:-As a User need to enter a valid email address
            Console.WriteLine("Enter Email");
            string email=Console.ReadLine();

            if (Patterns.validateLastName(email))
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