using System.Collections.Generic;
using IDList;
using System;


namespace Write
{
    class WriteValues
    {
        public void WriteData(List<Contact> contacts)
        {
            var sort = new Sort.SortBy();
            var SortedContacts = sort.SortByID(contacts);
            var filter = new FilterValues.FilterParents();
            var MainParents = filter.GetMainParents(SortedContacts);
            var print = new Print.PrintValues();

            foreach (var row in MainParents)
            {
                print.PrintContact(row, SortedContacts, 1);
            }
        }
    }
}