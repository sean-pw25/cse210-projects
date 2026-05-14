// exceeded requirements by adding the feature to name each entry. The user is prompted to name an entry when selecting the "write" option. This is then stored in the entry object

using System;
using System.ComponentModel;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // main menu
        Journal theJournal = new Journal();
        int choice = 0;
        while (choice != 5)
        {
            // create and display a menu of options to the user
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            try
            {
                choice = int.Parse(Console.ReadLine());
                // create journal object
                if (choice == 1) // write
                {
                    Entry entry = new Entry();
                    // ask the user for the name of the entry
                    Console.Write("What would you like to name this entry? ");
                    entry._name = Console.ReadLine();
                    // generate prompt
                    PromptGenerator prompt = new PromptGenerator();
                    string promptText = prompt.GetRandomPrompt();
                    // store prompt
                    entry._promptText = promptText;
                    Console.WriteLine(promptText);
                    Console.Write("> ");
                    // store entry
                    entry._entryText = Console.ReadLine();
                    // store current date
                    DateTime dateTime = DateTime.Now;
                    string dateText = dateTime.ToShortDateString();
                    entry._date = dateText;
                    theJournal.AddEntry(entry);
                }
                if (choice == 2)
                {
                    // display
                    theJournal.DisplayAll();
                }
                if (choice == 3)
                {
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();
                    theJournal.LoadFromFile(file);
                }
                if (choice == 4)
                {
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();
                    theJournal.SaveToFile(file);
                }
                // input is outside of range of options
                else if (choice < 1 || choice > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Choice. Please select one of the options listed.");
                }
            }
            // input is not a number
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Choice. Please select one of the options listed.");
            }
        }
        // quit
        Console.WriteLine("Goodbye.");
    }
}