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
        public static bool IsValidID(int input)
        {
            return input >= 1000 && input <= 9999;
        }

        public static bool IsValidName(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    return false;

                }
            }

            return true;
        }
        public static bool IsValidPhoneNumber(string input)
        {
            string pattern = @"^\(\d{3}\)\s\d{3}-\d{4}$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsValidEmail(string input)
        {
            if (!Regex.IsMatch(input, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                return false;
            }

            return true;
        }
    }
}