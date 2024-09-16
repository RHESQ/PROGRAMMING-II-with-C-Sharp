using System;

class Employee
{
    private string name, designation;
    private double salary;

    public string Name
    {
        get => name;
        set { name = value; }
    }

    public string Designation 
    {
        get => designation;
        set { designation = value;  }
    }

    public int Salary
    {
        get => (int)salary;
        set { salary = value; }
    }

    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Name = "John Doe";
        emp.Designation = "Manager";
        emp.Salary = 5000;

        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("Designation: " + emp.Designation);
        Console.WriteLine("Salary: $" + emp.Salary);

    }
}