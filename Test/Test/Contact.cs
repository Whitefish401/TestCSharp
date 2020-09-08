namespace IDList
{
    class Contact
    {
        public Contact(int id, int parent, string fname, string lname, string company, string city, string position, int no1, int no2, int no3)
        {
            ID = id;
            Parent = parent;
            FName = fname;
            LName = lname;
            Company = company;
            City = city;
            Position = position;
            No1 = no1;
            No2 = no2;
            No3 = no3;


        }
        public int ID;
        public int Parent;
        public string FName;
        public string LName;
        public string Company;
        public string City;
        public string Position;
        public int No1;
        public int No2;
        public int No3;
        public override string ToString()
        {
            return FName + " " + LName + " " + Company + " " + City + " " + Position;
        }
    }

}