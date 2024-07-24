namespace ExamCsharp.Exam1;

public class People
{
    private string _name;
    private bool _gender;
    private int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public bool Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
        Console.WriteLine($"Age: {Age}");
    }

    public void IncrementAge()
    {
        Age+= 10;
    }
}