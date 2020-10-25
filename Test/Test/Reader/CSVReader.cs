using System.Collections.Generic;
using System.IO;

namespace CSharpTest
{
    class CSVReader
    {
        public List<string> ReadCSVFile(string file)
        {
            using (var reader = new StreamReader(file))
            {
                List<string> contacts = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    contacts.Add(line);

                }
                return contacts;
            }
        }
    }
}