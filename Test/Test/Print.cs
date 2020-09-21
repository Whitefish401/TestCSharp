using System.Collections.Generic;
using ID;
using System;


namespace Print
{
    class ValuePrinter
    {

        public void printContact(Contact row, IEnumerable<Contact> contacts, int level)
        {
            var indentSize = 2;
            var indent = new string(' ', level * indentSize);
            var arrow = new string("->");
            if (level == 1)
            {
                Console.WriteLine(indent + row.ToString());
            }
            else
            {
                var arrowIndent = new string(' ', (level - 1) * indentSize);
                Console.WriteLine(arrowIndent + arrow + row.ToString());
            }
            var getChildren = new Children.ChildFinder();
            var children = getChildren.getChildrenRows(row, contacts);
            foreach (var child in children)
            {
                printContact(child, contacts, level+1);
            }

        }
    }
}