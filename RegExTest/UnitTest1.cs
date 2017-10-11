using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegExTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // string pattern = @"(\D*) (\d*) (\d*.\d*) (\d*-\d*)";
            string input = @"""John Smith"" 27 55000.00 070-7112233";
            var expected = @"""John Smith"" 27 55000.00 070-7112233";

            Assert.AreEqual(expected, input);
        }
    }
}
