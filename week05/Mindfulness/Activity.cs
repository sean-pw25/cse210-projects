public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    protected void DisplayStartingMessage()
    {
        // welcome the user to the activity
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        // ask the user how long they would like the activity to last in seconds
        Console.Write("How long, in seconds, would you like for your session? ");

        // validate input
        try
        {
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);

        }
        catch (FormatException) // if the user input is invalid
        {
            // display starting message over again
            DisplayStartingMessage();
        }


    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        // store animation "frames" in a list of strings
        List<string> spinnerAnimationStrings = ["|", "/", "-", "\\"];

        // calculate time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            // display spinner animation
            Console.Write(spinnerAnimationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerAnimationStrings.Count)
            {
                i = 0;
            }
        }

    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}