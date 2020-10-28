using System.Collections.Generic;
using System.Linq;

namespace CSharpTest
{
    public class ParentFilter
    {
        public IEnumerable<Contact> GetMainParents(IEnumerable<Contact> contacts)
        {
            var mainParents = (contacts
                                .Where(c => contacts.All(c2 => c2.ID != c.Parent))
                                .Select(c => c)
                                );
            return mainParents;
        }
    }
}