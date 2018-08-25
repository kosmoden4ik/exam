using System;
using exam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            int x = 3;
            int y = 0;
            int expected = 3;
            Calculor calc = new Calculor(x,y);
            double real = calc.Delenie();
            Assert.AreEqual(expected, real);
        }
    }
}
