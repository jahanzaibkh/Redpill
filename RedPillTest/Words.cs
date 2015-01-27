using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPillTest.Redpill;

namespace RedPillTest
{
    [TestClass]
    public class Words
    {
        [TestMethod]
        public void TestMethod1()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            string expected = "s'taC dnA lemaC";
            Assert.AreEqual(expected, client.ReverseWords("Cat's And Camel"));
        }
    }
}
