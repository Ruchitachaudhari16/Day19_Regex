using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.Reflection;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {//UC5 As a User need to follow predefined Password rules.Rule1– minimum 8 Characters - NOTE – All rules must be passed
         //UC6 Rule2– Should have at least 1Upper Case -NOTE – All rules must be passed
         //UC7 Rule3– Shouldhave at least 1numeric number in the password -NOTE – All rules must be passed
         //UC8 Rule4 – Has exactly1 Special Character -NOTE – All rules must be passed
            Console.WriteLine("Enter Password");
            string password=Console.ReadLine();

            if (Patterns.validateLastName(password))
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