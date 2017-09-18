using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirkusenElefanten;

namespace CirkusenElefantenTest
{
    [TestClass]
    public class ElefantenTest
    {
        [TestMethod]
        public void TestToString()
        {
            Cirkus sut = new Cirkus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Lindansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansare);
            sut.Artistuppträdande(clown);
            sut.Artistuppträdande(lindansare);
            sut.Artistuppträdande(lindansare);
            var expected = "Cirkusen Elefanten har 2 artister. Clownen Surskratt har uppträtt 1 gång. Lindansaren Repo har uppträtt 2 gånger.";
            
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);

        }
    }
}
