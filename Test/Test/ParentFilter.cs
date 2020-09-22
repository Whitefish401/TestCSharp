using System.Collections.Generic;
using System.Linq;


namespace CSharpTest
{
    class ParentFilter
    {
        public IEnumerable<Contact> getMainParents(IEnumerable<Contact> contacts)
        {
            //var MainParents = (from c in contacts
            //                   where !(from C in contacts
            //                           select C.ID).Contains(c.Parent)
            //                   select c
            //                   );

            var mainParents = (contacts
                                .Where(c => contacts.All(c2 => c2.ID != c.Parent))
                                .Select(c => c)
                                );
            return mainParents;
        }
    }
}