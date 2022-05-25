namespace CSharpDemoIntro;

public class Students
{
    
        private string _name;
        private string _surname;
        private string _department;

        public string Name { get { return $"MRS {_name}"; } set { _name = value; } }
        public string Surname { get; set; }
        public string Department { get; set; }


        public Students()
        {

        }
        public Students(string name, string surname, string department)
        {
            _name = name;
            _surname = surname;
            _department = department;
        }

        public void ShowFullName()
        {
            Console.WriteLine($"Student name is: {_name} {_surname}");
        }
}
