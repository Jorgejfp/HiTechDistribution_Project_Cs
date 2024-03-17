using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

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

        public static void PositionButton(Button button, int screenWidth, int screenHeight)
        {
            double dpiX = screenWidth / (Screen.PrimaryScreen.Bounds.Width / 1.0);
            double dpiY = screenHeight / (Screen.PrimaryScreen.Bounds.Height / 1.0);
            double screenPhysicalWidth = screenWidth / dpiX;
            double screenPhysicalHeight = screenHeight / dpiY;
            double cmToInch = 1.0 / 2.54; 
            double cm = 2; 
            double inches = cm * cmToInch; 
            int pixelsX = (int)(inches * dpiX); 
            int pixelsY = (int)(inches * dpiY); 
            int dosCmEnPixelesX = (int)(2 * dpiX * cmToInch); 
            int dosCmEnPixelesY = (int)(2 * dpiY * cmToInch); 
            int x = screenWidth - 76 - 154;
            int y = screenHeight - 106 - 45;
            button.Location = new Point(x, y);
            button.Size = new Size(154, 45);
        }
    }
}