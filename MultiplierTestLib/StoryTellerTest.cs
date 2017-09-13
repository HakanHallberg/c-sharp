using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestLib
{
    [TestClass]
    public class StoryTellerTest
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellStory("Loke", 2, false);
            Assert.AreEqual($"Lyssna nu Loke. Det var en gång en prinsessa som tyckte om att dansa.", actual);

        }

        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellStory("Lucia", 7, false);
            Assert.AreEqual($"Hallå Lucia! En gång fanns en kille som tyckte om att dansa.", actual);

        }

        [TestMethod]
        public void TellStoryToOldScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellStory("Lucia", 7, true);
            Assert.AreEqual($"Hallå Lucia! En gång fanns en kille som egentligen var en varulv.", actual);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellStory("Loke", 2, true);
           

        }
    }
}
