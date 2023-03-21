using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Patterns
    {
        //Regex Expression
        public static string Password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_])[a-zA-Z0-9!@#$%_]{8,}$";
        public static bool validateLastName(string password)
        {
           
            return Regex.IsMatch(password,Password);

        }
    }
}
