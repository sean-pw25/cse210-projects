using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = 0;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largestNumber = 0;

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];

            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }
        float average = (float)sum / (float)numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}