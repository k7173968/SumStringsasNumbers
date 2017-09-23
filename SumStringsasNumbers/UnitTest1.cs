using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumStringsasNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("000", sumStringsasNumbers.kata("", "456"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("579", sumStringsasNumbers.kata("123", "456"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("000", sumStringsasNumbers.kata("123", "4567"));
        }
    }
}
