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
            Assert.AreEqual("456", sumStringsasNumbers.kata("", "456"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("5", sumStringsasNumbers.kata("", "5"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("20", sumStringsasNumbers.kata("10", "10"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("145", sumStringsasNumbers.kata("100", "45"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("501", sumStringsasNumbers.kata("456", "45"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            var sumStringsasNumbers = new SumStringsasNumbers();
            Assert.AreEqual("85799", sumStringsasNumbers.kata("00100", "085699"));
        }
    }
}
