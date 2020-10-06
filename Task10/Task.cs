using System;
using System.Linq;

namespace Task10
{
    public class Task
    {
        public static int GetRandomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber);

        }

        public static string PlayHeadsOrTails(int count)
        {
            int x1 = 0, x2 = 0;
            for (int i = 0; i < count; i++)
            {
                if (GetRandomNumber(1, 2) == 1)
                {
                    x1++;
                }
                else
                {
                    x2++;
                }
            }

            string str;
            str = $"{x1} {x2}";
            return str;
        }


        public static int FlipNumberWithoutZeros(int N)
        {
            int M = 0;
            foreach (var letter in N.ToString().Reverse())
            {
                if (letter != '0')
                {
                    M *= 10;
                    M += int.Parse(letter.ToString());
                }
            }
            return M;

        }
        public static bool CheckInputNumberInRange(double number, double min)
        {
            return number >= min;
        }

        public static bool IsPrimeNumber(int number)
        {
            const int MIN_NUMBER = 2;
            if (!CheckInputNumberInRange(number, MIN_NUMBER))
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    return false;
                }
            }

            return true;
        }
        public static int CalculateFactorial(int number)
        {
            if (number==0)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }

        public static bool IsPerfectNumber(int number)
        {
            int sumOfDividers = 0;
            for (int i = 1; i < number; i++)
            {
                if (number%i==0)
                {
                    sumOfDividers += i;
                }
            }

            return number == sumOfDividers;
        }
    }
}
