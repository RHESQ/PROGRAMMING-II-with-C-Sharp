using System;
internal class Program
{
    static void Main()
    {
        int scoreGrade;
        char letterGrade;
        do
        {
            Console.Write("Please Enter your score 0-100: ");
            scoreGrade = Convert.ToInt32(Console.ReadLine());
        } while (scoreGrade is < 0 or > 100);


        if (scoreGrade is > 90)
            letterGrade = 'A';

        else if (scoreGrade is >= 80 and <= 89)
            letterGrade = 'B';

        else if (scoreGrade is >= 70 and <= 79)
            letterGrade = 'C';

        else if (scoreGrade is >= 60 and <= 69)
            letterGrade = 'D';

        else
            letterGrade = 'F';

        Console.WriteLine(" {0} -------- {1}.", scoreGrade, letterGrade);
    }
}