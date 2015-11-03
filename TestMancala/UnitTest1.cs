using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMancala
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(2 == 2);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(5 == 5);
        }
    }
}
