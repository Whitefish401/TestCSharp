﻿using System.Collections.Generic;
using System.Linq;
using ID;


namespace Sort
{
    class ValueSorter
    {

        public IEnumerable<Contact> sortByID(List<Contact> contacts)
        {
            //var SortOrder = (from t in contacts
            //                orderby t.ID
            //                 select t);
            var sortOrder = (contacts
                            .OrderBy(C => C.ID)
                            .Select(C => C));
            return sortOrder;
        }

    }
}