using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HiTechDistribution_Project.VALIDATION
{
    internal class Validator
    {
        public static bool IsValidUser(string input)
        {
            if (!Regex.IsMatch(input, @"^\w{4}$"))
            {
                return false;
            }

            return true;
        }
    }
}
