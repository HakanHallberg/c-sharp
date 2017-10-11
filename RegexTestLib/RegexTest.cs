using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;

namespace RegexTestLib
{
    [TestClass]
    public class RegexTest
    {
        [TestMethod]
        public void CanRead()
        {
            var streamReader = File.OpenText(@"SIEI.txt");
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                Debug.WriteLine(line);
            }
        }
    }
}
