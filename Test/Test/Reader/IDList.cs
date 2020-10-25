using System;
using System.Collections.Generic;

namespace CSharpTest
{
    public class IDList
    {
        private IExceptionHandler _exceptionHandler;
        public IDList(IExceptionHandler handler)
        {
            _exceptionHandler = handler;
        }
        public List<Contact> GetIDList(List<string> list)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                 foreach (var row in list)
                 {
                 var source = row.Split(",");
                 var id = int.Parse(source[0]);
                 var parent = int.Parse(source[1]);
                 var firstName = source[2];
                 var lastName = source[3];
                 var company = source[4];
                 var city = source[5];
                 var position = source[6];
                 var firstNumber = int.Parse(source[7]);
                 var secondNumber = int.Parse(source[8]);
                 var thirdNumber = int.Parse(source[9]);
                 var Contact = new Contact(id, parent, firstName, lastName, company, city, position, firstNumber, secondNumber, thirdNumber);
                 contacts.Add(Contact);
                 }
            }
            catch(FormatException)
            {
                _exceptionHandler.ExitProgram();
            }
            return contacts;
        } 
    }
}