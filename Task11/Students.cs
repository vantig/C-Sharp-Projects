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
                if (marks[i] == max)
                {
                    index += $" {i}";
                }


            }
            return index;
        }

        public static double FindAverage(List<int> marks)
        {
            int avg = 0;
            foreach (var mark in marks)
            {
                avg += mark;
            }

            return (double)avg / marks.Count;
        }

        static int MinElement(List<string> list, int begin, int end)
        {
            var min = list[begin];
            var minIndex = begin;
            for (int i = begin + 1; i < end; ++i)
            {
                if (string.Compare(min, list[i]) == 1)
                {
                    min = list[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
        static int MinElement(List<int> list, int begin, int end)
        {
            var min = list[begin];
            var minIndex = begin;
            for (int i = begin + 1; i < end; ++i)
            {
                if (min>list[i])
                {
                    min = list[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
        //static void Swap<T>(ref T lhs, ref T rhs)
        //{
        //    T temp;
        //    temp = lhs;
        //    lhs = rhs;
        //    rhs = temp;
        //}
        
        public static void SortStudentsAndMarksByName(ref List<string> students,ref List<int> marks)
        {
            // Selection sort
            // void SelectionSort(vector<int>&values)
            for (byte i = 0; i != students.Count; ++i)
            {
                var j = MinElement(students, i, students.Count);

                var temp = students[i];
                students[i] = students[j];
                students[j] = temp;


                var temp1 = marks[i];
                marks[j] = marks[j];
                marks[i] = temp1;
                //Swap<string>( (students[i]), (students[j]));

            }

        }
        public static void SortStudentsAndMarksByMarks(ref List<string> students, ref List<int> marks)
        {
            // Selection sort
            // void SelectionSort(vector<int>&values)
            for (byte i = 0; i != students.Count; ++i)
            {
                var j = MinElement(marks, i, students.Count);

                var temp = students[i];
                students[i] = students[j];
                students[j] = temp;


                var temp1 = marks[i];
                marks[i] = marks[j];
                marks[j] = temp1;
                //Swap<string>( (students[i]), (students[j]));

            }

        }
    }
}

