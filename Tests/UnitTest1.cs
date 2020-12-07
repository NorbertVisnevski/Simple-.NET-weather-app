using APILibrary;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var moq = new Mock<ForecastRequest>();
            Assert.Pass();
        }
    }
}