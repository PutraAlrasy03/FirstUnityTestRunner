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
    }
}
