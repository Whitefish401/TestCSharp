using System.Collections.Generic;
using System.Linq;
using IDList;
using System;


namespace Sort
{
    class SortBy
    {

        public IEnumerable<Contact> SortByID(List<Contact> contacts)
        {
            var SortOrder = (from t in contacts
                            orderby t.ID
                             select t);
            return SortOrder;
        }

    }
}