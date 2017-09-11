using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
    [TestClass]
    public class MultiClassTest
    {
        [TestMethod]
        public void While()
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
