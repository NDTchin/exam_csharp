// See https://aka.ms/new-console-template for more information

using ExamCsharp.Exam1;

static void Main(string[] args)
{
    People person = new People();

    person.Name = "Marry";
    person.Gender = true; 
    person.Age = 35;
    
    person.DisplayInfo();
    
    person.IncrementAge();
    
    person.DisplayInfo();
}