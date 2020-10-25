using System.Collections.Generic;

namespace CSharpTest
{
    class Program
    {
        static void Main()
        {
            var filePath = new FilePathReader();
            var file = filePath.WriteFilePath();
            var reader = new CSVReader();
            List<string> list = reader.ReadCSVFile(file);
            var idList = new IDList(new ExceptionHandler());
            var contacts = idList.GetIDList(list);
            var data = new ValueWriter();
            data.WriteData(contacts);
        }
    }
}
