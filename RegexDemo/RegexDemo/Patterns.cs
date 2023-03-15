﻿using System;
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
        public static string FirstName = "^[A-Z][a-z]{2,}$";
        public static bool validateFirstName(string fName)
        {
           
            return Regex.IsMatch(fName,FirstName);

        }
    }
}