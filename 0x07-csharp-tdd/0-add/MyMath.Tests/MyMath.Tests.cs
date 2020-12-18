using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test (Description = "A sum of two positive numbers")]
        public void SumBetweenPositives()
        {
            Assert.AreEqual(10, Operations.Add(3, 7));
            Assert.AreEqual(50, Operations.Add(10, 40));
            Assert.AreEqual(100, Operations.Add(79, 21));
            Assert.AreEqual(9000, Operations.Add(1250, 7750));
        }

        [Test (Description = "A sum of two negative numbers")]
        public void SumBetweenNegatives()
        {
            Assert.AreEqual(-15, Operations.Add(-10, -5));
            Assert.AreEqual(-300, Operations.Add(-30, -270));
            Assert.AreEqual(-5000, Operations.Add(-3002, -1998));
            Assert.AreEqual(-15000, Operations.Add(-12500, -2500));
        }

        [Test (Description = "A sum between a negative and a positive number")]
        public void SumBetweenNegativeAndPositive()
        {
            Assert.AreEqual(0, Operations.Add(10, -10));
            Assert.AreEqual(-4, Operations.Add(-9, 5));
            Assert.AreEqual(20, Operations.Add(35, -15));
            Assert.AreEqual(-200, Operations.Add(-400, 200));
        }

        [Test (Description = "One sum between zeroes")]
        public void SumBetweenZeroes()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }
    }
}
