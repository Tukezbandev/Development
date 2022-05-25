using System;

namespace CSharpDemoIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students
            {
                Department = "IT",
                Name = "Tukezban",
                Surname = "Cemalledinova"
            };

            Students students1 = new Students("Aytac", "Abbasova", "Noyutcu");

            students.ShowFullName();
            students1.ShowFullName();

        }
    }

}