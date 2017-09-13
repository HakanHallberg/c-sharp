/*using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
    [TestClass]
    public class FileConvertionTest
    {
        [TestMethod]
        public void håkan_hallberg_1980()
        {
            var sut = new  MultiplierLib.FileConverter();
            string actual = sut.Transform("håkan;hallberg;1980");
            Assert.AreEqual("HÅKAN HALLBERG ÄR 37 ÅR GAMMAL", actual);
        }

        [TestMethod]
        public void FileConverter()
        {
            var sut = new MultiplierLib.FileConverter();
            sut.TransformFile("before.txt", "actual.txt");
            string expected = File.ReadAllText("after.txt");
            string actual = File.ReadAllText("actual.txt");
            Assert.AreEqual(expected, actual);
        }
    }
}*/
