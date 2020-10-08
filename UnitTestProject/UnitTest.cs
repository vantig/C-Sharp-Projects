using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task11.Students;
using System.Collections.Generic;
namespace UnitTestProject
{
    static class StudentData
    {
      public static List<string> students = new List<string>(){" A","B","C","D","E","F"};
      public static List<int> marks = new List<int>() { 5,7,10,6,9,10 };
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
    }
}
