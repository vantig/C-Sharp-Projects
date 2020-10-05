using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task9.Task09;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void CalculateAverage_123_Returned_2()
        {


            double expected = 2;


            Assert.AreEqual(expected, CalculateAverage(123), 0.1);
        }

        [TestMethod]
        public void CheckNumberSequence_321_Returned_true()
        {


            var expected = true;


            Assert.AreEqual(expected, CheckNumberSequence(123));
        }

        [TestMethod]
        public void CalculationDepositDuration_20_Returned_4()
        {


            var expected = 4;


            Assert.AreEqual(expected, CalculationDepositDuration(20));
        }
    }
}
