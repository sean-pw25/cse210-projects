using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numSquare = SquareNumber(num);
        DisplayResult(name, numSquare);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int num)
    {
        int numSquare = num * num;
        return numSquare;
    }

    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNumber}");
    }
}