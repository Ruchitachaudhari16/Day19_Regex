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
        public static string LastName = "^[A-Z][a-z]{2,}$";
        public static bool validateLastName(string lName)
        {
           
            return Regex.IsMatch(lName,LastName);

        }
    }
}
