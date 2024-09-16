using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the length of side 1: ");
        double side_1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side_2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        double side_3 = Convert.ToDouble(Console.ReadLine());

        if (side_1 == side_2 && side_2 == side_3)
            Console.WriteLine("Equilateral triangle");

        else if (side_1 == side_2 || side_1 == side_3 || side_2 == side_3)
            Console.WriteLine("Isosceles triangle");

        else
            Console.WriteLine("Scalene triangle");
    }
}