using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task06.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void RectangleAreaTest_4on3_Returned_12()
        {
            var expected = 12;
            Assert.AreEqual(FindRectangleArea(4, 3), expected, 0.1);
        }

        [TestMethod]
        public void AverageArithmeticTest_4and6and2_Returned_4()
        {
            var expected = 4;
            Assert.AreEqual(expected, CalculatingAverage.Arithmetic(4, 6, 2), 0.1);
        }

        [TestMethod]
        public void AverageGeometryTest_4and6and2_Returned_4()
        {
            var expected = 3.6;
            Assert.AreEqual(expected, CalculatingAverage.Geometry(4, 6, 2), 0.1);
        }

        [TestMethod]
        public void FindMaxTest_7and11_Returned11()
        {
            var expected = 11;
            Assert.AreEqual(expected, FindMax(11, 7), 0.1);
        }
        [TestMethod]
        public void FindCircleArea_3and5_Returned50()
        {
            var expected = 50.24;
            Assert.AreEqual(expected, FindCircleArea(5, 3), 0.1);
        }
        [TestMethod]
        public void SolveEquationTest_a2_b_Minus8_Returned4()
        {
            var expected =4 ;
            Assert.AreEqual(expected, SolveEquation(2, -8), 0.1);
        }
    }
}