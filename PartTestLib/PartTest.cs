using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;

namespace PartTestLib
{
    [TestClass]
    public class PartTest
    {
        [TestMethod]
        public void CorrectToString()
        {
            var sut = new Part("John Smith", "19000101-1234");
            Assert.AreEqual("John Smith (19000101-1234)", sut.ToString());
        }

        [TestMethod]
        public void CanHandleThreeAccountabilities()
        {
            var sut = new Part("John Smith", "19000101-1234");
            Assert.AreEqual("John Smith (19000101-1234)", sut.ToString());
        }
    }
}
