using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task11.Students;
using System.Collections.Generic;
namespace UnitTestProject
{
    public static class StudentData
    {
      public static List<string> students = new List<string>(){ "F", "B","C","D","E","A"};
      public static List<int> marks = new List<int>() { 5,7,10,6,9,10 };
    }

    public class StudentsCheck
    {
        public static bool AreEqualLists(List<int> list1, List<int> list2)
        {
            bool flag = true;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    flag = false;
                }
            }

            return flag;
        }
        public static bool AreEqualLists(List<string> list1, List<string> list2)
        {
            bool flag = true;
            for (int i = 0; i < list1.Count; i++)
            {
                if (string.Compare(list1[i], list2[i]) != 0)
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
    [TestClass]
    public class UnitTest
    {
      
        [TestMethod]
        public void FindBetterStudents_students_marks_Returned_string_2_5()
        {
            var expected = "2 5";
          Assert.AreEqual(expected, FindBetterStudents(StudentData.students, StudentData.marks)); 
        }

        [TestMethod]
        public void FindAverageMark_marks_Returned_7dot83()
        {
            var expected = 7.83;
            Assert.AreEqual(expected, FindAverage( StudentData.marks),0.01);
        }
        [TestMethod]
        public void SortStudentsAndMarksByName_students_marks_Returned_true()
        {
            List<string> expectedList = new List<string>() { "A", "B", "C", "D", "E", "F" };
            
               var expected = true;

            SortStudentsAndMarksByName(ref StudentData.students,ref StudentData.marks);
            Assert.AreEqual(expected,StudentsCheck.AreEqualLists(StudentData.students,expectedList));
        }
        [TestMethod]
        public void SortStudentsAndMarksByMarks_students_marks_Returned_true()
        {
            List<int> expectedList = new List<int>() { 5, 6, 7, 9, 10, 10 };

            var expected = true;

            SortStudentsAndMarksByMarks(ref StudentData.students, ref StudentData.marks);
            Assert.AreEqual(expected, StudentsCheck.AreEqualLists(StudentData.marks, expectedList));
        }
    }
}
