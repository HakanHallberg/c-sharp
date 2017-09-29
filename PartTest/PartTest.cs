using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PartTest
{
    [TestClass]
    public class PartTest
    {
        [TestMethod]
        public void CorrectToString()
        {
            var sut = new Part("Håkan Hallberg", "19800402-3274");
            Assert.AreEqual("Håkan Hallberg (19800402-3274)", sut.ToString());
        }
    }
}
