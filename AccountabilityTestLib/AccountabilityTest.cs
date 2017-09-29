using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;

namespace AccountabilityTestLib
{
    [TestClass]
    public class AccountabilityTest
    {
        [TestMethod]
        public void CorrectToString()
        {
            var johnSmith = new Part("John Smith", "19000101-1234");
            var someCompany = new Part("JSCompany", "123123-1234");
        
        }
    }
}
