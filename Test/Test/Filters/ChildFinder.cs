using System.Collections.Generic;
using System.Linq;

namespace CSharpTest
{
    public class ChildFinder
    {
        public IEnumerable<Contact> GetChildrenRows(Contact row, IEnumerable<Contact> contacts)
        {
            var children = (contacts
                            .Where(c => contacts.Any(r => row.ID == c.Parent))
                            .Select(c => c)
                            );
            return children;
        }
    }
}