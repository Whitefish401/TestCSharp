using System.Collections.Generic;
using System.Linq;

namespace CSharpTest
{
    public class ValueSorter
    {
        public IEnumerable<Contact> SortByID(List<Contact> contacts)
        {
            var sortOrder = (contacts
                            .OrderBy(C => C.ID)
                            .Select(C => C));
            return sortOrder;
        }
    }
}