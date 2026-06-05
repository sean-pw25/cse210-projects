// exceeded expectations by adding a new activity titled 'awareness' which prompts the user to list things around them.
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            // display the main menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start awareness activity");
            Console.WriteLine("5. Quit");
            Console.Write("\nPlease select a choice from the menu: ");

            try // validate user input and trigger selection
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                }
                else if (choice == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                }
                else if (choice == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                }
                else if (choice == 4)
                {
                    AwarenessActivity awarenessActivity = new AwarenessActivity();
                    awarenessActivity.Run();
                }
            }
            // input is not a number
            catch (FormatException)
            {
                Console.Clear();
            }
        } while (choice != 5);
        // quit
        Console.Clear();
        Console.WriteLine("Goodbye.");
    }
}