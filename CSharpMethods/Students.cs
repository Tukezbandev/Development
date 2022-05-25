namespace CSharpMethods;

public class Students
{
    // *private field
    private string _firstName;
    private string _lastName;

    // ?PUBLIC PROPERTIES => Id LastName FirstName
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName
    {
        get { return $"MRS. {_firstName}"; }
        set { _firstName = value; }
    }

    //?constructor 1 =>  ClassName className = "new" ClassName("firstName","lastName")
    public Students(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    //?constructor 2 =>  ClassName className = "new" ClassName()
    public Students() { }

    //? Method1 => call || invoke
    public void ShowName()
    {
        Console.WriteLine($"Ad: {_firstName}");
    }

    //? Method2 => call || invoke
    public void ShowName2()
    {
        Console.WriteLine(FirstName);
    }
}
