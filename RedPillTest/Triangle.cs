using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPillTest.Redpill;

namespace RedPillTest
{
    [TestClass]
    public class Triangle
    {
        [TestMethod]
        public void Equilateral()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            Assert.AreEqual(TriangleType.Equilateral,client.WhatShapeIsThis(1,1,1));
        }

        [TestMethod]
        public void Isosceles()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            Assert.AreEqual(TriangleType.Isosceles, client.WhatShapeIsThis(2,2,3));
        }

        [TestMethod]
        public void Scalene()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            Assert.AreEqual(TriangleType.Scalene, client.WhatShapeIsThis(5,6,7));
        }

        [TestMethod]
        public void Error()
        {
            Redpill.RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
            Assert.AreEqual(TriangleType.Error, client.WhatShapeIsThis(0,0,0));
        }
    }
}
