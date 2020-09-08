using System.Collections.Generic;
using System.Linq;
using IDList;
using System;


namespace FilterValues
{
    class FilterParents
    {
        public IEnumerable<Contact> GetMainParents(IEnumerable<Contact> contacts)
        {
            var MainParents = (from c in contacts
                               where !(from C in contacts
                                       select C.ID).Contains(c.Parent)
                               select c
                               );
            return MainParents;
        }
    }
}