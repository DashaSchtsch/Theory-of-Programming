using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace testLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateRandomMatrixMethod()
        {
            // Arrange
            int matrixSize = 3;

            // Act
            int[,] matrix = lab1.Program.GenerateRandomMatrix(matrixSize);

            // Assert
            Assert.AreEqual(matrixSize, matrix.GetLength(0), "Number of rows does not match");
            Assert.AreEqual(matrixSize, matrix.GetLength(1), "Number of columns does not match");
        }

        [TestMethod]
        public void TestCalculateSumMethod()
        {
            // Arrange
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int minValue = 3;
            int maxValue = 7;

            // Act
            int[] sum = lab1.Program.CalculateSum(3, matrix, minValue, maxValue);

            // Assert
            Assert.AreEqual(3, sum[0], "Sum for row 0 is incorrect");
            Assert.AreEqual(0, sum[1], "Sum for row 1 is incorrect");
            Assert.AreEqual(17, sum[2], "Sum for row 2 is incorrect");
        }
    }
}
