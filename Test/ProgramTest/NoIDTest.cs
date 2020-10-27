using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTest;
using System.Collections.Generic;
using FakeItEasy;

namespace ProgramTest
{
    [TestClass]
    public class IDListTest
    {
        [TestMethod]
        public void TestNoIDRow()
        {
            var line = ",18,Samantha,McFee,Oracle,Johannesburg,Junior Analyst,0826984512,0113589799,0113589798";
            List<string> noID = new List<string>();
            noID.Add(line);
            var exceptionHandler = A.Fake<IExceptionHandler>();
            var idList = new IDList(exceptionHandler);
            var contacts = idList.GetIDList(noID);
            A.CallTo(() => exceptionHandler.ExitProgram()).MustHaveHappened();
        }
    }
}
