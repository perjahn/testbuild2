using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
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
            var myclass = new MyClass1();
            var result = myclass.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}