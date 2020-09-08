using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new FileReader.CSVReader();
            List<string> list = reader.Reader();
            var idlist = new IDList.IDLists();
            var contacts = idlist.DataTable(list);
            var Data = new Write.WriteValues();
            Data.WriteData(contacts);


        }

    }
}
