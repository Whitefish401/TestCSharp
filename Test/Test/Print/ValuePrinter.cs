using System.Collections.Generic;
using System;

namespace CSharpTest
{
    class ValuePrinter
    {
        public void PrintContact(Contact row, IEnumerable<Contact> contacts, int level)
        {
            var indentSize = 2;
            var indent = new string(' ', level * indentSize);
            var arrow = "->";
            if (level == 1)
            {
                Console.WriteLine(indent + row.ToString());
            }
            else
            {
                var arrowIndent = new string(' ', (level - 1) * indentSize);
                Console.WriteLine(arrowIndent + arrow + row.ToString());
            }
            var getChildren = new ChildFinder();
            var children = getChildren.GetChildrenRows(row, contacts);
            foreach (var child in children)
            {
                PrintContact(child, contacts, level+1);
            }
        }
    }
}