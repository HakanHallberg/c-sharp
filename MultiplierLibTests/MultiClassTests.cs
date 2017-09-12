using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib.Tests
{
    [TestClass()]
    public class MultiClassTests
    {
        [TestMethod()]
        public void SimpleTest()
        {
            //Arrange
            MultiplierLib.MultiClass myTest = new MultiplierLib.MultiClass();
            //Act
            var actual = myTest.Simple(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
    }
}