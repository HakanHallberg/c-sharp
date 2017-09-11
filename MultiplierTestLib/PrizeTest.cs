using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
    [TestClass]
    public class PrizeTest
    {
        [TestMethod]
        public void ExcludeVAT()
        {
            var sut = new MultiplierLib.PurchaseCalculation();
            var total = sut.Execute(10, 100.0M, false);
            Assert.AreEqual(1000.0M, total);
        }
        [TestMethod]
        public void IncludeVAT()
        {
            var sut = new MultiplierLib.PurchaseCalculation();
            var total = sut.Execute(10, 100.0M, true);
            Assert.AreEqual(1250.0M, total);
        }
    }
}
