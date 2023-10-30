using NUnit.Framework;

namespace Tests
{
    public class BasicCounter
    {
        private int count;

        public BasicCounter()
        {
            count = 0;
        }

        public BasicCounter(int initialCount) // Constructor with initial count
        {
            count = initialCount;
        }

        public int Count
        {
            get { return count; }
        }

        public void Increment()
        {
            count++;
        }
    }

    public class NewTestScript
    {
        [Test]
        public void TestIncrement()
        {
            // Arrange
            var counter = new BasicCounter();

            // Act
            counter.Increment();

            // Assert
            Assert.AreEqual(1, counter.Count);
        }

        [Test]
        public void TestMaxCount()
        {
            var counter = new BasicCounter(10); // Create with an initial count of 10

            counter.Increment();
            Assert.AreEqual(11, counter.Count); // Expect the count to be 11 after increment
        }
    }
}
