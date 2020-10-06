using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void PlayHeadsOrTails_50()
        {
            string temp = "", num1 = "", num2 = "";
            var str = Task10.Task.PlayHeadsOrTails(50);
            foreach (var VARIABLE in str)
            {
                if (VARIABLE != ' ')
                {
                    temp += VARIABLE;
                }
                else
                {
                    num1 = temp;
                }
            }



            num2 = temp;
            Assert.AreEqual(true, int.Parse(num1) > 0 && int.Parse(num2) > 0);
        }

        [TestMethod]
        public void FlipNumberWithoutZeros_102_Returned_21()
        {
            var expected = 21;
            Assert.AreEqual(expected,Task10.Task.FlipNumberWithoutZeros(102));
        }
        
        [TestMethod]
        public void IsPrimeNumber_5_Returned_true()
        {
            var expected = true;
            Assert.AreEqual(expected, Task10.Task.IsPrimeNumber(5));
        }
        public void IsPrimeNumber_4_Returned_false()
        {
            var expected = false;
            Assert.AreEqual(expected, Task10.Task.IsPrimeNumber(4));
        }
    }
}
