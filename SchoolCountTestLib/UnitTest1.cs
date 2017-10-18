using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolCount;

namespace SchoolCountTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var aSchool = new School("Säve");
            var aClass1 = new Class(28);
            var aClass2 = new Class(28);
            var aClass3 = new Class(28);
            aSchool.Classes.Add(aClass1);
            aSchool.Classes.Add(aClass2);
            aSchool.Classes.Add(aClass3);
            Assert.AreEqual($"There are 84 number of students in this school.");
        }
    }
}
