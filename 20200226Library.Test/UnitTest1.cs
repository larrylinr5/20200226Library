using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20200226Library.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            var result = class1.Result1();
            Assert.IsTrue(result == "1234");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Class1 class1 = new Class1();
            var result = class1.Result2();
            Assert.IsTrue(result == "333333");
        }
    }
}
