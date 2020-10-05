using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task08.Task8;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PlayMoodSensorTest()
        {
            var msg = PlayMoodSensor();
            var expected = true;
            Assert.AreEqual(expected, msg.Length > 1);
        }



        [TestMethod]
        public void ReturnDayOfTheWeek_1_Returned_Monday()
        {

            var expected = "Monday";
            Assert.AreEqual(expected, ReturnDayOfTheWeek(1));
        }

        public void IsVowel_A_Returned_true()
        {
            var expected = true;
            Assert.AreEqual(expected, IsVowel("A"));

        }
    }

}
