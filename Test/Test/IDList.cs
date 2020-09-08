using System.Collections.Generic;

namespace IDList
{
    class IDLists
    {
        public List<Contact> DataTable(List<string> list)
        {
            List<Contact> Contacts = new List<Contact>();

                foreach (var row in list)
                {
                    var Source = row.Split(",");
                    var ID = int.Parse(Source[0]);
                    var Parent = int.Parse(Source[1]);
                    var FName = Source[2];
                    var LName = Source[3];
                    var Company = Source[4];
                    var City = Source[5];
                    var Position = Source[6];
                    var No1 = int.Parse(Source[7]);
                    var No2 = int.Parse(Source[8]);
                    var No3 = int.Parse(Source[9]);

                    var Contact = new Contact (ID, Parent, FName, LName, Company, City, Position, No1, No2, No3);
                    Contacts.Add(Contact);

                }

            return Contacts;

            
        }
        
    }

}