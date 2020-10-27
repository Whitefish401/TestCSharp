using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTest;
using System.Collections.Generic;
using System.Linq;

namespace ProgramTest
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void TestSortedValues()
        {
            List<Contact> contacts = new List<Contact>();
            var contact = new Contact(10, 44, "Simon", "Speaker", "Logitech", "London", "Speaker", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            contact = new Contact(5, 10, "Michael", "Microphone", "Trust", "Barcelona", "Microphone", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            var sort = new ValueSorter();
            var sortedContacts = sort.SortByID(contacts);
            var testResult = sortedContacts.First();
            Assert.AreEqual(contact, testResult, "Values sorted correctly");
        }
    }
}
