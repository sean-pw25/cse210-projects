public class AwarenessActivity : Activity
{
    public AwarenessActivity()
    {
        _name = "Awareness Activity";
        _description = "This activity will help you practice mindfulness by helping you identify your surroundings. This activity is often called the '5-4-3-2-1 Technique' because it focuses on each of the five senses\nYou will identify five things you see, four things you feel, three things you hear, two things you smell, and one thing you taste.";
    }


    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("\nTake a moment to be aware of your surroundings. Identify what you can see around you, what you feel, what you hear, what you can smell, and what you can taste...");
        ShowSpinner(_duration);
        Console.WriteLine("\nPlease list 5 things you can see.");
        PromptForSenses(5);
        Console.WriteLine("\nPlease list 4 things you can physically feel.");
        PromptForSenses(4);
        Console.WriteLine("\nPlease list 3 things you can hear.");
        PromptForSenses(3);
        Console.WriteLine("\nPlease list 2 things you can smell.");
        PromptForSenses(2);
        Console.WriteLine("\nPlease list 1 thing you can taste.");
        PromptForSenses(1);

        DisplayEndingMessage();
    }

    private void PromptForSenses(int numberOfRequiredEntries)
    {
        for (int i = 0; i < numberOfRequiredEntries; i++)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}