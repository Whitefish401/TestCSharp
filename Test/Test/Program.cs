using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new FileReader.CSVReader();
            List<string> list = reader.readCSVFile();
            var idList = new ID.idList();
            var contacts = idList.getIDList(list);
            var data = new Write.ValueWriter();
            data.writeData(contacts);


        }

    }
}
