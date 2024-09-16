using System;

class Car
{
    private string make;
    private string model;
    private int year;

    public string Make
    {
        get =>  make; 
        set => make = value; 
    }

    public string Model
    {
        get => model; 
        set => model = value; 
    }

    public int Year
    {
        get => year; 
        set => year = value; 
    }

    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2022;

        Console.WriteLine("Car Details:");
        Console.WriteLine("Make: " + myCar.Make);
        Console.WriteLine("Model: " + myCar.Model);
        Console.WriteLine("Year: " + myCar.Year);
    }
}