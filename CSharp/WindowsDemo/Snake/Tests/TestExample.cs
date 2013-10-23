using NUnit.Framework;

namespace Snake.Tests
{
    /// <summary>
    ///     Пример модульного теста на C#
    /// </summary>
    [TestFixture]
    public class TestExample
    {
        [TestFixtureSetUp]
        public void Init()
        {
            // TODO: Add Init code.
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            // TODO: Add tear down code.
        }

        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(4, 2*2);
        }
    }
}