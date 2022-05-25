using System;

namespace CSharpMethods;

public class Program
{
    public static void Main(string[] args)
    {

        //?SOLID => CLEAN CODE

        //?constructor 2 =>  ClassName className = "new" ClassName()
        //?public property
        Students students = new Students
        {
            Id=1,
            FirstName = "Tukezban",
            LastName = "Cemaleddinova"
        };

        //?constructor 1 =>  ClassName className = "new" ClassName("firstName","lastName")
        //?private field
        Students students1 = new Students("Tukezban", "Cemaleddinova");

        // call || invoke => public properties FirstName
        students.ShowName2();
    }
}
