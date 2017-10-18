using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CostumerServiceTestsLib
{
    [TestClass]
    public class CustomerServiceTest
    {
        [TestMethod]
        public void CompleteFlow()
        {
            var sut = new CustomerService();
            sut.EnterTicket("test@test.com", "Testing", new DateTime(2017, 10, 01))
        }
    }
}
