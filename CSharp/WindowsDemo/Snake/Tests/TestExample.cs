using System;
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
            // 2-ой тест: 2! = 2
            Assert.AreEqual(2, F.Fact(2));
            // 3-ий тест: 3! = 1*2*3
            Assert.AreEqual(1*2*3, F.Fact(3));
            // 4-ый тест: 4! = 1*2*3*4
            Assert.AreEqual(1*2*3*4, F.Fact(4));
            // 5-ый тест: 5! = 1*2*3*4*5
            Assert.AreEqual(1*2*3*4*5, F.Fact(5));
            // 6-ой тест: 6! = 1*2*3*4*5*6
            Assert.AreEqual(1*2*3*4*5*6, F.Fact(6));
            // 7-ой тест: 11! 
            Assert.AreEqual(1*2*3*4*5*6*7*8*9*10*11, F.Fact(11));
            // 8-ой тест: 15! 
            Assert.AreEqual(1L*2*3*4*5*6*7*8*9*10*11*12*13*14*15, 
                            F.Fact(15));
        }

        /// <summary>
        /// Числа Фибоначчи
        /// </summary>
        [Test]
        public void TestFibonachi(){
            Assert.AreEqual(1, F.Fib(1));
            Assert.AreEqual(1, F.Fib(2));
            Assert.AreEqual(1+1, F.Fib(3));
            Assert.AreEqual(1+1+1, F.Fib(4));
            Assert.AreEqual(433494437, F.Fib(43));
            Assert.AreEqual(2880067194370816120, F.Fib(90));
            
            for(int i=1;;i++)
                System.Console.WriteLine(""+i+"-ое число Фибоначчи = "+F.Fib(i));
        }        
        
        /// <summary>
        /// Квадратное уравнение
        /// </summary>
        [Test]
        public void TestSquareEq(){                               
            F.checkEq(1,0,0);
            F.checkEq(1,-2,1); // x^2 - 2*x + 1
            F.checkEq(1,2,1); 
            F.checkEq(1,0,4); // Нет решений
            
            F.checkEq(0,0,4); // Нет решений
            Assert.AreEqual(0, F.roots(0,0,4).Length );
            
            F.checkEq(0,1,4); // Один корень 
            Assert.AreEqual(1, F.roots(0,1,4).Length );

            try{            
                F.checkEq(0,0,0); // Бесконечное число корней
                Assert.Fail("Ожидалось исключение");
            } catch(Exception ex){
                Assert.AreEqual("x-любое", ex.Message);
            }
        }
    }
}