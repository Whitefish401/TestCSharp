using System.Collections.Generic;
using System.Linq;
using IDList;
using System;


namespace Print
{
    class PrintValues
    {

        public void PrintContact(Contact row, IEnumerable<Contact> contacts, int level)
        {
            var IndentSize = 4;
            var indent = new string(' ', level * IndentSize);
            Console.WriteLine(indent + row.ToString());
            var getchildren = new Children.GetChildren();
            var children = getchildren.GetChildrenRows(row, contacts);
            foreach (var child in children)
            {
                PrintContact(child, contacts, level+1);
            }

        }
    }
}