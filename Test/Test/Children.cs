using System.Collections.Generic;
using System.Linq;
using IDList;


namespace Children
{
    class GetChildren
    {
        public IEnumerable<Contact> GetChildrenRows(Contact row, IEnumerable<Contact> contacts)
        {
            var children = from c in contacts
                           where c.Parent == row.ID
                           select c;

            return children;
        }
    }
}