using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPillTest.Redpill;

namespace RedPillTest
{
    [TestClass]
    public class Fibnoacci
    {
        [TestMethod]
        public void TestMethod1()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            Assert.AreEqual(14930352,client.FibonacciNumber(36));
        }
    }
}
