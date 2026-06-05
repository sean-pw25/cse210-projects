public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];


    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many\nthings as you can in a certain area.";
        _count = 0;
    }


    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = [];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        } while (DateTime.Now < endTime);

        return userList;
    }
}