namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        /*
                private DateTime _birthdate;
                public DateTime BirthDate
                {
                    get { return _birthdate; }
                    set { _birthdate = value; }
                }
        */
        /*
                private DateTime _birthdate;
                public DateTime BirthDate
                {
                    get { return _birthdate; }
                    set => _birthdate = value;
                }
        */
        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                return timeSpan.Days / 365;
            }
        }

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
