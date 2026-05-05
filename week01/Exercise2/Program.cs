using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (do NOT include the '%' symbol) ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);
        string letter = "";

        if (intGrade >= 90)
        {
            letter = "A";
        }

        else if (intGrade >= 80)
        {
            letter = "B";
        }

        else if (intGrade >= 70)
        {
            letter = "C";
        }

        else if (intGrade >= 60)
        {
            letter = "D";
        }

        else if (intGrade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (intGrade >= 70)
        {
            Console.WriteLine("Congratulations. You have passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry. You have failed the course. You must get above 70% to pass. Please try again next time.");
        }
    }
}