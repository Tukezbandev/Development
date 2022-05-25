using System;

namespace DemoExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Students students = new Students { FirstName = "ELdar", LastName = "Dalgatov" };
            Students students1 = new Students("Murad", "Dadasov");
            Students students2 = new Students();
            students2.FirstName = "Faiq";
            students2.LastName = "Agayev";

            students.ShowData();
            students1.ShowData();
            students2.ShowData();
        }
    }
}
