using System.Collections.Generic;

namespace CSharpTest
{
    class ValueWriter
    {
        public void WriteData(List<Contact> contacts)
        {
            var sort = new ValueSorter();
            var sortedContacts = sort.SortByID(contacts);
            var filter = new ParentFilter();
            var mainParents = filter.GetMainParents(sortedContacts);
            var print = new ValuePrinter();

            foreach (var row in mainParents)
            {
                print.PrintContact(row, sortedContacts, 1);
            }
        }
    }
}