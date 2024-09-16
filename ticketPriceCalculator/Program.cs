using System;
internal class Program
{
    private static void Main(string[] args)
    {

        double ticketPrice;
        int age;

        do
        {
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
        } while (age < 0);


        if (age >= 65 || age <= 12)
            ticketPrice = 7.00;

        else
            ticketPrice = 10.00;

        Console.WriteLine("The ticket price is: GHC {0}", ticketPrice);
    }
}