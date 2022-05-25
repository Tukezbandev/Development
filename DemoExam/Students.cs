namespace DemoExam
{
    public class Students
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return $"MR. {_firstName}"; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }

        public Students(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Students() { }

        public void ShowData()
        {
            Console.WriteLine(_firstName);
        }
    }
}
