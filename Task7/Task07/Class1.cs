using System;

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
            else if (b >= c)
            {
                return b;
            }
            return c;
        }

        public static bool IsTriangle(double a, double b, double c)
        {
            return TheGreatest(a, b, c) < (a + b + c) / 2;
        }
        public static double PlayDice()
        {

            Random rnd = new Random();
            var value1 = rnd.Next(1, 6);
            var value2 = rnd.Next(1, 6);
            return value1 + value2;
        }
        public static bool IsVowelLetter(string letter)
        {
            letter = letter.ToLower();
            char[] letters = new char[] { 'a', 'e', 'i', 'o', 'v', 'y' };
            for (int i = 0; i < letters.Length; i++)
            {
                if (letter[0] == letters[i])
                { return true; }

            }
            return false;
        }
        public static bool QuadricEquation(double a,double b ,double c,double[]array)
        {
            var D = (b * b) - 4 *( a * c);
            if (D<0)
            {
                return false;
            }
            else if (D==0)
            {
                array[0] = -b / 2 * a;
                return true;
            }
           array[0]= -b + Math.Sqrt(D) / 2 * a;
            array[1] = -b + Math.Sqrt(D) / 2 * a;
            return true;
        }
        public class Dragon
        {
            const int YEARS_FOR_FIRST_RULE = 200;
            const int YEARS_FOR_SECOND_RULE = 300;
            const int HEADS_PER_YEAR_BEFORE_FIRST_RULE = 3;
            const int HEADS_PER_YEAR_BEFORE_SECOND_RULE = 2;
            const int HEADS_PER_YEAR_AFTER_RULE2 = 1;
            const int EYES_ON_HEAD = 2;
            public static int CountingDragonHeads(int age)
            {


              

                if (age <= YEARS_FOR_FIRST_RULE)
                {
                    return HEADS_PER_YEAR_BEFORE_FIRST_RULE * age;
                }
                else if (age <= YEARS_FOR_SECOND_RULE)
                {
                    return HEADS_PER_YEAR_BEFORE_FIRST_RULE * YEARS_FOR_FIRST_RULE +
                           HEADS_PER_YEAR_BEFORE_SECOND_RULE * (age - YEARS_FOR_FIRST_RULE);
                }
                else
                {
                    return HEADS_PER_YEAR_BEFORE_FIRST_RULE * YEARS_FOR_FIRST_RULE +
                           HEADS_PER_YEAR_BEFORE_SECOND_RULE * (YEARS_FOR_SECOND_RULE - YEARS_FOR_FIRST_RULE) +
                           HEADS_PER_YEAR_AFTER_RULE2 * (age - YEARS_FOR_SECOND_RULE);
                }
            }



            public static int CountingDragonEyes(int age)
            {
                return CountingDragonHeads(age) * EYES_ON_HEAD;
            }


          
        }
    }


}

    

