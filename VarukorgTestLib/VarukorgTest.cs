using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarukorgLib;

namespace VarukorgTestLib
{
    [TestClass]
    public class VarukorgTest
    {
        [TestMethod]
        public void Orderbekräftelse()
        {
            Kund testKund = new Kund("Test Testsson");
            Produkt testLaptop = new Produkt("Laptop test");
            testLaptop.Pris = 4000;
            Produkt testSkärm = new Produkt("Skärm test");
            testSkärm.Pris = 1500;
            Varukorg sut = new Varukorg();
            sut.Kund = testKund;
            sut.LäggTillProdukt(testLaptop);
            sut.LäggTillProdukt(testSkärm);
            var expected = "Test Testsson har beställt varor för 5500 kr";

            sut.Beställ();
            Orderbekräftelse result = sut.Orderbekräftelse;
            string actual = result.Meddelande;

            Assert.AreEqual(expected, actual);
         }
    }
}
