using System.Collections.Generic;
using ID;


namespace Write
{
    class ValueWriter
    {
        public void writeData(List<Contact> contacts)
        {
            var sort = new Sort.ValueSorter();
            var sortedContacts = sort.sortByID(contacts);
            var filter = new FilterValues.ParentFilter();
            var mainParents = filter.getMainParents(sortedContacts);
            var print = new Print.ValuePrinter();

            foreach (var row in mainParents)
            {
                print.printContact(row, sortedContacts, 1);
            }
        }
    }
}