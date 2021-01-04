using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void OnlyPositives()
        {
            //Initializing the list
            List<int> positiveList = new List<int>();

            //Adding 5 elements
            positiveList.Add(36);
            positiveList.Add(19);
            positiveList.Add(50);
            positiveList.Add(67);
            positiveList.Add(20);

            //The actual test
            Assert.AreEqual(67, Operations.Max(positiveList));
        }

        [Test]
        public void MaxAtBeginning()
        {
            //Initializing the list
            List<int> maxAtBeginning = new List<int>();
            
            //Adding 5 elements
            maxAtBeginning.Add(100);
            maxAtBeginning.Add(50);
            maxAtBeginning.Add(73);
            maxAtBeginning.Add(98);
            maxAtBeginning.Add(25);

            //The actual test
            Assert.AreEqual(100, Operations.Max(maxAtBeginning));
        }

        [Test]
        public void MaxAtMiddle()
        {
            //Initializng the list
            List<int> maxAtMiddle = new List<int>();

            //Adding 5 elements
            maxAtMiddle.Add(61);
            maxAtMiddle.Add(52);
            maxAtMiddle.Add(90);
            maxAtMiddle.Add(6);
            maxAtMiddle.Add(75);

            //The actual test
            Assert.AreEqual(90, Operations.Max(maxAtMiddle));            
        }

        [Test]
        public void MaxAtEnd()
        {
            //Initializing the list
            List<int> maxAtEnd = new List<int>();

            //Adding 5 elements
            maxAtEnd.Add(98);
            maxAtEnd.Add(87);
            maxAtEnd.Add(95);
            maxAtEnd.Add(61);
            maxAtEnd.Add(150);

            //THe actual test
            Assert.AreEqual(150, Operations.Max(maxAtEnd));
        }

        [Test]
        public void NegativeList()
        {
            //Initializing the list
            List<int> negativeList = new List<int>();

            //Adding 5 elements
            int[] numbers = {-65, -4, -98, -32, -45};
            negativeList.AddRange(numbers);

            //The actual test
            Assert.AreEqual(-4, Operations.Max(negativeList));
        }

        [Test]
        public void EmptyList()
        {
            //Initializing the list
            List<int> emptyList = new List<int>();

            //The test
            Assert.AreEqual(0, Operations.Max(emptyList));
        }

        [Test]
        public void NullList()
        {
            List<int> nullList = null;

            Assert.AreEqual(0, Operations.Max(nullList));
        }
    }
}