using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task_04.Tasks;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReverseStrTest_str_Returned_rts()
        {
            var expected ="rts";
            var str = "str";
                Assert.AreEqual(expected,ReverseString(str) );         
        }
        [TestMethod]
        public void ReverseNumTest_189_Returned_981()
        {
            var expected = 981;
            var actual = 189;
            Assert.AreEqual(expected, ReverseNumber(actual));
        }
        [TestMethod]
        public void DateForDayBeginInHours()
        {
          var expected = System.DateTime.Now.Hour;
          
            Assert.AreEqual(expected, TimeFromTheBeginningOfTheDay.ConvertInHours(),1);
        }
        [TestMethod]
        public void NumberAverageTest_37_Returned_5()
        {
           var expected =5;
          
            Assert.AreEqual(expected, CalculatingArithmeticMean(37),1);
        }
    }
}
