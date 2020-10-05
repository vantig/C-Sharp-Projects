using System;
using System.Collections.Specialized;

namespace Task9
{
    public class Task09
    {
        /*Разработайте программу, которая находит сумму(произведение) цифр заданного натурального числа*/
        public static double CalculateAverage(int num)
        {
            int average = 0;
            int countOfDigitsInNumber = 0;
            while (num != 0)
            {
                average = average + (num % 10);
                num /= 10;
                countOfDigitsInNumber++;

            }

            return average / countOfDigitsInNumber;
        }

        //Разработайте программу, которая проверяет, что цифры заданного числа образуют возрастающую(убывающую) последовательность(к примеру, число
        //    1357 удовлетворяет условию, т.к.его цифры соответствуют следующему неравенству: 1 < 3 < 5 < 7, т.е.идут в порядке возрастания; число 98765 также удовлетворяет условию, т.к.его цифры соответствуют следующему неравенству 9
        //> 8 > 7 > 6 > 5; а вот числа 192837, 777, 19283746 – не удовлетворяют условию).
        public static bool CheckNumberSequence(int number)
        {
            var num = number;
            int[] digits = new int[num.ToString().Length];

            int countOfDigitsInNumber = 0;
            while (num != 0)
            {
                digits[countOfDigitsInNumber] = num % 10;
                countOfDigitsInNumber++;
                num /= 10;
            }

            Array.Sort(digits, (x1, x2) => x1.CompareTo(x2));
            var str = "";
            foreach (var digit in digits)
            {
                str += digit;
            }
            return str == number.ToString();

        }


        //Начальный вклад в банке равен 1000 руб.При ежемесячной капитализации
        //    через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы(P – вещественное число, которое должно удовлетворять неравенству 0 < P< 25). По данному P определить, через сколько месяцев размер
        //    вклада превысит 2000 руб., и вывести найденное количество месяцев K(целое
        //    число) и итоговый размер вклада S(вещественное число).
        
        public static bool CheckInputNumberInRange(double number, double min, double max)
        {
            return number>min && number<max;
        }
    public static double  CalculationDepositDuration(double percent)
    {
        double minValue = 0, maxValue = 25;
            double initialContribution = 1000;
            int maxContribution = 2000, countOfMonths = 0;
            if (!CheckInputNumberInRange(percent,minValue,maxValue))
            {
                return -1;
            }
          
            while (initialContribution<maxContribution)
            {
                initialContribution = initialContribution+ initialContribution*(percent/100);
                countOfMonths++;
            }

            return countOfMonths;
        }
    }
}
