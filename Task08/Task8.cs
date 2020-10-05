
using System;

namespace Task08
{
    public class Task8
    {

        public static int GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber);
        }

        public static string PlayMoodSensor()
        {
            string msg = "";

            switch (GetRandomNumber(3))
            {
                case 1:
                    msg = "~(>_<~)";
                    break;
                case 2:
                    msg = "(×﹏×)";
                    break;
                case 3:
                    msg = "(*^.^*)";
                    break;

            }

            return msg;
        }
        protected enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static bool CheckInputNumberInRange(double number, double min, double max)
        {
            return number >= min && number <= max;
        }
        public static string ReturnDayOfTheWeek(int day)
        {
            if (CheckInputNumberInRange(day, 1, 7))
            {
                return ((Days)(day - 1)).ToString();
            }
            return String.Empty;
        }

        public static bool IsVowel(string letter)
        {
            switch (letter.ToUpper())
            {
                case "A": return true;
                case "E": return true;
                case "I": return true;
                case "O": return true;
                case "U": return true;
                case "Y": return true;

                default: return false;
            }
        }
    }
}


