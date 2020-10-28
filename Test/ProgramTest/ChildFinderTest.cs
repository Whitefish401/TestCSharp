using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTest;
using System.Collections.Generic;
using System.Linq;

namespace ProgramTest
{
    [TestClass]
    public class ChildFinderTest
    {
        [TestMethod]
        public void TestFindingChildren()
        {
            List<Contact> contacts = new List<Contact>();
            var row = new Contact(44, 0, "Karl", "Keyboard", "uRage", "Hamburg", "Keyboard", 0865429871, 0116725452, 0116725322);
            contacts.Add(row);
            var contact = new Contact(5, 10, "Michael", "Microphone", "Trust", "Barcelona", "Microphone", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            contact = new Contact(10, 44, "Simon", "Speaker", "Logitech", "London", "Speaker", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            var getChildren = new ChildFinder();
            var children = getChildren.GetChildrenRows(row, contacts);
            var testResult = children.First();
            Assert.AreEqual(contact, testResult, "Values filtered correctly");
        }
    }
}
