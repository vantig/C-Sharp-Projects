using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task07.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TheGreatestTest_4and3and12_Returned_12()
        {
            var expected = 12;
            Assert.AreEqual(TheGreatest(4, 3,12), expected, 0.001);
        }
        [TestMethod]
        public void IsTriangle_3and4and5_Returned_true()
        {
            var expected = true;
            Assert.AreEqual(IsTriangle(4, 3, 5), expected);
        }
        [TestMethod]
        public void IsTriangle_1and4and5_Returned_false()
        {
            var expected = false;
            Assert.AreEqual(IsTriangle(4, 1, 5), expected);
        }
        [TestMethod]
        public void PlayDice_max12_Returned_true()
        {
            var expected = true;
            Assert.AreEqual(1 <= PlayDice()&&PlayDice()<= 12, expected);
        }
        [TestMethod]
        public void IsVowelLetter_a_Returned_true()
        {
            var expected = true;
            Assert.AreEqual(expected, IsVowelLetter("a"));
        }
        [TestMethod]
        public void CountingDragonHeadsTest_5_Returned_15()
        {
            var expected = 15;
            Assert.AreEqual(expected,Task07.Tasks.Dragon.CountingDragonHeads(5));
        }
        [TestMethod]
        public void SolveQuadricEquationTest_a3_b_minus14_c_minus5_Returned_true_5_minus1d3()
        {
            var expected = true;
            double[] array = new double[2];
            var x1 = 5;
            var x2 = -1 / 3;
            Assert.AreEqual(expected, Task07.Tasks.QuadricEquation(3, -14, -5,array));
        }


    }
}