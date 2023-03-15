using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {//As a User need toenter a valid First Name
            Console.WriteLine("Enter FirstName");
            string firstName=Console.ReadLine();

            if (Patterns.validateFirstName(firstName))
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