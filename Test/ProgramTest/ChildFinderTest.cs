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
            var id = 44;
            var parent = 0;
            var firstName = "Karl";
            var lastName = "Keyboard";
            var company = "uRage";
            var city = "Hamburg";
            var position = "Keyboard";
            var firstNumber = 0865429871;
            var secondNumber = 0116725452;
            var thirdNumber = 0116725322;
            var row = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
            contacts.Add(row);
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
            var contact = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
            contacts.Add(contact);
            id = 10;
            parent = 44;
            firstName = "Simon";
            lastName = "Speaker";
            company = "Logitech";
            city = "London";
            position = "Speaker";
            firstNumber = 0865429871;
            secondNumber = 0116725452;
            thirdNumber = 0116725322;
            contact = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
            contacts.Add(contact);
            var getChildren = new ChildFinder();
            var children = getChildren.GetChildrenRows(row, contacts);
            var testResult = children.First();
            Assert.AreEqual(contact, testResult, "Values filtered correctly");
        }
    }
}
