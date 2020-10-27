using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTest;
using System.Collections.Generic;

namespace ProgramTest
{
    [TestClass]
    public class NoFileListTest
    {
        [TestMethod]
        public void TestNotExistingFile()
        {
            var fakeFilePath = "C:/Users/lukas/Desktop/TestCSharp/FakeFile.csv";
            var reader = new CSVReader();
            List<string> list = reader.ReadCSVFile(fakeFilePath);
            Assert.AreEqual(list, null, "Values sorted correctly");
        }
    }
}
