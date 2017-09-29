using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceGameTestLib
{
    [TestClass]
    public class DiceGameTest
    {
        [TestMethod]
        public void NewGameReturnsCorrectFeedback()
        {
            var sut = new Dice();
            sut.ThrowDice(2);
            Assert.AreEqual(7, sut.ThrowDice(2));
 
        }
    }
}
