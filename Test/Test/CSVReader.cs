using System.Collections.Generic;
using System.IO;

namespace CSharpTest
{
    class CSVReader
    {
        public List<string> readCSVFile()
        {
            using (var reader = new StreamReader(@"C:\Users\lukas\Desktop\TestCSharp\companies_data.csv"))
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