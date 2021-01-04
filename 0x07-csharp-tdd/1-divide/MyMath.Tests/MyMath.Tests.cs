using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void RegularMatrixDivision()
        {
            int[,] normalMatrix = {{1, 2}, {3, 4}};
            int[,] answerMatrix = {{0, 1}, {1, 2}};
            Assert.AreEqual(answerMatrix, Matrix.Divide(normalMatrix, 2));
        }

        [Test]
        public void MatrixDivisionByZero()
        {
            int[,] normalMatrix2 = {{2, 4}, {6, 8}};
            Assert.AreEqual(null, Matrix.Divide(normalMatrix2, 0));
        }

        [Test]
        public void NullMatrix()
        {
            Assert.AreEqual(null, Matrix.Divide(null, 69));
        }
    }
}