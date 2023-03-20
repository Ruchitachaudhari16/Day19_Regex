using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.Reflection;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {//UC4 As a User need tofollow predefinedMobile Format -E.g. 91 9919819801 - Country code follow by space
            Console.WriteLine("Enter Mobile Number");
            string mobile_no=Console.ReadLine();

            if (Patterns.validateLastName(mobile_no))
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