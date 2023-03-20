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
        public static string Mobile_Number = "^[+]?[0-9]{2}[ ][0-9]{10}$";
        public static bool validateLastName(string mobile_num)
        {
           
            return Regex.IsMatch(mobile_num,Mobile_Number);

        }
    }
}
