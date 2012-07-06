using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLib;

namespace DemoTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddOk()
        {
            Assert.AreEqual(4, new Calculator().Add(2, 2));
        }
    }
}
