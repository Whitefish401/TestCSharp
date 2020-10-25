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
            var id = 10;
            var parent = 44;
            var firstName = "Simon";
            var lastName = "Speaker";
            var company = "Logitech";
            var city = "London";
            var position = "Speaker";
            var firstNumber = 0865429871;
            var secondNumber = 0116725452;
            var thirdNumber = 0116725322;
            var contact = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
            contacts.Add(contact);
            id = 5;
            parent = 10;
            firstName = "Michael";
            lastName = "Microphone";
            company = "Trust";
            city = "Barcelona";
            position = "Microphone";
            firstNumber = 0865429871;
            secondNumber = 0116725452;
            thirdNumber = 0116725322;
            contact = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
            contacts.Add(contact);
            var sort = new ValueSorter();
            var sortedContacts = sort.SortByID(contacts);
            var testResult = sortedContacts.First();
            Assert.AreEqual(contact, testResult, "Values sorted correctly");
        }
    }
}
