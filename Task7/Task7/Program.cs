using System;
using System.Net.NetworkInformation;

namespace Task07
{
    public class Tasks
    {
        public static double TheGreatest(double a, double b, double c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b>=c)
            {
                return b;
            }
            return c;
        }

        public class CalculatingAverage
        {
            public static double Arithmetic(double number1, double number2, double number3)
            {
                double count_of_numbers = 3;
                return (number1 + number2 + number3) / count_of_numbers;
            }

            public static double Geometry(double number1, double number2, double number3)
            {
                double count_of_numbers = 3;
                return Math.Pow(number1 * number2 * number3, 1 / count_of_numbers);
            }
        }

        public static double FindMax(double num1, double num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public static double FindCircleArea(double r1, double r2)
        {
            double Pi = 3.14159265358979323846264338327950288;
            return Pi * (Math.Pow(r1, 2) - Math.Pow(r2, 2));
        }

        public static double SolveEquation(double a, double b)
        {
            return -(b / a);
        }
    }
}