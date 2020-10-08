using System;
using System.Collections.Generic;
using UnitTestProject;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> marks = new List<int>() { 5, 7, 10, 6, 9, 10 };
            List<string> students = new List<string>() { "F", "B", "C", "D", "E", "A" };
            List<int> marks1 = new List<int>() { 5, 6,7, 9, 10, 10 };
            Task11.Students.SortStudentsAndMarksByMarks(ref students,ref marks);
            Console.WriteLine(StudentsCheck.AreEqualLists(marks, marks1));
          
        }


    }
}

