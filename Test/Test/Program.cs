using System.Collections.Generic;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CSharpTest.CSVReader();
            List<string> list = reader.readCSVFile();
            var idList = new CSharpTest.IDList();
            var contacts = idList.getIDList(list);
            var data = new CSharpTest.ValueWriter();
            data.writeData(contacts);


        }

    }
}
