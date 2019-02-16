using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci.Models;

namespace Fibonacci.Tests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void Constructor_SetsNthTerm_Int()
        {
            int testNumber = 10;
            Counter testCounter = new Counter(testNumber);
            Assert.AreEqual (testNumber, testCounter.GetN());
        }
        [TestMethod]
        public void Counter_CountsToN_Int()
        {
            int testNumber = 10;
            Counter testCounter = new Counter(testNumber);
            Assert.AreEqual (55, testCounter.SetNumbers());
        }
    }
}