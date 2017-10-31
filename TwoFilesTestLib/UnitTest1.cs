using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoFilesLib;

namespace TwoFilesTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoRowsInOneFile()
        {
            string input1 = "12.50\n17.50";
            string input2 = "2\n10";
            string expected = "12.50x2=25.00\n12.50x10=125.00\n17.50x2=35.00\n17.50x10=175.00\n";
            string actual = TwoFiles.Transform(input1, input2);
            Assert.AreEqual(expected, actual);
        }
    }
}
