using System;


namespace Task_04
{
    public class Tasks
    {
        public static string ReverseString(string originalString = "str")
        {
            char[] reversedCharArray = new char[originalString.Length];
            int i = 0;
            int j = originalString.Length - 1;
            while (j >= 0)
            {
                reversedCharArray[i] = originalString[j];
                j--;
                i++;
            }

            return new string(reversedCharArray);
        }

        public static int ReverseNumber(int originalNumber)
        {
            int reverseNum = 0;

            while (originalNumber != 0)
            {
                reverseNum = reverseNum * 10 + originalNumber % 10;
                originalNumber /= 10;
            }

            return reverseNum;
        }

        public class TimeFromTheBeginningOfTheDay
        {
            public static double ConvertInMinuts()
            {
                return (DateTime.Now - DateTime.Now.Date).TotalMinutes;
            }

            public static double ConvertInHours()
            {
                return (DateTime.Now - DateTime.Now.Date).TotalHours;
            }

            public static double ConvertInSeconds()
            {
                return (DateTime.Now - DateTime.Now.Date).TotalSeconds;
            }
        }

        public static int CalculatingArithmeticMean(int number)
        {
            int count=0, average=0;
            while (number>0)
            {
                average += number % 10;
                number = number / 10;
                ++count;
            }
            
            return count>0?average/count:0;
        }
    }
}
