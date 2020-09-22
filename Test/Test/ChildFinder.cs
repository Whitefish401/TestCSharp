using System.Collections.Generic;
using System.Linq;


namespace CSharpTest
{
    class ChildFinder
    {
        public IEnumerable<Contact> getChildrenRows(Contact row, IEnumerable<Contact> contacts)
        {
            var children = from c in contacts
                           where c.Parent == row.ID
                           select c;

            return children;
        }
    }
}