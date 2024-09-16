using System;
class Student
{
    private string name;
    private int age;
    private int grade;

    public void SetName(string studentName)
    {
        name = studentName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int studentAge)
    {
        age = studentAge;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGrade(int studentGrade)
    {
        grade = studentGrade;
    }

    public int GetGrade()
    {
        return grade;
    }
    
    static void Main(string[] args)
    {
        Student student = new Student();
        student.SetName("John Doe");
        student.SetAge(18);
        student.SetGrade(12);

        Console.WriteLine("Student Details:");
        Console.WriteLine("Name: " + student.GetName());
        Console.WriteLine("Age: " + student.GetAge());
        Console.WriteLine("Grade: " + student.GetGrade());

    }
}