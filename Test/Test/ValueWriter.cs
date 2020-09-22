using System.Collections.Generic;


namespace CSharpTest
{
    class ValueWriter
    {
        public void writeData(List<Contact> contacts)
        {
            var sort = new CSharpTest.ValueSorter();
            var sortedContacts = sort.sortByID(contacts);
            var filter = new CSharpTest.ParentFilter();
            var mainParents = filter.getMainParents(sortedContacts);
            var print = new CSharpTest.ValuePrinter();

            foreach (var row in mainParents)
            {
                print.printContact(row, sortedContacts, 1);
            }
        }
    }
}