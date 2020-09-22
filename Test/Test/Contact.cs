namespace CSharpTest
{
    class Contact
    {
        public Contact(int id, int parent, string firstName, string lastName, string company, string city, string position, int firstNumber, int secondNumber, int thirdNumber)
        {
            ID = id;
            Parent = parent;
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            City = city;
            Position = position;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            ThirdNumber = thirdNumber;


        }
        public int ID;
        public int Parent;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Position;
        public int FirstNumber;
        public int SecondNumber;
        public int ThirdNumber;
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Company + " " + City + " " + Position;
        }
    }

}