using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guess = 0;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} tries.");
            }
        }
    }
}