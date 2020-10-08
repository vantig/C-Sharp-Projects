using System;
using System.Collections.Generic;

namespace Task11
{
    public class Students
    {


        private const int MIN_MARK = 0;
        private const int MAX_MARK = 10;
        public static string FindBetterStudents(List<string> students, List<int> marks)
        {

            string index = "";
            int max = 0;
            for (int i = 0; i < marks.Count; i++)
            {

                if (marks[i] > max)
                {
                    max = marks[i];
                    index = Convert.ToString(i);
                }
            }

            for (int i = 0; i < marks.Count; i++)
            {
                if (i == int.Parse(index)) continue;
                if (marks[i]==max)
                {
                    index += $" {i}";
                }
                    

            }
            return index;
        }

        public static double FindAverage(List<int> marks)
        {
            int avg=0;
            foreach (var mark in marks)
            {
                avg += mark;
            }

            return (double)avg/marks.Count;
        }

    }
}

