using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdTest
{
    [TestClass]
    public class IdTest

    {
        public string LastDigit { get; private set; }

        [TestMethod]
        public void IdTestMethod()
        {
            var sut = new IdTest();
            sut.Process("800101012"); // process = metod
            var expected = "3";
            Assert.AreEqual(expected, sut.LastDigit); // LastDigit = property
        }

        private void Process(string idTest)
        {
            this.IdTestMethod();
            
        }
    }
}
