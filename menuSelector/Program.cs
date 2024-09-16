using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1) Play");
        Console.WriteLine("2) Pause");
        Console.WriteLine("3) Stop");

        Console.Write("Enter your choice (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Play");
                break;
            case 2:
                Console.WriteLine("You selected Pause");
                break;
            case 3:
                Console.WriteLine("You selected Stop");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}