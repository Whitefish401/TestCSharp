using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    class CSVReader
    {
        public List<string> Reader()
        {
            using (var reader = new StreamReader(@"C:\Users\lukas\Desktop\TestCSharp\companies_data.csv"))
            {
                List<string> Contacts = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    Contacts.Add(line);

                }
                return Contacts;
            }
        }
    }
}