using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTest;
using System.Collections.Generic;
using System.Linq;

namespace ProgramTest
{
    [TestClass]
    public class ParentFilterTest
    {
        [TestMethod]
        public void TestFilteredParents()
        {
            List<Contact> contacts = new List<Contact>();
            var contact = new Contact(10, 44, "Simon", "Speaker", "Logitech", "London", "Speaker", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            contact = new Contact(5, 10, "Michael", "Microphone", "Trust", "Barcelona", "Microphone", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            contact = new Contact(44, 0, "Karl", "Keyboard", "uRage", "Hamburg", "Keyboard", 0865429871, 0116725452, 0116725322);
            contacts.Add(contact);
            var sort = new ValueSorter();
            var sortedContacts = sort.SortByID(contacts);
            var filter = new ParentFilter();
            var mainParents = filter.GetMainParents(sortedContacts);
            var testResult = mainParents.First();
            Assert.AreEqual(contact, testResult, "Values sorted correctly");
        }
    }
}
