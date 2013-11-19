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
        
        /// <summary>
        /// Test Driven Development - Разработка через тестирование
        ///   1. Пишем тест 
        ///   2. Пишем код
        ///   3. Рефакторинг 
        /// </summary>
        [Test]
        public void TestFactorial(){
            // 1-ый тест: 1! = 1
            Assert.AreEqual(1, F.Fact(1));
            // 2-ый тест: 2! = 2
            Assert.AreEqual(2, F.Fact(2));
            // 3-ый тест: 3! = 1*2*3
            Assert.AreEqual(1*2*3, F.Fact(3));
            // 4-ый тест: 4! = 1*2*3*4
            Assert.AreEqual(1*2*3*4, F.Fact(4));
        }
        
    }
}